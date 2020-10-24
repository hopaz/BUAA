namespace SpeechProcessing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboModelType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecogResult = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.comboAudioFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboAue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboPer = new System.Windows.Forms.ComboBox();
            this.btnSynthesis = new System.Windows.Forms.Button();
            this.numVol = new System.Windows.Forms.NumericUpDown();
            this.numPit = new System.Windows.Forms.NumericUpDown();
            this.numSpd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSynthesisInput = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboModelType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecogResult);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtAudioPath);
            this.groupBox1.Controls.Add(this.comboAudioFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRecognize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音识别";
            // 
            // comboModelType
            // 
            this.comboModelType.FormattingEnabled = true;
            this.comboModelType.Items.AddRange(new object[] {
            "输入法模型",
            "英语模型",
            "粤语模型",
            "四川话模型",
            "远场模型"});
            this.comboModelType.Location = new System.Drawing.Point(66, 97);
            this.comboModelType.Name = "comboModelType";
            this.comboModelType.Size = new System.Drawing.Size(121, 20);
            this.comboModelType.TabIndex = 8;
            this.comboModelType.Text = "输入法模型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "语音模型";
            // 
            // txtRecogResult
            // 
            this.txtRecogResult.Location = new System.Drawing.Point(11, 199);
            this.txtRecogResult.Name = "txtRecogResult";
            this.txtRecogResult.Size = new System.Drawing.Size(314, 120);
            this.txtRecogResult.TabIndex = 6;
            this.txtRecogResult.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "选择文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_FileDialog_Click);
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtAudioPath.Location = new System.Drawing.Point(11, 21);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.Size = new System.Drawing.Size(233, 21);
            this.txtAudioPath.TabIndex = 4;
            // 
            // comboAudioFormat
            // 
            this.comboAudioFormat.FormattingEnabled = true;
            this.comboAudioFormat.Items.AddRange(new object[] {
            "pcm",
            "wav",
            "amr",
            "m4a"});
            this.comboAudioFormat.Location = new System.Drawing.Point(66, 65);
            this.comboAudioFormat.Name = "comboAudioFormat";
            this.comboAudioFormat.Size = new System.Drawing.Size(121, 20);
            this.comboAudioFormat.TabIndex = 3;
            this.comboAudioFormat.Text = "pcm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "识别结果";
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(250, 349);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(75, 23);
            this.btnRecognize.TabIndex = 1;
            this.btnRecognize.Text = "开始识别";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btn_Recognize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "音频格式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboAue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboPer);
            this.groupBox2.Controls.Add(this.btnSynthesis);
            this.groupBox2.Controls.Add(this.numVol);
            this.groupBox2.Controls.Add(this.numPit);
            this.groupBox2.Controls.Add(this.numSpd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtSynthesisInput);
            this.groupBox2.Location = new System.Drawing.Point(387, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 386);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "语音合成";
            // 
            // comboAue
            // 
            this.comboAue.FormattingEnabled = true;
            this.comboAue.Items.AddRange(new object[] {
            "mp3",
            "pcm-16k",
            "pcm-8k",
            "wav"});
            this.comboAue.Location = new System.Drawing.Point(69, 164);
            this.comboAue.Name = "comboAue";
            this.comboAue.Size = new System.Drawing.Size(121, 20);
            this.comboAue.TabIndex = 15;
            this.comboAue.Text = "mp3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "输出格式";
            // 
            // comboPer
            // 
            this.comboPer.FormattingEnabled = true;
            this.comboPer.Items.AddRange(new object[] {
            "度小宇",
            "度小美",
            "度逍遥",
            "度丫丫"});
            this.comboPer.Location = new System.Drawing.Point(67, 27);
            this.comboPer.Name = "comboPer";
            this.comboPer.Size = new System.Drawing.Size(121, 20);
            this.comboPer.TabIndex = 13;
            this.comboPer.Text = "度逍遥";
            // 
            // btnSynthesis
            // 
            this.btnSynthesis.Location = new System.Drawing.Point(188, 349);
            this.btnSynthesis.Name = "btnSynthesis";
            this.btnSynthesis.Size = new System.Drawing.Size(75, 23);
            this.btnSynthesis.TabIndex = 12;
            this.btnSynthesis.Text = "开始合成";
            this.btnSynthesis.UseVisualStyleBackColor = true;
            this.btnSynthesis.Click += new System.EventHandler(this.btn_Synthesis_Click);
            // 
            // numVol
            // 
            this.numVol.Location = new System.Drawing.Point(67, 128);
            this.numVol.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numVol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVol.Name = "numVol";
            this.numVol.Size = new System.Drawing.Size(120, 21);
            this.numVol.TabIndex = 11;
            this.numVol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPit
            // 
            this.numPit.Location = new System.Drawing.Point(67, 95);
            this.numPit.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numPit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPit.Name = "numPit";
            this.numPit.Size = new System.Drawing.Size(120, 21);
            this.numPit.TabIndex = 10;
            this.numPit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numSpd
            // 
            this.numSpd.Location = new System.Drawing.Point(67, 63);
            this.numSpd.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSpd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpd.Name = "numSpd";
            this.numSpd.Size = new System.Drawing.Size(120, 21);
            this.numSpd.TabIndex = 9;
            this.numSpd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "音量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "音调";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "语速";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "音库";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始合成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Synthesis_Click);
            // 
            // txtSynthesisInput
            // 
            this.txtSynthesisInput.Location = new System.Drawing.Point(13, 199);
            this.txtSynthesisInput.Name = "txtSynthesisInput";
            this.txtSynthesisInput.Size = new System.Drawing.Size(237, 120);
            this.txtSynthesisInput.TabIndex = 0;
            this.txtSynthesisInput.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboAudioFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtSynthesisInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtRecogResult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboModelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSpd;
        private System.Windows.Forms.NumericUpDown numVol;
        private System.Windows.Forms.NumericUpDown numPit;
        private System.Windows.Forms.ComboBox comboPer;
        private System.Windows.Forms.Button btnSynthesis;
        private System.Windows.Forms.ComboBox comboAue;
        private System.Windows.Forms.Label label8;
    }
}