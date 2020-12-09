using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ImageRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string APPID = "23108740";
        private string APIKEY = "l2h6aObf67bDPUTzRwKLXQHQ";
        private string APISECRET = "Mipvg24iSHMewTPpmFYZN6BR41sm0q4h";
        private string fileName = "";

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Load(fileDialog.FileName);
                fileName = fileDialog.FileName;
            }
            var thGeneralDetection = new Thread(threadGeneralDetection);
            thGeneralDetection.Name = "thGeneralDetection";
            thGeneralDetection.Start();

            var thMainObjectDetection = new Thread(threadMainObjectDetection);
            thMainObjectDetection.Name = "thMainObjectDetection";
            thMainObjectDetection.Start();
        }

        private void threadGeneralDetection()
        {
            Console.WriteLine("threadGeneralDetection start");
            //通用物体及场景识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var options = new Dictionary<string, object>{
	                        {"baike_num", 5}
	                        };
            var result = client.AdvancedGeneral(image, options);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("目标: " + result["result"][i]["keyword"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["score"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Invoke(new Action(() => {
                this.richTextBox1.Text = sb.ToString();
            }));
            //this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Invoke(new Action(() =>
                    {
                        this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    }));
                    //this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }

            Console.WriteLine("threadGeneralDetection end");
        }

        private void threadMainObjectDetection()
        {
            Console.WriteLine("threadMainObjectDetection start");
            //图像主体识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var optionsObject = new Dictionary<string, object>{
	                        {"with_face", this.cbDetctFace.Checked}
	                        };
            var resultObject = client.ObjectDetect(image, optionsObject);

            int x = Convert.ToInt32(resultObject["result"]["left"]);
            int y = Convert.ToInt32(resultObject["result"]["top"]);
            int width = Convert.ToInt32(resultObject["result"]["width"]);
            int height = Convert.ToInt32(resultObject["result"]["height"]);

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(width.ToString());
            Console.WriteLine(height.ToString());

            Bitmap image1 = new Bitmap(fileName);
            Graphics g = Graphics.FromImage(image1);
            Pen pen = new Pen(Color.Red, 3);
            g.DrawRectangle(pen, x, y, width, height);
            this.pictureBox1.Image = image1;
            Console.WriteLine("threadMainObjectDetection end");
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            //菜品识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var options = new Dictionary<string, object>{
	                        {"top_num", 3},
	                        {"filter_threshold", "0.7"},
	                        {"baike_num", 5}
	                        };
            var result = client.DishDetect(image, options);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("菜品: " + result["result"][i]["name"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["probability"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            //车辆识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var options = new Dictionary<string, object>{
	                        {"top_num", 3},
                            {"baike_num", 5}
	                        };
            var result = client.CarDetect(image, options);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("车辆: " + result["result"][i]["name"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["score"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            //logo识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var result = client.LogoSearch(image);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("logo: " + result["result"][i]["name"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["probability"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            //动物识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var options = new Dictionary<string, object>{
                            {"top_num", 3},
	                        {"baike_num", 5}
	                        };
            var result = client.AnimalDetect(image, options);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("动物: " + result["result"][i]["name"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["score"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }
        }

        private void btnPlant_Click(object sender, EventArgs e)
        {
            //植物识别
            var client = new Baidu.Aip.ImageClassify.ImageClassify(APIKEY, APISECRET);
            var image = File.ReadAllBytes(fileName);
            var options = new Dictionary<string, object>{
	                        {"baike_num", 5}
	                        };
            var result = client.PlantDetect(image, options);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                sb.AppendLine("植物: " + result["result"][i]["name"].ToString());
                sb.AppendLine("置信度: " + result["result"][i]["score"].ToString());
                sb.AppendLine();
            }
            //显示结果
            this.richTextBox1.Text = sb.ToString();
            for (int i = 0; i < result["result"].Count(); i++)
            {
                bool desExists = result["result"][i]["baike_info"].ToString().Contains("description");
                bool imageUrlExists = result["result"][i]["baike_info"].ToString().Contains("image_url");
                if (desExists && imageUrlExists)
                {
                    //显示描述
                    this.richTextBox2.Text = result["result"][i]["baike_info"]["description"].ToString();
                    //显示图片
                    try
                    {
                        this.pictureBox2.Image = null;
                        this.pictureBox2.WaitOnLoad = false; //设置为异步加载图片
                        this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox2.LoadAsync(result["result"][i]["baike_info"]["image_url"].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("网络链接失败！");
                    }
                    break;
                }
            }
        }

    }
}
