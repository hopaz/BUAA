using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace SpeechProcessing
{
    public partial class Form1 : Form
    {

        [DllImport("winmm.dll", SetLastError = true)]
        static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        private void playSound(string audioPath)
        {
            // 播放音频文件
            mciSendString("open " + audioPath + " alias temp_alias", null, 0, IntPtr.Zero);
            mciSendString("play temp_alias", null, 0, IntPtr.Zero);

            // 等待播放结束
            StringBuilder strReturn = new StringBuilder(64);
            do
            {
                mciSendString("status temp_alias mode", strReturn, 64, IntPtr.Zero);
            } while (!strReturn.ToString().Contains("stopped"));

            // 关闭音频文件
            mciSendString("close temp_alias", null, 0, IntPtr.Zero);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FileDialog_Click(object sender, EventArgs e)
        {
            //选择文件按钮
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtAudioPath.Text = dialog.FileName;
            }
        }

        private void btn_Recognize_Click(object sender, EventArgs e)
        {
            //开始识别按钮
            //请求语音识别接口
            var audioPath = this.txtAudioPath.Text;
            var audioFormat = this.comboAudioFormat.Text;
            var modelType = this.comboModelType.Text;
            var client = BaiduSpeechManager.GetInstance();
            var result = client.Recognize(audioPath, audioFormat, modelType);
            this.txtRecogResult.Text = result;
        }

        private void btn_Synthesis_Click(object sender, EventArgs e)
        {
            //开始合成按钮
            var perDict = new Dictionary<string, int>()
            {
                {"度小宇", 1},
                {"度小美", 0},
                {"度逍遥", 3},
                {"度丫丫", 4},
            };
            var per = perDict[this.comboPer.Text];

            var spd = (int)this.numSpd.Value;
            var pit = (int)this.numPit.Value;
            var vol = (int)this.numVol.Value;

            var aueDict = new Dictionary<string, int>()
            {
                {"mp3", 3},
                {"pcm-16k", 4},
                {"pcm-8k", 5},
                {"wav", 6},
            };
            var aue = aueDict[this.comboAue.Text];
            var text = this.txtSynthesisInput.Text;

            var audioSuffix = this.comboAue.Text.Split('-')[0];
            var audioPath = @".\samples\合成的语音." + audioSuffix;

            var client = BaiduSpeechManager.GetInstance();
            File.Delete(audioPath);
            client.Synthesis(per, spd, pit, vol, aue, text, audioPath);
            if (audioSuffix != "pcm")
            {
                playSound(audioPath);
            }
        }
    }
}