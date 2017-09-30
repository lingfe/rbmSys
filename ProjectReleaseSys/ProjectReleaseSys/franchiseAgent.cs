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
    public partial class franchiseAgent : Form
    {
        public franchiseAgent()
        {
            InitializeComponent();
        }

                
        forMian mian=null;
        public franchiseAgent(forMian mian)
        {
            InitializeComponent();
            this.mian = mian;
        }

        ReleaseInfoSql sql = new ReleaseInfoSql();


        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_title.Text = "";

        }

        /// <summary>
        /// 发布其他
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //实例化实体对象
            ReleaseInfo fo = new ReleaseInfo();
            //验证非空
            if (!this.getIsNull(fo)) return;
            //UUID
            //string id1 = System.Guid.NewGuid().ToString();
            //一句话即可，但此时id中有“-”符号存在，使用下面语句可变为纯字母+数字。
            string id = System.Guid.NewGuid().ToString("N");
            //赋值
            fo.Id = id;
            fo.PersonalId = PublicField.adminId;
            fo.ReleaseType = "加盟代理";
            fo.CurrentCity = "贵阳";          //默认贵阳
            fo.Df = 4;                        //默认审核中
            fo.Cdate = DateTime.Now;
            fo.Mdate = fo.Cdate;
            fo.Creator = fo.PersonalId;
            fo.Uman = fo.PersonalId;
            //调用
            int tt = sql.setInsert(fo);

            if (tt != -1)
            {
                MessageBox.Show("发布成功！");
                this.btn_clear_Click(sender, e);
                //刷新主窗体数据
                if (this.mian != null) this.mian.getList();
            }
            else {
                MessageBox.Show("发布失败,发生异常！！！");
            }
        }

        /// <summary>
        /// 验证非空
        /// </summary>
        /// <param name="fo"></param>
        /// <returns></returns>
        public bool getIsNull(ReleaseInfo fo)
        {
            if (string.IsNullOrWhiteSpace(txt_title.Text)) {
                MessageBox.Show("标题不能为空！");
                return false;
            }
            fo.Title = txt_title.Text;
            if (string.IsNullOrWhiteSpace(txt_threshold.Text)) {
                MessageBox.Show("加盟金额不能为空！");
                return false;
            }
            fo.Threshold = Convert.ToDouble(txt_threshold.Text);
            fo.IndustryChoice = cob_industryChoice.Text;
            if (string.IsNullOrWhiteSpace(txt_headquartersLocation.Text)) {
                MessageBox.Show("总部位置不能为空！");
                return false;
            }
            fo.HeadquartersLocation = txt_headquartersLocation.Text;
            if (string.IsNullOrWhiteSpace(txt_fundDistribution.Text)) {
                MessageBox.Show("资金规划不能为空！");
                return false;
            }
            fo.FundDistribution = txt_fundDistribution.Text;
            if (string.IsNullOrWhiteSpace(txt_projectDescription.Text)) {
                MessageBox.Show("项目描述不能为空！");
                return false;
            }
            fo.ProjectDescription = txt_projectDescription.Text;
            if (string.IsNullOrWhiteSpace(txt_incomeDescription.Text)) {
                MessageBox.Show("收益描述不能为空！");
                return false;
            }
            fo.IncomeDescription = txt_incomeDescription.Text;
            if (string.IsNullOrWhiteSpace(txt_teamIntroduction.Text)) {
                MessageBox.Show("团队介绍不能为空！");
                return false;
            }
            fo.TeamIntroduction = txt_teamIntroduction.Text;
            if (string.IsNullOrWhiteSpace(txt_phone.Text)) {
                MessageBox.Show("联系方式不能为空!");
                return false;
            }
            fo.Phone = txt_phone.Text;
            fo.ThrowInTheCity = cob_throwInTheCity.Text;
            if (string.IsNullOrWhiteSpace(txt_imageArray.Text)) {
                MessageBox.Show("图片路径不能为空!");
                return false;
            }
            return true;
        }
    }
}
