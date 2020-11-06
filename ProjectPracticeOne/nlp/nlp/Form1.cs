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

        // 评论观点类型表
        private readonly Dictionary<string, int> COMMENTTYPETABLE =
            new Dictionary<string, int>() {{"酒店", 1},
                                            {"KTV", 2},
                                            {"丽人", 3},
                                            {"美食餐饮", 4},
                                            {"旅游", 5},
                                            {"健康", 6},
                                            {"教育", 7},
                                            {"商业", 8},
                                            {"房产", 9},
                                            {"汽车", 10},
                                            {"生活", 11},
                                            {"购物", 12},
                                            {"3C", 13}};

        private static string APIKEY = "Lo2Ah5Dyeij2HdC7zKK208EA";
        private static string APISECRET = "pS5MwT63vfzHHC9ria3AeoIaIzKbHsg0";
        private static Nlp client = new Nlp(APIKEY, APISECRET);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLexiAnaly_Click(object sender, EventArgs e)
        {
            //词法分析
            if (textBoxLexiAnaly.TextLength == 0)
            {
                MessageBox.Show("textBoxLexiAnaly" + "shouldn't be empty!");
            }
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

        private void buildTree(JToken root, JToken items)
        {
            var children = items.Where(p => p["head"].ToString() == root["id"].ToString()).ToList();
            foreach (var item in children)
            {
                this.insertTreeNode(item);
                this.buildTree(item, items);
            }
        }

        private void insertTreeNode(JToken item)
        {
            var text = item["word"] + "(" + DEPRELTABLE[item["deprel"].ToString()] + ")";
            var parents = this.treeViewSyntacParse.Nodes.Find(item["head"].ToString(), true);
            if (parents.Count() == 0)
                this.treeViewSyntacParse.Nodes.Add(item["id"].ToString(), text);
            else
                parents[0].Nodes.Add(item["id"].ToString(), text);
        }

        private void buttonSyntacParse_Click(object sender, EventArgs e)
        {
            //依存句法分析
            if (textBoxLexiAnaly.TextLength == 0)
            {
                MessageBox.Show("textBoxLexiAnaly" + "shouldn't be empty!");
            }
            var dictMode = new Dictionary<string, int>{
	            {"web模型", 0},
                {"query模型", 1}
            };
            var options = new Dictionary<string, object>{
                    {"mode", dictMode[comboBoxSyntacParse.Text.ToString()]}};
            try
            {
                var result = client.DepParser(textBoxLexiAnaly.Text, options);
                var items = result["items"];
                var root = items.First(p => (int)p["head"] == 0);
                this.insertTreeNode(root);
                this.buildTree(root, items);
                treeViewSyntacParse.ExpandAll();
            }
            catch (Exception exp){
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonDNN_Click(object sender, EventArgs e)
        {
            //DNN语言模型
            if (textBoxLexiAnaly.TextLength == 0)
            {
                MessageBox.Show("textBoxLexiAnaly" + "shouldn't be empty!");
            }
            int index = 1;
            var text = textBoxLexiAnaly.Text;
            try
            {
                var result = client.DnnlmCn(text);
                Console.WriteLine(result);
                foreach (var item in result["items"])
                {
                    listViewDNN.Items.Add(new ListViewItem(new string[]{
                    index++.ToString(),
                    item["word"].ToString(),
                    item["prob"].ToString()                
                }));
                }
                textBoxPpl.Text = result["ppl"].ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonShortTextSim_Click(object sender, EventArgs e)
        {
            //短文本相似度
            if (richTextBoxS1.TextLength == 0 || richTextBoxS2.TextLength == 0)
            {
                MessageBox.Show("richTextBoxS1 and richTextBoxS2 shouldn't be empty!");
            }
            var options = new Dictionary<string, object> { { "model", comboBoxShortModel.Text}};
            try
            {
                var result = client.Simnet(richTextBoxS1.Text, richTextBoxS2.Text, options);
                Console.WriteLine(result);
                textBoxShort.Text = result["score"].ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            //评论观点抽取
            if (richTextBoxComment.TextLength == 0)
            {
                MessageBox.Show("richTextBoxComment shouldn't be empty!");
            }
            var options = new Dictionary<string, object> { 
                            { "type", COMMENTTYPETABLE[comboBoxComment.Text] } };
            try
            {
                var result = client.CommentTag(richTextBoxComment.Text, options);
                //按行展示
                Dictionary<int, string> dict_sentiment = new Dictionary<int, string>{
                    {0, "消极"},
                    {1, "中性"},
                    {2, "积极"}
                 };
                richTextBoxCommentResult.Clear();
                foreach (var item in result["items"]) {
                    richTextBoxCommentResult.AppendText("观点倾向：" +
                        dict_sentiment[(int)item["sentiment"]] + "\n");
                    richTextBoxCommentResult.AppendText("短句摘要：" + item["abstract"] + "\n");
                    richTextBoxCommentResult.AppendText("匹配属性词：" + item["prop"] + "\n");
                    richTextBoxCommentResult.AppendText("匹配描述词：" + item["adj"] + "\n");
                    richTextBoxCommentResult.AppendText("开始位置：" + item["begin_pos"] + "\n");
                    richTextBoxCommentResult.AppendText("结束位置：" + item["end_pos"] + "\n");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonSentiment_Click(object sender, EventArgs e)
        {
            //情感倾向分析
            if (richTextBoxComment.TextLength == 0)
            {
                MessageBox.Show("richTextBoxComment shouldn't be empty!");
            }
            try
            {
                var result = client.SentimentClassify(richTextBoxComment.Text);
                Dictionary<int, string> dict_sentiment = new Dictionary<int, string>{
                    {0, "消极"},
                    {1, "中性"},
                    {2, "积极"}
                 };
                richTextBoxCommentResult.Clear();
                foreach (var item in result["items"])
                {
                    richTextBoxCommentResult.AppendText("观点倾向：" +
                        dict_sentiment[(int)item["sentiment"]] + "\n");
                    richTextBoxCommentResult.AppendText("分类的置信度：" + item["confidence"] + "\n");
                    richTextBoxCommentResult.AppendText("积极类别的概率：" + item["positive_prob"] + "\n");
                    richTextBoxCommentResult.AppendText("消极类别的概率：" + item["negative_prob"] + "\n");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonWordEmbed_Click(object sender, EventArgs e)
        {
            //词向量分析
            if (textBoxWordEmbed.TextLength == 0)
            {
                MessageBox.Show("textBoxWordEmbed shouldn't be empty!");
            }
            try
            {
                var result = client.WordEmbedding(textBoxWordEmbed.Text);
                richTextBoxWordEmbed.Clear();
                foreach(var item in result["vec"]){
                    richTextBoxWordEmbed.AppendText(item.ToString() + "\n");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonWordSimEnbed_Click(object sender, EventArgs e)
        {
            //词义相似度
            if (textBoxWordSimEnbed1.TextLength == 0 || textBoxWordSimEnbed2.TextLength == 0)
            {
                MessageBox.Show("textBoxWordSimEnbed1 and textBoxWordSimEnbed2 shouldn't be empty!");
            }
            try
            {
                var result = client.WordSimEmbedding(textBoxWordSimEnbed1.Text, textBoxWordSimEnbed2.Text);
                Console.WriteLine(result);
                //按行展示
                textBoxWordSimEnbedResult.Text = result["score"].ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            } 
        }

        private void buttonKeyword_Click(object sender, EventArgs e)
        {
            //文章标签
            if (textBoxKeyword.TextLength == 0 || richTextBoxKeyword.TextLength == 0)
            {
                MessageBox.Show("textBoxKeyword and richTextBoxKeyword shouldn't be empty!");
            }
            try
            {
                var result = client.Keyword(textBoxKeyword.Text, richTextBoxKeyword.Text);
                richTextBoxKeyWordResult.Clear();
                foreach (var item in result["items"]) {
                    richTextBoxKeyWordResult.AppendText("\t" + item["tag"] + "：" + item["score"] + "\n");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {
            //文章分类
            if (textBoxKeyword.TextLength == 0 || richTextBoxKeyword.TextLength == 0)
            {
                MessageBox.Show("textBoxKeyword and richTextBoxKeyword shouldn't be empty!");
            }
            try
            {
                var result = client.Topic(textBoxKeyword.Text, richTextBoxKeyword.Text);
                richTextBoxKeyWordResult.Clear();
                richTextBoxKeyWordResult.AppendText("一级分类结果：\n");
                foreach (var item in result["item"]["lv1_tag_list"])
                {
                    richTextBoxKeyWordResult.AppendText("\t" + item["tag"] + "：" + item["score"] + "\n");
                }
                richTextBoxKeyWordResult.AppendText("二级分类结果：\n");
                foreach (var item in result["item"]["lv2_tag_list"])
                {
                    richTextBoxKeyWordResult.AppendText("\t" + item["tag"] + "：" + item["score"] + "\n");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
        }

    }
}
