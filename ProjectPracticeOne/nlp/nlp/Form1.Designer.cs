namespace nlp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLexiAnaly = new System.Windows.Forms.GroupBox();
            this.listViewDNN = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDNN = new System.Windows.Forms.Button();
            this.textBoxPpl = new System.Windows.Forms.TextBox();
            this.labelDNN = new System.Windows.Forms.Label();
            this.buttonSyntacParse = new System.Windows.Forms.Button();
            this.comboBoxSyntacParse = new System.Windows.Forms.ComboBox();
            this.labelSyntacParse = new System.Windows.Forms.Label();
            this.listViewLexiAnaly = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLexiAnaly = new System.Windows.Forms.Button();
            this.textBoxLexiAnaly = new System.Windows.Forms.TextBox();
            this.groupBoxShortTxt = new System.Windows.Forms.GroupBox();
            this.buttonShortTextSim = new System.Windows.Forms.Button();
            this.textBoxShort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxShortModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxS2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxS1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCommentResult = new System.Windows.Forms.RichTextBox();
            this.buttonSentiment = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.comboBoxComment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxWordEmbed = new System.Windows.Forms.RichTextBox();
            this.buttonWordEmbed = new System.Windows.Forms.Button();
            this.textBoxWordEmbed = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonWordSimEnbed = new System.Windows.Forms.Button();
            this.textBoxWordSimEnbedResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWordSimEnbed2 = new System.Windows.Forms.TextBox();
            this.textBoxWordSimEnbed1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxKeyWordResult = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTopic = new System.Windows.Forms.Button();
            this.buttonKeyword = new System.Windows.Forms.Button();
            this.richTextBoxKeyword = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeViewSyntacParse = new System.Windows.Forms.TreeView();
            this.groupBoxLexiAnaly.SuspendLayout();
            this.groupBoxShortTxt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLexiAnaly
            // 
            this.groupBoxLexiAnaly.Controls.Add(this.treeViewSyntacParse);
            this.groupBoxLexiAnaly.Controls.Add(this.listViewDNN);
            this.groupBoxLexiAnaly.Controls.Add(this.buttonDNN);
            this.groupBoxLexiAnaly.Controls.Add(this.textBoxPpl);
            this.groupBoxLexiAnaly.Controls.Add(this.labelDNN);
            this.groupBoxLexiAnaly.Controls.Add(this.buttonSyntacParse);
            this.groupBoxLexiAnaly.Controls.Add(this.comboBoxSyntacParse);
            this.groupBoxLexiAnaly.Controls.Add(this.labelSyntacParse);
            this.groupBoxLexiAnaly.Controls.Add(this.listViewLexiAnaly);
            this.groupBoxLexiAnaly.Controls.Add(this.buttonLexiAnaly);
            this.groupBoxLexiAnaly.Controls.Add(this.textBoxLexiAnaly);
            this.groupBoxLexiAnaly.Location = new System.Drawing.Point(12, 26);
            this.groupBoxLexiAnaly.Name = "groupBoxLexiAnaly";
            this.groupBoxLexiAnaly.Size = new System.Drawing.Size(301, 491);
            this.groupBoxLexiAnaly.TabIndex = 0;
            this.groupBoxLexiAnaly.TabStop = false;
            this.groupBoxLexiAnaly.Text = "词法分析/依存句法分析/DNN语言模型";
            // 
            // listViewDNN
            // 
            this.listViewDNN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewDNN.Location = new System.Drawing.Point(11, 366);
            this.listViewDNN.Name = "listViewDNN";
            this.listViewDNN.Size = new System.Drawing.Size(275, 113);
            this.listViewDNN.TabIndex = 11;
            this.listViewDNN.UseCompatibleStateImageBehavior = false;
            this.listViewDNN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "分词";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "概率值";
            // 
            // buttonDNN
            // 
            this.buttonDNN.Location = new System.Drawing.Point(184, 337);
            this.buttonDNN.Name = "buttonDNN";
            this.buttonDNN.Size = new System.Drawing.Size(102, 23);
            this.buttonDNN.TabIndex = 9;
            this.buttonDNN.Text = "DNN语言模型";
            this.buttonDNN.UseVisualStyleBackColor = true;
            this.buttonDNN.Click += new System.EventHandler(this.buttonDNN_Click);
            // 
            // textBoxPpl
            // 
            this.textBoxPpl.Location = new System.Drawing.Point(80, 335);
            this.textBoxPpl.Name = "textBoxPpl";
            this.textBoxPpl.ReadOnly = true;
            this.textBoxPpl.Size = new System.Drawing.Size(63, 21);
            this.textBoxPpl.TabIndex = 8;
            // 
            // labelDNN
            // 
            this.labelDNN.AutoSize = true;
            this.labelDNN.Location = new System.Drawing.Point(9, 341);
            this.labelDNN.Name = "labelDNN";
            this.labelDNN.Size = new System.Drawing.Size(65, 12);
            this.labelDNN.TabIndex = 7;
            this.labelDNN.Text = "句子通顺值";
            // 
            // buttonSyntacParse
            // 
            this.buttonSyntacParse.Location = new System.Drawing.Point(180, 208);
            this.buttonSyntacParse.Name = "buttonSyntacParse";
            this.buttonSyntacParse.Size = new System.Drawing.Size(106, 23);
            this.buttonSyntacParse.TabIndex = 5;
            this.buttonSyntacParse.Text = "依存句法分析";
            this.buttonSyntacParse.UseVisualStyleBackColor = true;
            this.buttonSyntacParse.Click += new System.EventHandler(this.buttonSyntacParse_Click);
            // 
            // comboBoxSyntacParse
            // 
            this.comboBoxSyntacParse.FormattingEnabled = true;
            this.comboBoxSyntacParse.Items.AddRange(new object[] {
            "web模型",
            "query模型"});
            this.comboBoxSyntacParse.Location = new System.Drawing.Point(67, 212);
            this.comboBoxSyntacParse.Name = "comboBoxSyntacParse";
            this.comboBoxSyntacParse.Size = new System.Drawing.Size(103, 20);
            this.comboBoxSyntacParse.TabIndex = 4;
            this.comboBoxSyntacParse.Text = "web模型";
            // 
            // labelSyntacParse
            // 
            this.labelSyntacParse.AutoSize = true;
            this.labelSyntacParse.Location = new System.Drawing.Point(7, 216);
            this.labelSyntacParse.Name = "labelSyntacParse";
            this.labelSyntacParse.Size = new System.Drawing.Size(53, 12);
            this.labelSyntacParse.TabIndex = 3;
            this.labelSyntacParse.Text = "分析模型";
            // 
            // listViewLexiAnaly
            // 
            this.listViewLexiAnaly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewLexiAnaly.Location = new System.Drawing.Point(7, 99);
            this.listViewLexiAnaly.Name = "listViewLexiAnaly";
            this.listViewLexiAnaly.Size = new System.Drawing.Size(279, 95);
            this.listViewLexiAnaly.TabIndex = 2;
            this.listViewLexiAnaly.UseCompatibleStateImageBehavior = false;
            this.listViewLexiAnaly.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "分词";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "词性";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "基本词";
            // 
            // buttonLexiAnaly
            // 
            this.buttonLexiAnaly.Location = new System.Drawing.Point(211, 63);
            this.buttonLexiAnaly.Name = "buttonLexiAnaly";
            this.buttonLexiAnaly.Size = new System.Drawing.Size(75, 23);
            this.buttonLexiAnaly.TabIndex = 1;
            this.buttonLexiAnaly.Text = "词法分析";
            this.buttonLexiAnaly.UseVisualStyleBackColor = true;
            this.buttonLexiAnaly.Click += new System.EventHandler(this.buttonLexiAnaly_Click);
            // 
            // textBoxLexiAnaly
            // 
            this.textBoxLexiAnaly.Location = new System.Drawing.Point(7, 36);
            this.textBoxLexiAnaly.Name = "textBoxLexiAnaly";
            this.textBoxLexiAnaly.Size = new System.Drawing.Size(279, 21);
            this.textBoxLexiAnaly.TabIndex = 0;
            this.textBoxLexiAnaly.Text = "我们在北航学习人工智能";
            // 
            // groupBoxShortTxt
            // 
            this.groupBoxShortTxt.Controls.Add(this.buttonShortTextSim);
            this.groupBoxShortTxt.Controls.Add(this.textBoxShort);
            this.groupBoxShortTxt.Controls.Add(this.label2);
            this.groupBoxShortTxt.Controls.Add(this.comboBoxShortModel);
            this.groupBoxShortTxt.Controls.Add(this.label1);
            this.groupBoxShortTxt.Controls.Add(this.richTextBoxS2);
            this.groupBoxShortTxt.Controls.Add(this.richTextBoxS1);
            this.groupBoxShortTxt.Location = new System.Drawing.Point(333, 37);
            this.groupBoxShortTxt.Name = "groupBoxShortTxt";
            this.groupBoxShortTxt.Size = new System.Drawing.Size(369, 140);
            this.groupBoxShortTxt.TabIndex = 1;
            this.groupBoxShortTxt.TabStop = false;
            this.groupBoxShortTxt.Text = "短文本相似度";
            // 
            // buttonShortTextSim
            // 
            this.buttonShortTextSim.Location = new System.Drawing.Point(251, 108);
            this.buttonShortTextSim.Name = "buttonShortTextSim";
            this.buttonShortTextSim.Size = new System.Drawing.Size(103, 23);
            this.buttonShortTextSim.TabIndex = 14;
            this.buttonShortTextSim.Text = "短文本相似度";
            this.buttonShortTextSim.UseVisualStyleBackColor = true;
            this.buttonShortTextSim.Click += new System.EventHandler(this.buttonShortTextSim_Click);
            // 
            // textBoxShort
            // 
            this.textBoxShort.Location = new System.Drawing.Point(175, 110);
            this.textBoxShort.Name = "textBoxShort";
            this.textBoxShort.Size = new System.Drawing.Size(67, 21);
            this.textBoxShort.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "结果";
            // 
            // comboBoxShortModel
            // 
            this.comboBoxShortModel.FormattingEnabled = true;
            this.comboBoxShortModel.Items.AddRange(new object[] {
            "BOW",
            "CNN",
            "GRNN"});
            this.comboBoxShortModel.Location = new System.Drawing.Point(69, 111);
            this.comboBoxShortModel.Name = "comboBoxShortModel";
            this.comboBoxShortModel.Size = new System.Drawing.Size(63, 20);
            this.comboBoxShortModel.TabIndex = 11;
            this.comboBoxShortModel.Text = "BOW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "计算模型";
            // 
            // richTextBoxS2
            // 
            this.richTextBoxS2.Location = new System.Drawing.Point(187, 20);
            this.richTextBoxS2.Name = "richTextBoxS2";
            this.richTextBoxS2.Size = new System.Drawing.Size(167, 77);
            this.richTextBoxS2.TabIndex = 1;
            this.richTextBoxS2.Text = "短文本相似度接口用来判断两个文本的真正的相似度得分。";
            // 
            // richTextBoxS1
            // 
            this.richTextBoxS1.Location = new System.Drawing.Point(7, 21);
            this.richTextBoxS1.Name = "richTextBoxS1";
            this.richTextBoxS1.Size = new System.Drawing.Size(157, 76);
            this.richTextBoxS1.TabIndex = 0;
            this.richTextBoxS1.Text = "短文本相似度接口用来判断两个文本的相似度得分。";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxCommentResult);
            this.groupBox2.Controls.Add(this.buttonSentiment);
            this.groupBox2.Controls.Add(this.buttonComment);
            this.groupBox2.Controls.Add(this.comboBoxComment);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTextBoxComment);
            this.groupBox2.Location = new System.Drawing.Point(333, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "评论观点提取/情感倾向分析";
            // 
            // richTextBoxCommentResult
            // 
            this.richTextBoxCommentResult.Location = new System.Drawing.Point(12, 108);
            this.richTextBoxCommentResult.Name = "richTextBoxCommentResult";
            this.richTextBoxCommentResult.Size = new System.Drawing.Size(342, 52);
            this.richTextBoxCommentResult.TabIndex = 18;
            this.richTextBoxCommentResult.Text = "";
            // 
            // buttonSentiment
            // 
            this.buttonSentiment.Location = new System.Drawing.Point(264, 78);
            this.buttonSentiment.Name = "buttonSentiment";
            this.buttonSentiment.Size = new System.Drawing.Size(90, 23);
            this.buttonSentiment.TabIndex = 17;
            this.buttonSentiment.Text = "情感倾向分析";
            this.buttonSentiment.UseVisualStyleBackColor = true;
            this.buttonSentiment.Click += new System.EventHandler(this.buttonSentiment_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(161, 78);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(97, 23);
            this.buttonComment.TabIndex = 16;
            this.buttonComment.Text = "评论观点抽取";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // comboBoxComment
            // 
            this.comboBoxComment.FormattingEnabled = true;
            this.comboBoxComment.Items.AddRange(new object[] {
            "酒店",
            "KTV3 - 丽人",
            "美食餐饮",
            "旅游",
            "健康",
            "教育",
            "商业",
            "房产",
            "汽车",
            "生活",
            "购物",
            "3C"});
            this.comboBoxComment.Location = new System.Drawing.Point(55, 78);
            this.comboBoxComment.Name = "comboBoxComment";
            this.comboBoxComment.Size = new System.Drawing.Size(77, 20);
            this.comboBoxComment.TabIndex = 15;
            this.comboBoxComment.Text = "汽车";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "行业";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(12, 21);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(342, 50);
            this.richTextBoxComment.TabIndex = 0;
            this.richTextBoxComment.Text = " 我个人觉得这车不错，外观年轻漂亮，动力和操作性都很好";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxWordEmbed);
            this.groupBox3.Controls.Add(this.buttonWordEmbed);
            this.groupBox3.Controls.Add(this.textBoxWordEmbed);
            this.groupBox3.Location = new System.Drawing.Point(333, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "词向量";
            // 
            // richTextBoxWordEmbed
            // 
            this.richTextBoxWordEmbed.Location = new System.Drawing.Point(7, 49);
            this.richTextBoxWordEmbed.Name = "richTextBoxWordEmbed";
            this.richTextBoxWordEmbed.ReadOnly = true;
            this.richTextBoxWordEmbed.Size = new System.Drawing.Size(149, 101);
            this.richTextBoxWordEmbed.TabIndex = 2;
            this.richTextBoxWordEmbed.Text = "";
            // 
            // buttonWordEmbed
            // 
            this.buttonWordEmbed.Location = new System.Drawing.Point(91, 18);
            this.buttonWordEmbed.Name = "buttonWordEmbed";
            this.buttonWordEmbed.Size = new System.Drawing.Size(65, 23);
            this.buttonWordEmbed.TabIndex = 1;
            this.buttonWordEmbed.Text = "词向量";
            this.buttonWordEmbed.UseVisualStyleBackColor = true;
            this.buttonWordEmbed.Click += new System.EventHandler(this.buttonWordEmbed_Click);
            // 
            // textBoxWordEmbed
            // 
            this.textBoxWordEmbed.Location = new System.Drawing.Point(7, 21);
            this.textBoxWordEmbed.Name = "textBoxWordEmbed";
            this.textBoxWordEmbed.Size = new System.Drawing.Size(68, 21);
            this.textBoxWordEmbed.TabIndex = 0;
            this.textBoxWordEmbed.Text = "智能";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonWordSimEnbed);
            this.groupBox4.Controls.Add(this.textBoxWordSimEnbedResult);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxWordSimEnbed2);
            this.groupBox4.Controls.Add(this.textBoxWordSimEnbed1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(520, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "词义相似度";
            // 
            // buttonWordSimEnbed
            // 
            this.buttonWordSimEnbed.Location = new System.Drawing.Point(88, 114);
            this.buttonWordSimEnbed.Name = "buttonWordSimEnbed";
            this.buttonWordSimEnbed.Size = new System.Drawing.Size(75, 23);
            this.buttonWordSimEnbed.TabIndex = 6;
            this.buttonWordSimEnbed.Text = "词义相似度";
            this.buttonWordSimEnbed.UseVisualStyleBackColor = true;
            this.buttonWordSimEnbed.Click += new System.EventHandler(this.buttonWordSimEnbed_Click);
            // 
            // textBoxWordSimEnbedResult
            // 
            this.textBoxWordSimEnbedResult.Location = new System.Drawing.Point(47, 74);
            this.textBoxWordSimEnbedResult.Name = "textBoxWordSimEnbedResult";
            this.textBoxWordSimEnbedResult.ReadOnly = true;
            this.textBoxWordSimEnbedResult.Size = new System.Drawing.Size(117, 21);
            this.textBoxWordSimEnbedResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "结果";
            // 
            // textBoxWordSimEnbed2
            // 
            this.textBoxWordSimEnbed2.Location = new System.Drawing.Point(41, 46);
            this.textBoxWordSimEnbed2.Name = "textBoxWordSimEnbed2";
            this.textBoxWordSimEnbed2.Size = new System.Drawing.Size(123, 21);
            this.textBoxWordSimEnbed2.TabIndex = 3;
            this.textBoxWordSimEnbed2.Text = "打搅";
            // 
            // textBoxWordSimEnbed1
            // 
            this.textBoxWordSimEnbed1.Location = new System.Drawing.Point(41, 20);
            this.textBoxWordSimEnbed1.Name = "textBoxWordSimEnbed1";
            this.textBoxWordSimEnbed1.Size = new System.Drawing.Size(122, 21);
            this.textBoxWordSimEnbed1.TabIndex = 2;
            this.textBoxWordSimEnbed1.Text = "打扰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "词2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "词1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxKeyWordResult);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.buttonTopic);
            this.groupBox5.Controls.Add(this.buttonKeyword);
            this.groupBox5.Controls.Add(this.richTextBoxKeyword);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBoxKeyword);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(734, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 491);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "文章标签/文章分类";
            // 
            // richTextBoxKeyWordResult
            // 
            this.richTextBoxKeyWordResult.Location = new System.Drawing.Point(12, 326);
            this.richTextBoxKeyWordResult.Name = "richTextBoxKeyWordResult";
            this.richTextBoxKeyWordResult.Size = new System.Drawing.Size(275, 148);
            this.richTextBoxKeyWordResult.TabIndex = 7;
            this.richTextBoxKeyWordResult.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "计算结果";
            // 
            // buttonTopic
            // 
            this.buttonTopic.Location = new System.Drawing.Point(159, 274);
            this.buttonTopic.Name = "buttonTopic";
            this.buttonTopic.Size = new System.Drawing.Size(118, 23);
            this.buttonTopic.TabIndex = 5;
            this.buttonTopic.Text = "文章分类";
            this.buttonTopic.UseVisualStyleBackColor = true;
            this.buttonTopic.Click += new System.EventHandler(this.buttonTopic_Click);
            // 
            // buttonKeyword
            // 
            this.buttonKeyword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKeyword.Location = new System.Drawing.Point(12, 274);
            this.buttonKeyword.Name = "buttonKeyword";
            this.buttonKeyword.Size = new System.Drawing.Size(123, 23);
            this.buttonKeyword.TabIndex = 4;
            this.buttonKeyword.Text = "文章标签";
            this.buttonKeyword.UseVisualStyleBackColor = true;
            this.buttonKeyword.Click += new System.EventHandler(this.buttonKeyword_Click);
            // 
            // richTextBoxKeyword
            // 
            this.richTextBoxKeyword.Location = new System.Drawing.Point(11, 98);
            this.richTextBoxKeyword.Name = "richTextBoxKeyword";
            this.richTextBoxKeyword.Size = new System.Drawing.Size(276, 160);
            this.richTextBoxKeyword.TabIndex = 3;
            this.richTextBoxKeyword.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "文章内容";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(9, 45);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(278, 21);
            this.textBoxKeyword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "文章标题";
            // 
            // treeViewSyntacParse
            // 
            this.treeViewSyntacParse.Location = new System.Drawing.Point(9, 240);
            this.treeViewSyntacParse.Name = "treeViewSyntacParse";
            this.treeViewSyntacParse.Size = new System.Drawing.Size(277, 82);
            this.treeViewSyntacParse.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 538);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxShortTxt);
            this.Controls.Add(this.groupBoxLexiAnaly);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自然语言处理演示程序";
            this.groupBoxLexiAnaly.ResumeLayout(false);
            this.groupBoxLexiAnaly.PerformLayout();
            this.groupBoxShortTxt.ResumeLayout(false);
            this.groupBoxShortTxt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLexiAnaly;
        private System.Windows.Forms.ListView listViewLexiAnaly;
        private System.Windows.Forms.Button buttonLexiAnaly;
        private System.Windows.Forms.TextBox textBoxLexiAnaly;
        private System.Windows.Forms.Button buttonSyntacParse;
        private System.Windows.Forms.ComboBox comboBoxSyntacParse;
        private System.Windows.Forms.Label labelSyntacParse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelDNN;
        private System.Windows.Forms.Button buttonDNN;
        private System.Windows.Forms.TextBox textBoxPpl;
        private System.Windows.Forms.GroupBox groupBoxShortTxt;
        private System.Windows.Forms.Button buttonShortTextSim;
        private System.Windows.Forms.TextBox textBoxShort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxShortModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxS2;
        private System.Windows.Forms.RichTextBox richTextBoxS1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxCommentResult;
        private System.Windows.Forms.Button buttonSentiment;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.ComboBox comboBoxComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxWordEmbed;
        private System.Windows.Forms.Button buttonWordEmbed;
        private System.Windows.Forms.TextBox textBoxWordEmbed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonWordSimEnbed;
        private System.Windows.Forms.TextBox textBoxWordSimEnbedResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWordSimEnbed2;
        private System.Windows.Forms.TextBox textBoxWordSimEnbed1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBoxKeyWordResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTopic;
        private System.Windows.Forms.Button buttonKeyword;
        private System.Windows.Forms.RichTextBox richTextBoxKeyword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewDNN;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView treeViewSyntacParse;
    }
}

