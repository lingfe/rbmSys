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
            //调用初始化
            this.chushihua();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void chushihua()
        {
            //管理员信息
            toolStripStatusLabel1.Text = "管理员:" + PublicField.adminName;
            toolStripStatusLabel2.Text = "管理员id：" + PublicField.adminId;

            //根据当前id获取数据
            List<ReleaseInfo> info = sql.getWhereList(" where  personalId='"+PublicField.adminId+"'");
            //加载数据
            this.getList(info);
            this.getTable();
        }

        /// <summary>
        /// list数据
        /// </summary>
        public void getList(List<ReleaseInfo> info) {
            //list数据
            listView1.Items.Clear();
            if (info == null) {
                info = sql.getList();
            }
            string r_df = "";
            foreach (ReleaseInfo fo in info)
            {
                ListViewItem lv = new ListViewItem(fo.Id);          //0.编号
                lv.SubItems.Add(fo.PersonalId);                     //发布者
                lv.SubItems.Add(fo.ReleaseType);                    //1.发布类型

                if (fo.Staticstr == 0) r_df = "显示中";
                else if (fo.Staticstr == 1) r_df = "已下架";
                else if (fo.Staticstr == 2) r_df = "未发布";
                else if (fo.Staticstr == 4) r_df = "审核中";
                else if (fo.Staticstr == 5) r_df = "未通过";
                lv.SubItems.Add(r_df);                              //2.状态
                
                lv.SubItems.Add(fo.Title);                          //3.标题
                lv.SubItems.Add(fo.Threshold.ToString() + "万");    //4.金额
                lv.SubItems.Add(fo.IndustryChoice);                 //5.行业
                lv.SubItems.Add(fo.FundDistribution);               //6.资金规划
                lv.SubItems.Add(fo.ProjectDescription);             //7.项目描述
                lv.SubItems.Add(fo.IncomeDescription);              //8.收益描述
                lv.SubItems.Add(fo.TeamIntroduction);               //9.团队介绍
                lv.SubItems.Add(fo.Phone);                          //10.电话号码
                lv.SubItems.Add(fo.ImageArray);                     //11.图片路径
                lv.SubItems.Add(fo.CurrentCity);                    //12.当前城市
                lv.SubItems.Add(fo.PublisherIdentity);              //13.发布人身份
                lv.SubItems.Add(fo.GeographicalPosition);           //14.地理位置
                lv.SubItems.Add(fo.OperatingArea+"平方");           //15.经营面积
                lv.SubItems.Add(fo.MonthlyRent+"元/月");            //16.每月租金
                lv.SubItems.Add(fo.BusinessDescription);            //17.营业描述
                lv.SubItems.Add(fo.TransferReason);                 //18.转让原因
                lv.SubItems.Add(fo.ThrowInTheCity);                 //19.投放城市
                lv.SubItems.Add(fo.HeadquartersLocation);           //20.总部位置
                lv.SubItems.Add(fo.ResourceRequirements);           //21.能力要求
                lv.SubItems.Add(fo.ShareDivision);                  //22.出售股份，股份划分
                lv.SubItems.Add("");                  //23.
                lv.SubItems.Add("");                  //24.
                lv.SubItems.Add("");                  //25.
                lv.SubItems.Add("");                  //26.
                lv.SubItems.Add("");                    //27


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
            this.getList(null);
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
                    this.getList(null);
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

        /// <summary>
        /// 发布类型筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string releaseType = tool_releaseType.Text;
            if (releaseType != "全部类型")
            {
                List<ReleaseInfo> info = sql.getWhereList("where releaseType='" + releaseType + "'");
                this.getList(info);
            }
            else {
                this.getList(null);
            }
            
        }

        /// <summary>
        /// 根据状态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string df = tool_df.Text;
            if (df != "全部状态")
            {
                int r_df = 0;
                if (df == "显示中") r_df = 0;
                else if (df == "已下架") r_df =1;
                else if (df == "未发布") r_df = 2;
                else if (df == "审核中") r_df = 4;
                else if (df == "未通过") r_df = 5;

                List<ReleaseInfo> info = sql.getWhereList("where static=" + r_df + "");
                this.getList(info);
            }
            else {
                this.getList(null);
            }
        }

        /// <summary>
        /// 根据行业筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_industryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string industryChoice = tool_industryChoice.Text;
            if (industryChoice != "全部行业")
            {
                List<ReleaseInfo> info = sql.getWhereList("where industryChoice='" + industryChoice + "'");
                this.getList(info);
            }
            else
            {
                this.getList(null);
            }
        }

        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("该功能暂未开通!");
            List<ReleaseInfo> infoList = sql.getWhereList(string.Format("where title like  '%{0}%'", txt_seachKey.Text));
            this.getList(infoList);
            MessageBox.Show("共找到" + infoList.Count + "条信息!");
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Toexamine_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string releaseType = listView1.SelectedItems[0].SubItems[2].Text;

                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text!="审核中"){
                    MessageBox.Show("该状态不属于审核范围!");
                    return;
                }

                //判断发布类型
                if (releaseType == "合伙创业") {
                    partnershipFrm frm = new partnershipFrm(id,this);
                    frm.ShowDialog();                    
                }
                else if (releaseType == "干股纳才")
                {
                    ganguSatisfiedBefore frm = new ganguSatisfiedBefore(id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "加盟代理")
                {
                    franchiseAgent frm = new franchiseAgent(id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "股权交易")
                {
                    equityTradingFrm frm = new equityTradingFrm(id, this);
                    frm.ShowDialog();
                }
                else if (releaseType == "生意转让")
                {
                    businessTransfer frm = new businessTransfer(id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "金融理财")
                {
                    MessageBox.Show("该类型的审核暂未完成!正在开发中.."); return;
                }
                else if (releaseType == "房产投资")
                {
                    propertyInvestmentFrm frm = new propertyInvestmentFrm(id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "其他")
                {
                    otherFrm frm = new otherFrm(id, this);
                    frm.ShowDialog();
                }
            }
            else {
                MessageBox.Show("请选择你要审核的数据");
            }

        }

        /// <summary>
        /// 通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adopt_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;

                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text!="审核中"){
                    MessageBox.Show("该状态不属于审核范围!");
                    return;
                }

                //执行修改状态
                sql.setWhereDF(0, id);
                List<ReleaseInfo> info = sql.getWhereList("where id='" + id + "'");
                this.getList(info);
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 不通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Notpass_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;

                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text != "审核中")
                {
                    MessageBox.Show("该状态不属于审核范围!");
                    return;
                }

                //执行修改状态
                sql.setWhereDF(5, id);
                List<ReleaseInfo> info = sql.getWhereList("where id='" + id + "'");
                this.getList(info);
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 下架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lower_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text != "显示中")
                {
                    MessageBox.Show("该状态不允许下架!");
                    return;
                }
                //执行修改状态
                sql.setWhereDF(1, id);
                List<ReleaseInfo> info = sql.getWhereList("where id='" + id + "'");
                this.getList(info);
                MessageBox.Show("已下架！");
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 上架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_upper_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text != "已下架")
                {
                    MessageBox.Show("该状态不允许上架!");
                    return;
                }
                //执行修改状态
                sql.setWhereDF(0, id);
                List<ReleaseInfo> info = sql.getWhereList("where id='" + id + "'");
                this.getList(info);
                MessageBox.Show("已上架！");
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string releaseType = listView1.SelectedItems[0].SubItems[2].Text;
                //判断状态
                if (listView1.SelectedItems[0].SubItems[3].Text == "显示中" || listView1.SelectedItems[0].SubItems[3].Text == "审核中")
                {
                    MessageBox.Show("该状态不允许修改!");
                    return;
                }

                //判断发布类型
                if (releaseType == "合伙创业")
                {
                    partnershipFrm frm = new partnershipFrm("update",id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "干股纳才")
                {
                    ganguSatisfiedBefore frm = new ganguSatisfiedBefore("update",id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "加盟代理")
                {
                    franchiseAgent frm = new franchiseAgent("update",id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "股权交易")
                {
                    equityTradingFrm frm = new equityTradingFrm("update",id,this);
                    frm.ShowDialog();
                }
                else if (releaseType == "生意转让")
                {
                    //执行修改操作
                    businessTransfer frm = new businessTransfer("update", id, this);
                    frm.ShowDialog();
                }
                else if (releaseType == "金融理财")
                {
                    MessageBox.Show("该类型暂不能修改!"); return;
                }
                else if (releaseType == "房产投资")
                {
                    propertyInvestmentFrm frm = new propertyInvestmentFrm("update", id, this);
                    frm.ShowDialog();
                }
                else if (releaseType == "其他")
                {
                    otherFrm frm = new otherFrm("update",id, this);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 单个发布信息刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
             //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                DateTime mdate=DateTime.Now;
                string str = string.Format("UPDATE releaseinfo set mdate='{0}'  WHERE id='{1}'",mdate,id);
                int tt = sql.setUpdate(str);
                if (tt != -1)
                {
                    this.getList(null);
                    MessageBox.Show("刷新成功!");
                }
                else {
                    MessageBox.Show("刷新失败!");
                }
           }else
            {
                MessageBox.Show("请选择你要操作的数据");
            }

        }

        /// <summary>
        /// 点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 鼠标离开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            btn_Refresh.Visible = false;
        }

        /// <summary>
        /// 系统生成一个管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 系统生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sysAddUser sys = new sysAddUser(this);
            sys.ShowDialog();
        }

        /// <summary>
        /// 查看发布信息的帖子
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看帖子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string releaseId = listView1.SelectedItems[0].SubItems[0].Text;
                string personalId = listView1.SelectedItems[0].SubItems[1].Text;
                string imgurl = listView1.SelectedItems[0].SubItems[12].Text;
                viewPposts frm = new viewPposts(releaseId, personalId,imgurl);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 切换身份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 切换身份ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            handoffIdentityFrom frm = new handoffIdentityFrom(null,this);
            frm.ShowDialog();
        }

        /// <summary>
        /// 设为精品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zhiding_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string str = string.Format("UPDATE releaseinfo set top = 2  WHERE id='{0}'", id);
                int tt = sql.setUpdate(str);
                if (tt != -1)
                {
                    MessageBox.Show("设为精品成功!");
                }
                else
                {
                    MessageBox.Show("设为精品失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 取消设为精品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Not_zhiding_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string str = string.Format("UPDATE releaseinfo set top = 0  WHERE id='{0}'", id);
                int tt = sql.setUpdate(str);
                if (tt != -1)
                {
                    MessageBox.Show("取消设为精品成功!");
                }
                else
                {
                    MessageBox.Show("取消设为精品失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 设为官方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guanfang_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string str = string.Format("UPDATE releaseinfo set top = 1  WHERE id='{0}'", id);
                int tt = sql.setUpdate(str);
                if (tt != -1)
                {
                    MessageBox.Show("设为官方成功!");
                }
                else
                {
                    MessageBox.Show("设为官方失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        /// <summary>
        /// 取消设为官方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_not_guanfang_Click(object sender, EventArgs e)
        {
            //判断是否选择
            if (listView1.SelectedItems.Count != 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                string str = string.Format("UPDATE releaseinfo set top = 0  WHERE id='{0}'", id);
                int tt = sql.setUpdate(str);
                if (tt != -1)
                {
                    MessageBox.Show("取消设为官方成功!");
                }
                else
                {
                    MessageBox.Show("取消设为官方失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择你要操作的数据");
            }
        }

        //添加加盟
        private void 加盟ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
