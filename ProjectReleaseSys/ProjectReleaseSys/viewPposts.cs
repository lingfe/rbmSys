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
    /// 查看帖子窗口
    /// </summary>
    public partial class viewPposts : Form
    {
        public viewPposts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发布信息id,发布者id,发布信息图片
        /// </summary>
        string releaseId = null;
        string personalId = null;
        string ImgUrl = null;
        public viewPposts(string releaseId,string personalId,string ImgUrl)
        {
            this.ImgUrl = ImgUrl;
            this.personalId = personalId;
            this.releaseId = releaseId;
            InitializeComponent();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        commentinfoSql sql = new commentinfoSql();
        NoticeSql sqlNotice = new NoticeSql();


        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewPposts_Load(object sender, EventArgs e)
        {

            this.getcommList();
        }

        /// <summary>
        /// 得到数据
        /// </summary>
        public void getcommList(){
            //判断是否为空
            if (!string.IsNullOrWhiteSpace(releaseId))
            {
                List<Commentinfo> infoList = sql.getWhereList("where releaseId='" + releaseId + "'");
                label1.Text = "帖子评论信息（" +infoList.Count+ ")";
                //list数据
                listView1.Items.Clear();
                foreach (Commentinfo fo in infoList)
                {
                    ListViewItem lv = new ListViewItem(fo.Id);          //0.编号
                    lv.SubItems.Add(fo.ReleaseId);
                    lv.SubItems.Add(fo.PersonalId);
                    lv.SubItems.Add(fo.CommentContent);
                    lv.SubItems.Add(fo.AvatarUrl);
                    lv.SubItems.Add(fo.Remark);
                    lv.SubItems.Add(fo.Cdate.ToString());
                    lv.SubItems.Add(fo.Mdate.ToString());

                    listView1.Items.Add(lv);
                }
            }
            else
            {
                MessageBox.Show("发布id有错误!");
            }
        }

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Commentinfo info = new Commentinfo();
                //uuid
                info.Id = System.Guid.NewGuid().ToString("N");
                info.ReleaseId = this.releaseId;
                info.PersonalId = PublicField.adminId;
                info.Remark = PublicField.adminName;
                info.AvatarUrl = PublicField.adminImg;
                info.Cdate = DateTime.Now;
                info.Mdate = info.Cdate;
                info.CommentContent = textBox1.Text;
                info.Creator = PublicField.adminId;
                info.Uman = PublicField.adminId;
                

                //调用方法
                int tt = sql.setCommentInfo(info);
                if (tt != -1)
                {
                    //发送通知
                    this.setNotice(info.CommentContent);
                    this.getcommList();
                    MessageBox.Show("添加成功!");
                    textBox1.Text = "";
                }
                else {
                    MessageBox.Show("添加失败!");
                }
            }
            else {
                MessageBox.Show("评论内容不能为空!");
            }
        }
        /// <summary>
        /// 发送留言通知
        /// </summary>
        public void setNotice(string content)
        {
            Notice ice = new Notice();
            ice.Id = System.Guid.NewGuid().ToString("N");
            ice.PersonalId = this.personalId;
            ice.ReleaseId = this.releaseId;
            ice.Content = content;
            ice.ImgUrl = PublicField.domainImage+ this.ImgUrl.Split(',')[0];
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
        /// 回复评论
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string remark = listView1.SelectedItems[0].SubItems[5].Text;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    Commentinfo info = new Commentinfo();
                    //uuid
                    info.Id = System.Guid.NewGuid().ToString("N");
                    info.ReleaseId = this.releaseId;
                    info.PersonalId = PublicField.adminId;
                    info.Remark = PublicField.adminName;
                    info.AvatarUrl = PublicField.adminImg;
                    info.Cdate = DateTime.Now;
                    info.Mdate = info.Cdate;
                    info.CommentContent = "回复@" + remark+":"+textBox1.Text;
                    info.Creator = PublicField.adminId;
                    info.Uman = PublicField.adminId;

                    //调用方法
                    int tt = sql.setCommentInfo(info);
                    if (tt != -1)
                    {
                        //发送通知
                        this.setNotice(info.CommentContent);
                        this.getcommList();
                        MessageBox.Show("回复成功!");
                        textBox1.Text = "";
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
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
                        //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                //调用
                int tt=sql.delete(id);
                if (tt != -1)
                {
                    this.getcommList();
                    MessageBox.Show("删除成功!");
                }
                else {
                    MessageBox.Show("删除失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }
    }
}
