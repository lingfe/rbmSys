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
    public partial class forMian : Form
    {
        public forMian()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        ReleaseInfoSql sql = new ReleaseInfoSql();


        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forMian_Load(object sender, EventArgs e)
        {
            //管理员信息
            toolStripStatusLabel1.Text = "管理员:" + PublicField.adminName;
            toolStripStatusLabel2.Text = "管理员id：" + PublicField.adminId;
           
            //加载数据
            this.getList();
            this.getTable();
        }

        /// <summary>
        /// list数据
        /// </summary>
        public void getList() {
            //list数据
            listView1.Items.Clear();
            List<ReleaseInfo> info = sql.getList();
            foreach (ReleaseInfo fo in info)
            {
                ListViewItem lv = new ListViewItem(fo.Id);

                lv.SubItems.Add(fo.ReleaseType);
                lv.SubItems.Add(fo.Title);
                lv.SubItems.Add(fo.Threshold.ToString() + "万");
                lv.SubItems.Add(fo.IndustryChoice);
                lv.SubItems.Add(fo.FundDistribution);
                lv.SubItems.Add(fo.ProjectDescription);
                lv.SubItems.Add(fo.IncomeDescription);
                lv.SubItems.Add(fo.TeamIntroduction);
                lv.SubItems.Add(fo.Phone);
                lv.SubItems.Add(fo.ImageArray);
                lv.SubItems.Add(fo.PublisherIdentity);
                lv.SubItems.Add(fo.GeographicalPosition);
                lv.SubItems.Add(fo.OperatingArea);
                lv.SubItems.Add(fo.MonthlyRent);
                lv.SubItems.Add(fo.BusinessDescription);
                lv.SubItems.Add(fo.TransferReason);
                lv.SubItems.Add(fo.ThrowInTheCity);
                lv.SubItems.Add(fo.HeadquartersLocation);
                lv.SubItems.Add(fo.ResourceRequirements);
                lv.SubItems.Add(fo.ShareDivision);

                listView1.Items.Add(lv);
            }
        }

        /// <summary>
        /// table数据
        /// </summary>
        public void getTable() {
            //得到tab数据
            dataGridView1.DataSource = sql.getreleaseinfoDataSet().Tables[0];
        }

        /// <summary>
        /// 合伙创业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 合伙创业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partnershipFrm frm = new partnershipFrm(this);
            frm.ShowDialog();

        }

        /// <summary>
        /// 股权交易
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 股权交易ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equityTradingFrm frm = new equityTradingFrm(this);
            frm.ShowDialog();

        }

        /// <summary>
        /// 生意转让
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 生意转让ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            businessTransfer frm = new businessTransfer(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// 房产投资
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 房产投资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyInvestmentFrm frm = new propertyInvestmentFrm(this);
            frm.ShowDialog();

        }

        /// <summary>
        /// 加盟代理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 加盟代理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            franchiseAgent frm = new franchiseAgent(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// 干股纳才
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 干股纳才ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ganguSatisfiedBefore frm = new ganguSatisfiedBefore(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// 刷新list数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //加载数据
            this.getList();
        }

        /// <summary>
        /// 其他
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otherFrm frm = new otherFrm(this);
            frm.ShowDialog();
        }

        /// <summary>
        /// 刷新table数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.getTable();
        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forMian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// 删除发布信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                int tt = sql.setdelelte(id);
                if (tt != -1)
                {
                    MessageBox.Show("删除成功！");
                    this.getList();
                }
                else
                {
                    MessageBox.Show("删除失败,出现错误了！");
                }
            }
            else {
                MessageBox.Show("请选中要删除的数据！");
            }

        }

    }
}
