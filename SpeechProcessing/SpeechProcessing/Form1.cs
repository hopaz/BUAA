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

namespace SpeechProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //选择文件按钮
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.SelectedText = dialog.FileName;
            }
        }

        // 调用getAccessToken()获取的 access_token建议根据expires_in 时间 设置缓存
        // 百度云中开通对应服务应用的 API Key 建议开通应用的时候多选服务
        private static String API_KEY = "ZiUC7H5c7Fkdan8n6Xj5vG3t";
        // 百度云中开通对应服务应用的 Secret Key
        private static String SECRET_KEY = "ZAV5r9h6BhmIeSa5zYx2L4plskh7IcsD";
        
        private void button2_Click(object sender, EventArgs e)
        {
            //开始识别按钮
            //请求语音识别接口
            var data = File.ReadAllBytes(textBox1.Text);
            var options = new Dictionary<string, object>{
                {"dev_pid", 1537}
            };
            var client = new Baidu.Aip.Speech.Asr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;
            Console.Write(this.audio_format.Text);
            JObject result = new JObject();
            switch(this.audio_format.Text){
                case "pcm":
                    result = client.Recognize(data, "pcm", 16000, options);
                    break;
                case "wav":
                    result = client.Recognize(data, "wav", 16000, options);
                    break;
                case "amr":
                    result = client.Recognize(data, "amr", 16000, options);
                    break;
                case "m4a":
                    result = client.Recognize(data, "m4a", 16000, options);
                    break;
            }
            this.recog_result.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
            var option = new Dictionary<string, object>()
            {
                {"spd", 5}, // 语速
                {"vol", 7}, // 音量
                {"per", 4}  // 发音人，4：情感度丫丫童声
            };
            var result = client.Synthesis(this.synthesis_input.Text, option);
            if (result.ErrorCode == 0)  // 或 result.Success
            {
                File.WriteAllBytes(@"D:\BUAA\SpeechProcessing\samples\合成的语音.mp3", result.Data);
            }
        }
    }
}
