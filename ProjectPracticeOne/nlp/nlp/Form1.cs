using Baidu.Aip.Nlp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nlp
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> POSTABLE = new Dictionary<string, string> { {"a", "形容词"},
                                               {"ad", "副形词"},
                                               {"ag", "形语素"},
                                               {"an", "名形词"},
                                               {"b", "区别词"},
                                               {"c", "连词"},
                                               {"d", "副词"},
                                               {"dg", "副语素"},
                                               {"e", "叹词"},
                                               {"f", "方位名词"},
                                               {"g", "语素"},
                                               {"h", "前接成分"},
                                               {"i", "成语"},
                                               {"j", "简称略语"},
                                               {"k", "后接成分"},
                                               {"l", "习惯语"},
                                               {"m", "数量词"},
                                               {"n", "普通名词"}, 
                                               {"ng", "名语素"},
                                               {"nr", "人名"},
                                               {"ns", "地名"},
                                               {"nt", "机构团体名"},
                                               {"nw", "作品名"},
                                               {"nz", "其他专名"},
                                               {"o", "拟声词"},
                                               {"p", "介词"},
                                               {"q", "量词"},
                                               {"r", "代词"},
                                               {"s", "处所名词"},
                                               {"t", "时间名词"},
                                               {"tg", "时语素"},
                                               {"u", "助词"},
                                               {"un","未知词"},
                                               {"v", "普通动词"},
                                               {"vd", "动副词"},
                                               {"vg", "动语素"},
                                               {"vn", "动名词"},
                                               {"w", "标点符号"},
                                               {"x", "非语素字"},
                                               {"xc", "其他虚词"},
                                               {"y", "语气词"},
                                               {"z", "状态词"}
        };

        // 专名缩写表
        private readonly Dictionary<string, string> NETABLE =
            new Dictionary<string, string>() {{"PER", "人名"}, 
                                               {"LOC", "地名"},
                                               {"ORG", "机构名"},
                                               {"TIME", "时间"},
                                               {"","/"}};

        // 依存关系缩写
        private readonly Dictionary<string, string> DEPRELTABLE =
            new Dictionary<string, string>() {{"ATT", "定中关系"}, 
                                               {"QUN", "数量关系"},
                                               {"COO", "并列关系"},
                                               {"APP", "同位关系"},
                                               {"ADJ", "附加关系"},
                                               {"VOB", "动宾关系"},
                                               {"POB", "介宾关系"},
                                               {"SBV", "主谓关系"},
                                               {"SIM", "比拟关系"},
                                               {"TMP", "时间关系"},
                                               {"LOC", "处所关系"},
                                               {"DE", "“的”字结构"},
                                               {"DI", "“地”字结构"},
                                               {"DEI", "“得”字结构"},
                                               {"SUO", "“所”字结构"},
                                               {"BA", "“把”字结构"},
                                               {"BEI", "“被”字结构"},
                                               {"ADV", "状中结构"},
                                               {"CMP", "动补结构"},
                                               {"DBL", "兼语结构"},
                                               {"CNJ", "关联词"},
                                               {"CS", "关联结构"},
                                               {"MT", "语态结构"},
                                               {"VV", "连谓结构"},
                                               {"HED", "核心"},
                                               {"FOB", "前置宾语"},
                                               {"DOB", "双宾语"},
                                               {"TOP", "主题"},
                                               {"IS", "独立结构"},
                                               {"IC", "独立分句"},
                                               {"DC", "依存分句"},
                                               {"VNV", "叠词关系"},
                                               {"YGC", "一个词"},
                                               {"WP", "标点"},
                                               {"",""}};

        private static string APIKEY = "Lo2Ah5Dyeij2HdC7zKK208EA";
        private static string APISECRET = "pS5MwT63vfzHHC9ria3AeoIaIzKbHsg0";
        private static Nlp client = new Nlp(APIKEY, APISECRET);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLexiAnaly_Click(object sender, EventArgs e)
        {
            //调用百度API
            try
            {
                JObject result = client.Lexer(textBoxLexiAnaly.Text);

                int index = 1;
                foreach (var item in result["items"])
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var word in item["basic_words"])
                    {
                        sb.Append(string.Format("{0}/", word.ToString()));
                    }
                    if (sb.Length != 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }

                    //写入listview
                    listViewLexiAnaly.Items.Add(new ListViewItem(new string[]{
                        index++.ToString(),
                        item["item"].ToString(),
                        item["pos"].ToString() != string.Empty ?
                            POSTABLE[item["pos"].ToString()]:NETABLE[item["ne"].ToString()],
                        sb.ToString()
                    }));
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

        }

        private void buttonSyntacParse_Click(object sender, EventArgs e)
        {
            //依存句法分析
            var dictMode = new Dictionary<string, int>{
	            {"web模型", 0},
                {"query模型", 1}
            };
            var options = new Dictionary<string, object>{
                    {"mode", dictMode[comboBoxSyntacParse.Text.ToString()]}};
            JObject result = client.DepParser(textBoxLexiAnaly.Text, options);

            Console.WriteLine(result);
	        //JToken[] itemArr = result.GetValue("items").ToArray();

            int resutl_len = result["items"].Count();
            foreach(var item in result["items"])
            {
                TreeNode node = new TreeNode();
                node.Text = item["word"] + "(" + DEPRELTABLE[item["deprel"].ToString()] + ")";


            }



        }

        private void buttonDNN_Click(object sender, EventArgs e)
        {
            int index = 1;
            var text = textBoxLexiAnaly.Text;
            // try...catch
            var result = client.DnnlmCn(text);
            Console.WriteLine(result);
            foreach (var item in result["items"]){
                listViewDNN.Items.Add(new ListViewItem(new string[]{
                    index++.ToString(),
                    item["word"].ToString(),
                    item["prob"].ToString()                
                }));
            }
            textBoxPpl.Text = result["ppl"].ToString();
        }

        private void buttonShortTextSim_Click(object sender, EventArgs e)
        {
            var options = new Dictionary<string, object> { { "model", comboBoxShortModel.Text } };
            // try...catch
            var result = client.Simnet(richTextBoxS1.Text, richTextBoxS2.Text, options);
            Console.WriteLine(result);
            textBoxShort.Text = result["score"].ToString();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            var options = new Dictionary<string, object> { { "type", comboBoxComment.Text } };
            // try...catch
            var result = client.CommentTag(richTextBoxComment.Text, options);
            Console.WriteLine(result);
            //按行展示
            richTextBoxCommentResult.Text = result["items"].ToString();
        }

        private void buttonSentiment_Click(object sender, EventArgs e)
        {
            // try...catch
            var result = client.SentimentClassify(richTextBoxComment.Text);
            Console.WriteLine(result);
            //按行展示
            richTextBoxCommentResult.Text = result["items"].ToString();
        }

        private void buttonWordEmbed_Click(object sender, EventArgs e)
        {
            // try...catch
            var result = client.WordEmbedding(textBoxWordEmbed.Text);
            Console.WriteLine(result);
            //按行展示
            richTextBoxWordEmbed.Text = result["vec"].ToString();
        }

        private void buttonWordSimEnbed_Click(object sender, EventArgs e)
        {
            // try...catch
            var result = client.WordSimEmbedding(textBoxWordSimEnbed1.Text, textBoxWordSimEnbed2.Text);
            Console.WriteLine(result);
            //按行展示
            textBoxWordSimEnbedResult.Text = result["score"].ToString(); 
        }

        private void buttonKeyword_Click(object sender, EventArgs e)
        {
            // try...catch
            var result = client.Keyword(textBoxKeyword.Text, richTextBoxKeyword.Text);
            Console.WriteLine(result);
            //按行展示
            richTextBoxKeyWordResult.Text = result["items"].ToString(); 
        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {
            // try...catch
            var result = client.Topic(textBoxKeyword.Text, richTextBoxKeyword.Text);
            Console.WriteLine(result);
            //按行展示
            richTextBoxKeyWordResult.Text = result["item"].ToString(); 
        }
    }
}
