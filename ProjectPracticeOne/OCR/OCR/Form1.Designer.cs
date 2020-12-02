namespace OCR
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
            this.rtbGeneral = new System.Windows.Forms.RichTextBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.cbDirection = new System.Windows.Forms.CheckBox();
            this.cbLocation = new System.Windows.Forms.CheckBox();
            this.rbUncommon = new System.Windows.Forms.RadioButton();
            this.rbHighPrecision = new System.Windows.Forms.RadioButton();
            this.rbCommonPrecision = new System.Windows.Forms.RadioButton();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbUrlImage = new System.Windows.Forms.RichTextBox();
            this.btnUrlImage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbPlate = new System.Windows.Forms.RadioButton();
            this.rbVehicle = new System.Windows.Forms.RadioButton();
            this.rbDrive = new System.Windows.Forms.RadioButton();
            this.rbBank = new System.Windows.Forms.RadioButton();
            this.rbIdBack = new System.Windows.Forms.RadioButton();
            this.rtbCard = new System.Windows.Forms.RichTextBox();
            this.rbIdFront = new System.Windows.Forms.RadioButton();
            this.btnCard = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbForm = new System.Windows.Forms.RichTextBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGeneral);
            this.groupBox1.Controls.Add(this.btnGeneral);
            this.groupBox1.Controls.Add(this.cbDirection);
            this.groupBox1.Controls.Add(this.cbLocation);
            this.groupBox1.Controls.Add(this.rbUncommon);
            this.groupBox1.Controls.Add(this.rbHighPrecision);
            this.groupBox1.Controls.Add(this.rbCommonPrecision);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通用文字识别";
            // 
            // rtbGeneral
            // 
            this.rtbGeneral.Location = new System.Drawing.Point(8, 79);
            this.rtbGeneral.Name = "rtbGeneral";
            this.rtbGeneral.Size = new System.Drawing.Size(321, 204);
            this.rtbGeneral.TabIndex = 5;
            this.rtbGeneral.Text = "";
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(254, 44);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "识别图片";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // cbDirection
            // 
            this.cbDirection.AutoSize = true;
            this.cbDirection.Location = new System.Drawing.Point(117, 44);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(72, 16);
            this.cbDirection.TabIndex = 4;
            this.cbDirection.Text = "检测方向";
            this.cbDirection.UseVisualStyleBackColor = true;
            // 
            // cbLocation
            // 
            this.cbLocation.AutoSize = true;
            this.cbLocation.Location = new System.Drawing.Point(16, 44);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(84, 16);
            this.cbLocation.TabIndex = 3;
            this.cbLocation.Text = "含位置信息";
            this.cbLocation.UseVisualStyleBackColor = true;
            // 
            // rbUncommon
            // 
            this.rbUncommon.AutoSize = true;
            this.rbUncommon.Location = new System.Drawing.Point(206, 22);
            this.rbUncommon.Name = "rbUncommon";
            this.rbUncommon.Size = new System.Drawing.Size(59, 16);
            this.rbUncommon.TabIndex = 2;
            this.rbUncommon.TabStop = true;
            this.rbUncommon.Text = "生僻字";
            this.rbUncommon.UseVisualStyleBackColor = true;
            // 
            // rbHighPrecision
            // 
            this.rbHighPrecision.AutoSize = true;
            this.rbHighPrecision.Location = new System.Drawing.Point(117, 21);
            this.rbHighPrecision.Name = "rbHighPrecision";
            this.rbHighPrecision.Size = new System.Drawing.Size(59, 16);
            this.rbHighPrecision.TabIndex = 1;
            this.rbHighPrecision.TabStop = true;
            this.rbHighPrecision.Text = "高精度";
            this.rbHighPrecision.UseVisualStyleBackColor = true;
            // 
            // rbCommonPrecision
            // 
            this.rbCommonPrecision.AutoSize = true;
            this.rbCommonPrecision.Location = new System.Drawing.Point(16, 21);
            this.rbCommonPrecision.Name = "rbCommonPrecision";
            this.rbCommonPrecision.Size = new System.Drawing.Size(71, 16);
            this.rbCommonPrecision.TabIndex = 0;
            this.rbCommonPrecision.TabStop = true;
            this.rbCommonPrecision.Text = "普通精度";
            this.rbCommonPrecision.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenFile.Location = new System.Drawing.Point(266, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开图片";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 21);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbUrlImage);
            this.groupBox2.Controls.Add(this.btnUrlImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络图片文字识别";
            // 
            // rtbUrlImage
            // 
            this.rtbUrlImage.Location = new System.Drawing.Point(6, 49);
            this.rtbUrlImage.Name = "rtbUrlImage";
            this.rtbUrlImage.Size = new System.Drawing.Size(323, 216);
            this.rtbUrlImage.TabIndex = 6;
            this.rtbUrlImage.Text = "";
            // 
            // btnUrlImage
            // 
            this.btnUrlImage.Location = new System.Drawing.Point(254, 20);
            this.btnUrlImage.Name = "btnUrlImage";
            this.btnUrlImage.Size = new System.Drawing.Size(75, 23);
            this.btnUrlImage.TabIndex = 6;
            this.btnUrlImage.Text = "识别图片";
            this.btnUrlImage.UseVisualStyleBackColor = true;
            this.btnUrlImage.Click += new System.EventHandler(this.btnUrlImage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBusiness);
            this.groupBox3.Controls.Add(this.rbPlate);
            this.groupBox3.Controls.Add(this.rbVehicle);
            this.groupBox3.Controls.Add(this.rbDrive);
            this.groupBox3.Controls.Add(this.rbBank);
            this.groupBox3.Controls.Add(this.rbIdBack);
            this.groupBox3.Controls.Add(this.rtbCard);
            this.groupBox3.Controls.Add(this.rbIdFront);
            this.groupBox3.Controls.Add(this.btnCard);
            this.groupBox3.Location = new System.Drawing.Point(369, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "卡证识别";
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Location = new System.Drawing.Point(256, 20);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(71, 16);
            this.rbBusiness.TabIndex = 12;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "营业执照";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbPlate
            // 
            this.rbPlate.AutoSize = true;
            this.rbPlate.Location = new System.Drawing.Point(143, 47);
            this.rbPlate.Name = "rbPlate";
            this.rbPlate.Size = new System.Drawing.Size(47, 16);
            this.rbPlate.TabIndex = 11;
            this.rbPlate.TabStop = true;
            this.rbPlate.Text = "车牌";
            this.rbPlate.UseVisualStyleBackColor = true;
            // 
            // rbVehicle
            // 
            this.rbVehicle.AutoSize = true;
            this.rbVehicle.Location = new System.Drawing.Point(78, 47);
            this.rbVehicle.Name = "rbVehicle";
            this.rbVehicle.Size = new System.Drawing.Size(59, 16);
            this.rbVehicle.TabIndex = 10;
            this.rbVehicle.TabStop = true;
            this.rbVehicle.Text = "行驶证";
            this.rbVehicle.UseVisualStyleBackColor = true;
            // 
            // rbDrive
            // 
            this.rbDrive.AutoSize = true;
            this.rbDrive.Location = new System.Drawing.Point(13, 47);
            this.rbDrive.Name = "rbDrive";
            this.rbDrive.Size = new System.Drawing.Size(59, 16);
            this.rbDrive.TabIndex = 9;
            this.rbDrive.TabStop = true;
            this.rbDrive.Text = "驾驶证";
            this.rbDrive.UseVisualStyleBackColor = true;
            // 
            // rbBank
            // 
            this.rbBank.AutoSize = true;
            this.rbBank.Location = new System.Drawing.Point(191, 20);
            this.rbBank.Name = "rbBank";
            this.rbBank.Size = new System.Drawing.Size(59, 16);
            this.rbBank.TabIndex = 8;
            this.rbBank.TabStop = true;
            this.rbBank.Text = "银行卡";
            this.rbBank.UseVisualStyleBackColor = true;
            // 
            // rbIdBack
            // 
            this.rbIdBack.AutoSize = true;
            this.rbIdBack.Location = new System.Drawing.Point(102, 20);
            this.rbIdBack.Name = "rbIdBack";
            this.rbIdBack.Size = new System.Drawing.Size(83, 16);
            this.rbIdBack.TabIndex = 7;
            this.rbIdBack.TabStop = true;
            this.rbIdBack.Text = "身份证背面";
            this.rbIdBack.UseVisualStyleBackColor = true;
            // 
            // rtbCard
            // 
            this.rtbCard.Location = new System.Drawing.Point(6, 69);
            this.rtbCard.Name = "rtbCard";
            this.rtbCard.Size = new System.Drawing.Size(326, 125);
            this.rtbCard.TabIndex = 7;
            this.rtbCard.Text = "";
            // 
            // rbIdFront
            // 
            this.rbIdFront.AutoSize = true;
            this.rbIdFront.Location = new System.Drawing.Point(13, 20);
            this.rbIdFront.Name = "rbIdFront";
            this.rbIdFront.Size = new System.Drawing.Size(83, 16);
            this.rbIdFront.TabIndex = 6;
            this.rbIdFront.TabStop = true;
            this.rbIdFront.Text = "身份证正面";
            this.rbIdFront.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(256, 42);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(75, 23);
            this.btnCard.TabIndex = 6;
            this.btnCard.Text = "识别图片";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbForm);
            this.groupBox4.Controls.Add(this.btnForm);
            this.groupBox4.Location = new System.Drawing.Point(369, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 205);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "表格文字识别";
            // 
            // rtbForm
            // 
            this.rtbForm.Location = new System.Drawing.Point(6, 49);
            this.rtbForm.Name = "rtbForm";
            this.rtbForm.Size = new System.Drawing.Size(326, 150);
            this.rtbForm.TabIndex = 9;
            this.rtbForm.Text = "";
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(257, 20);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 8;
            this.btnForm.Text = "识别图片";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbReceipt);
            this.groupBox5.Controls.Add(this.btnReceipt);
            this.groupBox5.Location = new System.Drawing.Point(369, 456);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 176);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "通用票据识别";
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.Location = new System.Drawing.Point(11, 49);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.Size = new System.Drawing.Size(321, 121);
            this.rtbReceipt.TabIndex = 11;
            this.rtbReceipt.Text = "";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(257, 20);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnReceipt.TabIndex = 10;
            this.btnReceipt.Text = "识别图片";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbGeneral;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.CheckBox cbDirection;
        private System.Windows.Forms.CheckBox cbLocation;
        private System.Windows.Forms.RadioButton rbUncommon;
        private System.Windows.Forms.RadioButton rbHighPrecision;
        private System.Windows.Forms.RadioButton rbCommonPrecision;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUrlImage;
        private System.Windows.Forms.RichTextBox rtbUrlImage;
        private System.Windows.Forms.RichTextBox rtbCard;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.RichTextBox rtbForm;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.RadioButton rbVehicle;
        private System.Windows.Forms.RadioButton rbDrive;
        private System.Windows.Forms.RadioButton rbBank;
        private System.Windows.Forms.RadioButton rbIdBack;
        private System.Windows.Forms.RadioButton rbIdFront;
        private System.Windows.Forms.RadioButton rbPlate;
        private System.Windows.Forms.RadioButton rbBusiness;
    }
}

