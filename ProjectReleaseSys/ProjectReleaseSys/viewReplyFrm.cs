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
    /// 查看回复界面
    /// </summary>
    public partial class viewReplyFrm : Form
    {
        public viewReplyFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 评论表id
        /// </summary>
        string commentinfoId = "";
        /// <summary>
        /// 发布信息id
        /// </summary>
        string releaseId = "";
        /// <summary>
        /// 回复谁(id)
        /// </summary>
        string replypersonalId = "";
        /// <summary>
        /// 评论者名称
        /// </summary>
        string commentName="";

        public viewReplyFrm(string commentinfoId, string releaseId, string replypersonalId, string commentName)
        {
            this.commentinfoId = commentinfoId;
            this.releaseId = releaseId;
            this.replypersonalId = replypersonalId;
            this.commentName = commentName;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewReplyFrm_Load(object sender, EventArgs e)
        {
            this.getReplyList();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        NoticeSql sqlNotice = new NoticeSql();
        ReplySql sql = new ReplySql();

        /// <summary>
        /// 得到数据
        /// </summary>
        public void getReplyList()
        {
            //判断是否为空
            if (!string.IsNullOrWhiteSpace(commentinfoId))
            {
                List<Reply> infoList = sql.getWhereList("where commentinfoId='" + commentinfoId + "'");
                label1.Text = "帖子评论>回复信息（" + infoList.Count + ")";
                //list数据
                listView1.Items.Clear();
                foreach (Reply fo in infoList)
                {
                    ListViewItem lv = new ListViewItem(fo.Id);          //0.编号
                    lv.SubItems.Add(fo.CommentinfoId);  //1.评论表id
                    lv.SubItems.Add(fo.ReleaseId);      //2.发布信息id
                    lv.SubItems.Add(fo.PersonalId);     //3.回复者id
                    lv.SubItems.Add(fo.PersonalName);   //4.回复者名称
                    lv.SubItems.Add(fo.AvatarUrl);      //5.回复者头像
                    lv.SubItems.Add(fo.Content);        //6.回复内容
                    lv.SubItems.Add(fo.ReplypersonalId);//7.回复谁(id)
                    lv.SubItems.Add(fo.Cdate.ToString());//8.创建时间
                    lv.SubItems.Add(fo.Mdate.ToString());//9.修改时间

                    listView1.Items.Add(lv);
                }
            }
            else
            {
                MessageBox.Show("评论信息id有错误!");
            }
        }

        /// <summary>
        /// 添加回复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_insert_Click(object sender, EventArgs e)
        {
            //验证回复内容是否为空
            if (!string.IsNullOrWhiteSpace(txt_content.Text))
            {
                //创建回复实体对象
                Reply info = new Reply();
                //uuid
                info.Id = System.Guid.NewGuid().ToString("N");
                info.CommentinfoId = this.commentinfoId;
                info.ReleaseId = this.releaseId;
                info.PersonalId = PublicField.adminId;
                info.PersonalName = PublicField.adminName;
                info.AvatarUrl = PublicField.adminImg;
                info.ReplypersonalId = this.replypersonalId;

                info.Cdate = DateTime.Now;
                info.Mdate = info.Cdate;

                info.Content = "回复@" + this.commentName + ":" + txt_content.Text;
                info.Creator = PublicField.adminId;
                info.Uman = PublicField.adminId;

                //调用方法
                int tt = sql.setInsert(info);
                if (tt != -1)
                {
                    //发送通知
                    this.setNotice(info.Content);
                    this.getReplyList();
                    MessageBox.Show("回复成功!");
                    txt_content.Text = "";
                }
                else
                {
                    MessageBox.Show("回复失败!");
                }
            }
            else
            {
                MessageBox.Show("回复内容不能为空!");
            }
        }

        /// <summary>
        /// 发送留言通知
        /// </summary>
        public void setNotice(string content)
        {
            Notice ice = new Notice();
            ice.Id = System.Guid.NewGuid().ToString("N");
            ice.PersonalId = this.replypersonalId;
            ice.ReleaseId = this.releaseId;
            ice.Content = content;
            ice.StaticStr = 0;
            ice.Ntype = "1";
            ice.AvatarUrl = PublicField.adminImg;
            ice.Uman = PublicField.adminId;
            ice.Creator = PublicField.adminId;
            ice.Cdate = DateTime.Now;
            ice.Mdate = ice.Cdate;
            ice.Notifyname = PublicField.adminName;

            //调用
            int tt = sqlNotice.setInsert(ice);

        }

        /// <summary>
        /// 删除回复信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //验证是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                int tt=sql.delete(id);
                if (tt != -1)
                {
                    this.getReplyList();
                    MessageBox.Show("删除成功!");
                }
                else
                {
                    MessageBox.Show("删除失败!");
                }
            }
            else {
                MessageBox.Show("请选择你要删除的回复信息!");
                return;
            }
        }

    }
}
