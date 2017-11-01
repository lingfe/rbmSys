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
    public partial class sysAddUser : Form
    {
        public sysAddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 身份验证
        /// </summary>
        forMian mian = null;
        public sysAddUser(forMian mian)
        {
            this.mian = mian;
            InitializeComponent();
        }

        /// <summary>
        /// 定义文件上传工具对象
        /// </summary>
        UpdateUtile uUtile = new UpdateUtile();

        /// <summary>
        /// 上传头像
        /// </summary>
        public void updateFtpImg() {
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
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysAddUser_Load(object sender, EventArgs e)
        {
            this.getId();
        }

        /// <summary>
        /// 生成id
        /// </summary>
        /// <returns></returns>
        public void getId() {
            //一句话即可，但此时id中有“-”符号存在，使用下面语句可变为纯字母+数字。
            string id = System.Guid.NewGuid().ToString("N");
            txt_adminId.Text = id;
            txt_adminName.Text = "未填写";
        }
        
        /// <summary>
        /// 确定使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            PublicField.adminId = txt_adminId.Text;
            PublicField.adminName = txt_adminName.Text;
            PublicField.isVirtualuser = true;
            //打开主窗体
            this.mian.chushihua();
            this.Close();
        }

        /// <summary>
        /// 重新生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NO_Click(object sender, EventArgs e)
        {
            this.getId();
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
