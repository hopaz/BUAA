using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string apiId = "23068704";
        private string apiKey = "MXGy5bb1Lr30eX6qh54ISznX";
        private string apiSecret = "OzVnzEbnQ6R5NxclMYf3zBRcSr9MnI5o";

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                this.textBox1.Text = fileDialog.FileName;
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            
            var options = new Dictionary<string, object>();
            if (cbDirection.Checked)
            {
                options.Add("detect_direction", "true");
            }

            if (rbCommonPrecision.Checked && cbLocation.Checked)
            {
                options.Add("vertexes_location", "true");
                var result = client.General(image, options);
                rtbGeneral.Text = result.ToString();
            }else if(rbCommonPrecision.Checked && !cbLocation.Checked ){
                var result = client.AccurateBasic(image, options);
                rtbGeneral.Text = result.ToString();
            }
            else if (rbHighPrecision.Checked && cbLocation.Checked)
            {
                options.Add("vertexes_location", "true");
                var result = client.Accurate(image, options);
                rtbGeneral.Text = result.ToString();
            }
            else if (rbHighPrecision.Checked && !cbLocation.Checked)
            {
                var result = client.AccurateBasic(image, options);
                rtbGeneral.Text = result.ToString();
            }

            if (rbUncommon.Checked)
            {
                var result = client.GeneralEnhanced(image);
                rtbGeneral.Text = result.ToString();
            }
        }

        private void btnUrlImage_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            var result = client.WebImage(image);
            rtbUrlImage.Text = result.ToString();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            if (rbIdFront.Checked)
            {
                var idCardSide = "front";
                var result = client.Idcard(image, idCardSide);
                rtbCard.Text = result.ToString();
            }
            else if (rbIdBack.Checked)
            {
                var idCardSide = "back";
                var result = client.Idcard(image, idCardSide);
                rtbCard.Text = result.ToString();
            }else if (rbBank.Checked){
                var result = client.Bankcard(image);
                rtbCard.Text = result.ToString();
            }else if (rbBusiness.Checked){
                var result = client.BusinessLicense(image);
                rtbCard.Text = result.ToString();
            }else if (rbDrive.Checked){
                var result = client.DrivingLicense(image);
                rtbCard.Text = result.ToString();
            }else if (rbVehicle.Checked){
                var result = client.VehicleLicense(image);
                rtbCard.Text = result.ToString();
            }else if (rbPlate.Checked){
                var result = client.LicensePlate(image);
                rtbCard.Text = result.ToString();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            var result = client.Receipt(image);
            rtbReceipt.Text = result.ToString();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            var th = new Thread(new ThreadStart(CheckStatusInNewThread));
            th.Name = "StatusCheckThread";
            th.Start();

            /***
            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            var result_id = client.TableRecognitionRequest(image);
            var result = client.TableRecognitionGetResult(result_id["result"]["request_id"].ToString());
            rtbReceipt.Text = result.ToString();
             ***/
        }

        private void CheckStatusInNewThread()
        {
            // 禁用按钮
            this.btnForm.Invoke(new Action(() =>
            {
                this.btnForm.Enabled = false;
            }));

            var client = new Baidu.Aip.Ocr.Ocr(apiKey, apiSecret);
            string filePath = textBox1.Text;
            var image = File.ReadAllBytes(filePath);
            var result_id = client.TableRecognitionRequest(image);
            var result = client.TableRecognitionGetResult(result_id["result"][0]["request_id"].ToString());

            this.rtbForm.Invoke(new Action(() =>
            {
                this.rtbForm.Text = result.ToString();
            }));

            // 启用按钮
            this.btnForm.Invoke(new Action(() =>
            {
                this.btnForm.Enabled = true;
            }));
        }
    }
}
