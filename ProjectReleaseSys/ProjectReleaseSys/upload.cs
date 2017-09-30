using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectReleaseSys
{
    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 定义文件上传工具对象
        /// </summary>
        UpdateUtile uUtile = new UpdateUtile();

        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //得到文件筐
            OpenFileDialog di = this.openFileDialog1;
            //设置文件类型
            di.Filter = "Files|*.jpg;*.png;*.ico;*.gif";
            //设置是否多选
            di.Multiselect = true;
            //设置为当前项目路径
            di.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //判断操作
            if (di.ShowDialog() == DialogResult.OK)
            {
                //设置获取图片数量
                lbl_ImgNuber.Text = "总共：" + di.FileNames.Length + "张";
                //遍历获取的图片
                for (int i = 0; i < di.FileNames.Length; ++i)
                {
                    //设置保存图片加路径
                    string safeFileName = "admin/" + di.SafeFileNames[i];
                    string fileName = di.FileNames[i];
                    //调用ftp上传
                    //string str = uUtile.ftpUpload(safeFileName, fileName);
                    if ("" != null)
                    {
                        imageList1.Images.Add(Image.FromFile(di.FileNames[i]));
                        txt_imageArray.Text += di.FileNames[i]+",";//str + ",";
                    }
                }
            }

        }


        int tt = 0;
        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.imageList1.Images.Count > tt)
            {
                //显示图片
                lab_diji.Text = "第" + (tt + 1) + "张";
                pictureBox1.Image = imageList1.Images[tt];
                tt++;
            }
            else tt = 0;
        }
    }
}
