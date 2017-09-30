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
        /// 取消登录，关闭结束程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NO_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
