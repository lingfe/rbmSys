using BLL;
using Model;
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
    /// <summary>
    /// 切换身份的窗口
    /// </summary>
    public partial class handoffIdentityFrom : Form
    {
        public handoffIdentityFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录窗口,主页窗口
        /// </summary>
        loginFrm login = null;
        forMian mian = null;
        public handoffIdentityFrom(loginFrm login,forMian mian)
        {
            this.login = login;
            this.mian = mian;
            InitializeComponent();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        UserSql sql = new UserSql();

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void handoffIdentityFrom_Load(object sender, EventArgs e)
        {
            string str="";
            //得到数据
            List<User> infoList = sql.getWhereList("where appId='3DF7469FD3A1485B95ED16ED794780A8'");
            label1.Text = "用户列表("+infoList.Count+")";
            //list数据
            listView1.Items.Clear();
            foreach (User fo in infoList)
            {
                ListViewItem lv = new ListViewItem(fo.Id);          //0.编号
                lv.SubItems.Add(fo.Realname);
                lv.SubItems.Add(fo.AvatarUrl);
                lv.SubItems.Add(fo.Mobile);
                if (fo.Address == "0")
                {
                    str = "虚拟用户";
                }
                else {
                    str = "";
                }
                lv.SubItems.Add(str);

                listView1.Items.Add(lv);
            }
        }

        /// <summary>
        /// 使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0].SubItems[4].Text == "虚拟用户")
                {
                    PublicField.isVirtualuser = true;
                }
                else {
                    PublicField.isVirtualuser = false;
                }
                PublicField.adminId = listView1.SelectedItems[0].SubItems[0].Text;
                PublicField.adminName = listView1.SelectedItems[0].SubItems[1].Text;
                PublicField.adminImg = listView1.SelectedItems[0].SubItems[2].Text;

                //判断非空
                if (this.login != null) {
                    login.chushihua();
                }
                else if (this.mian != null) {
                    mian.chushihua();
                }
                this.Close();
            }
            else {
                MessageBox.Show("请选择要切换的用户!");
            }
        }
    }
}
