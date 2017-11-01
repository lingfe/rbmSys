using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectReleaseSys
{
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 确定登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //保存管理员
            PublicField.adminName = txt_adminName.Text;
            PublicField.adminId = txt_adminId.Text;

            //打开主窗体
            forMian m = new forMian();
            m.Show();

            this.Visible = false;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void chushihua() {
            txt_adminName.Text = PublicField.adminName;
            txt_adminId.Text = PublicField.adminId;

            this.pictureBox1.Image = null;
            this.pictureBox1.WaitOnLoad = false; //设置为异步加载图片  
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.LoadAsync(PublicField.adminImg);
        }


        /// <summary>
        /// 取消登录，关闭结束程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NO_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginFrm_Load(object sender, EventArgs e)
        {
            this.chushihua();
        }

        /// <summary>
        /// 切换身份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            handoffIdentityFrom frm = new handoffIdentityFrom(this,null);
            frm.ShowDialog();
        }


        /// <summary>
        /// 定义文件上传工具对象
        /// </summary>
        UpdateUtile uUtile = new UpdateUtile();

        /// <summary>
        /// 上传头像
        /// </summary>
        public void updateFtpImg()
        {
            //得到文件筐
            OpenFileDialog di = this.openFileDialog1;
            //设置文件类型
            di.Filter = "Files|*.jpg;*.png;*.ico;*.gif";
            //设置是否多选
            di.Multiselect = true;
            //判断操作
            if (di.ShowDialog() == DialogResult.OK)
            {
                if (di.FileNames.Length > 1)
                {
                    MessageBox.Show("总共只能选择1张图片哦!");
                    return;
                }
                //遍历获取的图片
                for (int i = 0; i < di.FileNames.Length; ++i)
                {
                    //设置保存图片加路径
                    string fileName = di.FileNames[i];
                    string str = uUtile.setUploadFile(fileName);
                    if (str != null)
                    {
                        str = PublicField.domainImage + str;
                        PublicField.adminImg = str;
                        this.pictureBox1.Image = null;
                        this.pictureBox1.WaitOnLoad = false; //设置为异步加载图片  
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBox1.LoadAsync(str);

                    }
                }
            }
        }

        /// <summary>
        /// 头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.updateFtpImg();
        }

    }
}
