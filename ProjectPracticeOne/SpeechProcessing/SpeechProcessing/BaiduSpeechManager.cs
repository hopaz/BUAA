using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpeechProcessing
{
    class BaiduSpeechManager
    {
        // 调用getAccessToken()获取的 access_token建议根据expires_in 时间 设置缓存
        // 百度云中开通对应服务应用的 API Key 建议开通应用的时候多选服务
        private static String API_KEY = "ZiUC7H5c7Fkdan8n6Xj5vG3t";
        // 百度云中开通对应服务应用的 Secret Key
        private static String SECRET_KEY = "ZAV5r9h6BhmIeSa5zYx2L4plskh7IcsD";
        private Baidu.Aip.Speech.Asr asrClient = null;
        private Baidu.Aip.Speech.Tts ttsClient = null;

        // 单例
        private static BaiduSpeechManager singleton = null;

        // 获取单例
        public static BaiduSpeechManager GetInstance()
        {
            if (BaiduSpeechManager.singleton == null)
                BaiduSpeechManager.singleton = new BaiduSpeechManager();
            return BaiduSpeechManager.singleton;
        }

        // 初始化语音客户端
        private BaiduSpeechManager()
        {
            this.asrClient = new Baidu.Aip.Speech.Asr(API_KEY, SECRET_KEY);
            this.asrClient.Timeout = 60000;
            this.ttsClient = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);
            this.ttsClient.Timeout = 60000;
        }

        // 语音识别
        public string Recognize(string audioPath, string audioFormat, string modleType)
        {
            var data = File.ReadAllBytes(audioPath);
            var enableFormat = new HashSet<string> { "pcm", "wav", "amr", "mp3" };
            //if (!enableFormat.Contains(audioFormat))
            //{
            //    return null;
            //}
            //请求语音识别接口
            var options = new Dictionary<string, object>();
            switch (modleType)
            {
                case "输入法模型":
                    options["dev_pid"] = 1537;
                    break;
                case "英语模型":
                    options["dev_pid"] = 1737;
                    break;
                case "粤语模型":
                    options["dev_pid"] = 1637;
                    break;
                case "四川话模型":
                    options["dev_pid"] = 1837;
                    break;
                case "远场模型":
                    options["dev_pid"] = 1936;
                    break;
            }

            var result = this.asrClient.Recognize(data, audioFormat, 16000, options);
            return result.ToString();
        }

        // 语音合成
        public bool Synthesis(int per, int spd, int pit, int vol, int aue, string text, string audioPath)
        {
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"per", per}, // 音库，度小宇=1，度小美=0，度逍遥（基础）=3，度丫丫=4
                {"spd", spd}, // 语速，取值0-15，默认为5中语速
                {"pit", pit}, // 语调，取值0-15，默认为5中语调
                {"vol", vol}, // 音量，取值0-15，默认为5中音量
                {"aue", aue}, // 格式，3为mp3格式(默认)； 4为pcm-16k；5为pcm-8k；6为wav（内容同pcm-16k）; 
            };

            var pieces = this.splitTextBy2048(text);
            var writer = new System.IO.FileStream(audioPath, System.IO.FileMode.Append);
            // 将上面的语音合并(只支持 mp3)
            for (int i = 0; i < pieces.Count; i++)
            {
                Console.WriteLine("INFO [Synthesis] 正在识别第{0}段文本：{1}", i, pieces[i]);
                var result = this.ttsClient.Synthesis(pieces[i], option);
                if (result.ErrorCode != 0)
                {
                    Console.WriteLine("ERROR [Synthesis] ErrorMsg: {0}", result.ErrorMsg);
                    writer.Close();
                    return false;
                }
                writer.Write(result.Data, 0, result.Data.Length);
            }
            writer.Close();

            return true;
        }

        // 根据标点符号，将文本切分为不超过 2048 的片段
        private List<string> splitTextBy2048(string text)
        {
            var result = new List<string>();
            char[] separator = { 
                '。', '！', '？', // 中文
                '.', '!', '?', // 英文
            };
            var pieces = text.Split(separator);
            var buf = "";
            for (int i = 0; i < pieces.Length; i++)
            {
                var joined = buf + pieces[i];
                if (joined.Length < 2048)
                {
                    buf = joined;
                }
                else
                {
                    result.Add(buf);
                    buf = pieces[i];
                }
            }
            if (buf != "")
            {
                result.Add(buf);
            }
            return result;
        }
    }
}