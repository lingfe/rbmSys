﻿using BLL;
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
    public partial class equityTradingFrm : Form
    {
        public equityTradingFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 主窗体对象
        /// </summary>
        forMian mian=null;
        public equityTradingFrm(forMian mian)
        {
            InitializeComponent();
            this.mian = mian;
        }

        /// <summary>
        /// 执行修改的命令
        /// </summary>
        string update = null;
        public equityTradingFrm(string update, string id, forMian mian)
        {
            this.update = update;
            this.id = id;
            this.mian = mian;
            InitializeComponent();
        }

        /// <summary>
        /// 发布信息id
        /// </summary>
        string id = null;
        public equityTradingFrm(string id, forMian mian)
        {
            this.id = id;
            this.mian = mian;
            InitializeComponent();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        ReleaseInfoSql sql = new ReleaseInfoSql();
        NoticeSql sqlNotice = new NoticeSql();

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //判断id是否为空
            if (!string.IsNullOrWhiteSpace(this.id) && string.IsNullOrWhiteSpace(this.update))
            {
                //执行修改状态
                sql.setWhereDF(0, this.id);

                //发送通知
                Notice ice = new Notice();
                ice.Id = System.Guid.NewGuid().ToString("N");
                ice.PersonalId = this.PersonalId;
                ice.ReleaseId = this.releaseId;
                ice.Content = "您发布的信息已经通过!";
                ice.ImgUrl = this.domainImage;
                ice.StaticStr = 0;
                ice.Ntype = "0";
                ice.AvatarUrl = PublicField.adminImg;
                ice.Uman = PublicField.adminId;
                ice.Creator = PublicField.adminId;
                ice.Cdate = DateTime.Now;
                ice.Mdate = ice.Cdate;
                ice.Notifyname = PublicField.adminName;

                //调用
                int tt = sqlNotice.setInsert(ice);

                List<ReleaseInfo> info = sql.getWhereList("where id='" + this.id + "'");
                this.mian.getList(info);
                this.Close();
                return;
            }
            txt_title.Text = "";
            txt_threshold.Text = "";
            txt_shareDivision.Text = "";
            txt_operatingArea.Text = "";
            txt_transferReason.Text = "";
            cob_industryChoice.SelectedIndex = 0;
            txt_incomeDescription.Text = "";
            txt_projectDescription.Text = "";
            txt_teamIntroduction.Text = "";
            txt_phone.Text = "";
            txt_imageArray.Text = "";

            lbl_ImgNuber.Text = "总数量:0";
            lab_diji.Text = "第0张";
            imageList1.Images.Clear();
        }

        int staticstr = 0;
        /// <summary>
        /// 发布股权交易
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //判断id是否为空
            if (!string.IsNullOrWhiteSpace(this.id) && string.IsNullOrWhiteSpace(this.update))
            {
                //执行修改状态
                sql.setWhereDF(5, this.id);
                //发送通知
                Notice ice = new Notice();
                ice.Id = System.Guid.NewGuid().ToString("N");
                ice.PersonalId = this.PersonalId;
                ice.ReleaseId = this.releaseId;
                ice.Content = "您发布的信息未通过!请检查并修改!";
                ice.ImgUrl = this.domainImage;
                ice.StaticStr = 0;
                ice.Ntype = "0";
                ice.AvatarUrl = PublicField.adminImg;
                ice.Uman = PublicField.adminId;
                ice.Creator = PublicField.adminId;
                ice.Cdate = DateTime.Now;
                ice.Mdate = ice.Cdate;
                ice.Notifyname = PublicField.adminName;
                ice.InfoType = this.InfoType;

                //调用
                sqlNotice.setInsert(ice);

                List<ReleaseInfo> info = sql.getWhereList("where id='" + this.id + "'");
                this.mian.getList(info);
                this.Close();
                return;
            }

            //实例化实体对象
            ReleaseInfo fo = new ReleaseInfo();
            //验证非空
            if (!this.getIsNull(fo)) return;

            //一句话即可，但此时id中有“-”符号存在，使用下面语句可变为纯字母+数字。
            string id = System.Guid.NewGuid().ToString("N");
            //赋值
            fo.Id = id;
            fo.PersonalId = PublicField.adminId;
            fo.ReleaseType = "股权交易";
            fo.CurrentCity = PublicField.address;          //默认贵阳
            fo.Staticstr = this.staticstr;                                     //默认正常显示
            fo.Cdate = DateTime.Now;
            fo.Mdate = fo.Cdate;
            fo.Creator = fo.PersonalId;
            fo.Uman = fo.PersonalId;
            //调用
            int tt = sql.setInsert(fo);
            if (tt != -1)
            {
                //判断id,update是否为空
                if (!string.IsNullOrWhiteSpace(this.id) && !string.IsNullOrWhiteSpace(this.update))
                {
                    MessageBox.Show("修改成功！");
                    //删除原始数据
                    sql.setdelelte(this.id);
                    List<ReleaseInfo> info = sql.getWhereList("where id='" + fo.Id + "'");
                    this.mian.getList(info);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("发布成功！");
                    List<ReleaseInfo> info = sql.getWhereList("where id='" + fo.Id + "'");
                    this.mian.getList(info);
                    this.Close();
                    return;
                }
            }
            else
            {
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

            if (string.IsNullOrWhiteSpace(txt_title.Text))
            {
                MessageBox.Show("标题不能为空!");
                return false;
            }
            fo.Title = txt_title.Text;
            if (string.IsNullOrWhiteSpace(txt_threshold.Text))
            {
                MessageBox.Show("出售金额不能为空!");
                return false;
            }
            fo.Threshold = txt_threshold.Text;
            if (string.IsNullOrWhiteSpace(txt_shareDivision.Text))
            {
                MessageBox.Show("出售股份不能为空!");
                return false;
            }
            fo.ShareDivision = txt_shareDivision.Text;
            if (string.IsNullOrWhiteSpace(txt_geographicalPosition.Text)) {
                MessageBox.Show("地理位置不能为空!");
                return false;
            }
            fo.GeographicalPosition = txt_geographicalPosition.Text;
            if (string.IsNullOrWhiteSpace(txt_operatingArea.Text))
            {
                MessageBox.Show("项目面积不能为空!");
                return false;
            }
            fo.OperatingArea = txt_operatingArea.Text;
            if (string.IsNullOrWhiteSpace(txt_projectDescription.Text))
            {
                MessageBox.Show("项目描述不能为空!");
                return false;
            }
            fo.IndustryChoice = cob_industryChoice.Text;
            if (string.IsNullOrWhiteSpace(txt_incomeDescription.Text))
            {
                MessageBox.Show("收益描述不能为空!");
                return false;
            }
            fo.ProjectDescription = txt_projectDescription.Text;
            fo.IncomeDescription = txt_incomeDescription.Text;
            if (string.IsNullOrWhiteSpace(txt_transferReason.Text)) {
                MessageBox.Show("转让原因不能为空!");
                return false;
            }
            fo.TransferReason = txt_transferReason.Text;
            if (string.IsNullOrWhiteSpace(txt_teamIntroduction.Text))
            {
                MessageBox.Show("团队介绍不能为空!");
                return false;
            }
            fo.TeamIntroduction = txt_teamIntroduction.Text;
            if (string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("电话号码不能为空!");
                return false;
            }
            fo.Phone = txt_phone.Text;
            if (string.IsNullOrWhiteSpace(txt_imageArray.Text))
            {
                MessageBox.Show("图片路径不能为空!");
                return false;
            }
            fo.ImageArray = txt_imageArray.Text.Substring(0, txt_imageArray.Text.Length - 1);

            return true;
        }

        /// <summary>
        /// 关闭当前窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        string PersonalId = "";
        string releaseId = "";
        string domainImage = "";
        string InfoType = "";
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equityTradingFrm_Load(object sender, EventArgs e)
        {
            cob_City.Text = PublicField.address;
            cob_industryChoice.SelectedIndex = 0;
            //判断id,update是否为空
            if (!string.IsNullOrWhiteSpace(this.id) && !string.IsNullOrWhiteSpace(this.update))
            {
                btn_ok.Text = "修改";
                timer1.Interval = 2500;
                //根据id得到数据
                List<ReleaseInfo> infoList = sql.getWhereList("where id='" + this.id + "'");
                foreach (ReleaseInfo info in infoList)
                {
                    this.staticstr = info.Staticstr;
                    txt_imageArray.Text = info.ImageArray;
                    //设置获取图片数量
                    lbl_ImgNuber.Text = "总共：" + (txt_imageArray.Text.Split(',').Length) + "张";
                    txt_incomeDescription.Text = info.IncomeDescription;
                    txt_phone.Text = info.Phone;
                    txt_projectDescription.Text = info.ProjectDescription;
                    txt_threshold.Text = info.Threshold.ToString();
                    txt_title.Text = info.Title;
                    cob_City.Text = info.CurrentCity;
                    cob_industryChoice.Text = info.IndustryChoice;
                    txt_geographicalPosition.Text = info.GeographicalPosition;
                    txt_operatingArea.Text = info.OperatingArea;
                    txt_shareDivision.Text = info.ShareDivision;
                    txt_transferReason.Text = info.TransferReason;
                    txt_teamIntroduction.Text = info.TeamIntroduction;
                  
                }
            }//判断id是否为空
            else if (!string.IsNullOrWhiteSpace(this.id))
            {
                btn_clear.Text = "通过";
                btn_ok.Text = "不通过";
                timer1.Interval = 2500;
                //根据id得到数据
                List<ReleaseInfo> infoList = sql.getWhereList("where id='" + this.id + "'");
                foreach (ReleaseInfo info in infoList)
                {
                    this.PersonalId = info.PersonalId;
                    this.releaseId = info.Id;
                    this.domainImage = info.ImageArray.Split(',')[0];
                    this.InfoType = info.ReleaseType;

                    txt_imageArray.Text = info.ImageArray;
                    //设置获取图片数量
                    lbl_ImgNuber.Text = "总共：" + (txt_imageArray.Text.Split(',').Length) + "张";
                    button1.Enabled = false;

                    txt_incomeDescription.Text = info.IncomeDescription;
                    txt_incomeDescription.ReadOnly = true;

                    txt_phone.Text = info.Phone;
                    txt_phone.ReadOnly = true;

                    txt_projectDescription.Text = info.ProjectDescription;
                    txt_projectDescription.ReadOnly = true;

                    txt_threshold.Text = info.Threshold.ToString();
                    txt_threshold.ReadOnly = true;

                    txt_title.Text = info.Title;
                    txt_title.ReadOnly = true;

                    cob_City.Text = info.CurrentCity;
                    cob_City.Enabled = false;

                    cob_industryChoice.Text = info.IndustryChoice;
                    cob_industryChoice.Enabled = false;

                    txt_geographicalPosition.Text = info.GeographicalPosition;
                    txt_geographicalPosition.ReadOnly = true;

                    txt_operatingArea.Text = info.OperatingArea;
                    txt_operatingArea.ReadOnly = true;

                    txt_shareDivision.Text = info.ShareDivision;
                    txt_shareDivision.ReadOnly = true;

                    txt_transferReason.Text = info.TransferReason;
                    txt_transferReason.ReadOnly=true;

                    txt_teamIntroduction.Text = info.TeamIntroduction;
                    txt_teamIntroduction.ReadOnly = true;
                }
            }
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
            int tt = (txt_imageArray.Text.Split(',').Length - 1);
            if (tt >= 6)
            {
                MessageBox.Show("已经上传了六张图片啦!不能再多啦!");
                return;
            }
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
                tt += di.FileNames.Length;
                if (tt > 6)
                {
                    MessageBox.Show("总共只能上传六张图片哦!");
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
                        imageList1.Images.Add(Image.FromFile(di.FileNames[i]));
                        txt_imageArray.Text += str + ",";
                    }
                }
            }
            //设置获取图片数量
            lbl_ImgNuber.Text = "总共：" + (imageList1.Images.Count) + "张";

        }


        int tt = 0;
        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //判断id是否为空
            if (!string.IsNullOrWhiteSpace(this.id))
            {
                string[] arr = txt_imageArray.Text.Split(',');
                if (arr.Length > tt)
                {
                    //显示图片
                    lab_diji.Text = "第" + (tt + 1) + "张";
                    string str = PublicField.domainImage + arr[tt];
                    this.pictureBox1.Image = null;
                    this.pictureBox1.WaitOnLoad = false; //设置为异步加载图片  
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.LoadAsync(str);

                    tt++;
                }
                else tt = 0;
            }
            else
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

        /// <summary>
        /// 切换城市
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cob_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            PublicField.address = cob_City.Text;
        }

    }
}
