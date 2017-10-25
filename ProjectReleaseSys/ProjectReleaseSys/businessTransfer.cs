using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectReleaseSys
{
    public partial class businessTransfer : Form
    {
        public businessTransfer()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 主窗体对象
        /// </summary>
        forMian mian=null;
        public businessTransfer(forMian mian)
        {
            InitializeComponent();
            this.mian = mian;
        }

        /// <summary>
        /// 执行修改的命令
        /// </summary>
        string update = null;
        public businessTransfer(string update, string id, forMian mian)
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
        public businessTransfer(string id, forMian mian)
        {
            this.id = id;
            this.mian = mian;
            InitializeComponent();
        }

        /// <summary>
        /// 定义数据服务对象
        /// </summary>
        ReleaseInfoSql sql = new ReleaseInfoSql();

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
                List<ReleaseInfo> info = sql.getWhereList("where id='" + this.id + "'");
                this.mian.getList(info);
                this.Close();
                return;
            }

            txt_title.Text = "";
            txt_threshold.Text = "";
            txt_operatingArea.Text = "";
            txt_geographicalPosition.Text = "";
            txt_transferReason.Text = "";
            cob_industryChoice.SelectedIndex = 0;
            txt_businessDescription.Text = "";
            txt_phone.Text = "";
            txt_imageArray.Text = "";

            lbl_ImgNuber.Text = "总数量:0";
            lab_diji.Text = "第0张";
            imageList1.Images.Clear();

        }

        int df = 0;
        /// <summary>
        /// 发布生意转让
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
                List<ReleaseInfo> info = sql.getWhereList("where id='" + this.id + "'");
                this.mian.getList(info);
                this.Close();
                return;
            }
            else {

                //实例化实体对象
                ReleaseInfo fo = new ReleaseInfo();
                //验证非空
                if (!this.getIsNull(fo)) return;

                //一句话即可，但此时id中有“-”符号存在，使用下面语句可变为纯字母+数字。
                //赋值
                fo.Id = System.Guid.NewGuid().ToString("N");
                fo.PersonalId = PublicField.adminId;
                fo.ReleaseType = "生意转让";
                fo.CurrentCity = PublicField.address;          //默认贵阳
                fo.Df = this.df;                               //默认正常显示
                fo.Cdate = DateTime.Now;
                fo.Mdate = fo.Cdate;
                fo.Creator = fo.PersonalId;
                fo.Uman = fo.PersonalId;
                //调用
                int tt=sql.setInsert(fo);
                if (tt != -1)
                { 
                    //判断id,update是否为空
                    if (!string.IsNullOrWhiteSpace(this.id) && !string.IsNullOrWhiteSpace(this.update))
                    {
                        MessageBox.Show("修改成功！");
                        //删除原始数据
                        sql.setdelelte(this.id);
                    }
                    else {
                        MessageBox.Show("发布成功！");
                    }
                    
                    this.btn_clear_Click(sender, e);
                    //刷新主窗体数据
                    if (this.mian != null) this.mian.getList(null);
                }
                else
                {
                    MessageBox.Show("发布失败,发生异常！！！");
                }
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
                MessageBox.Show("转让门槛不能为空!");
                return false;
            }
            fo.Threshold = txt_threshold.Text;
            if (string.IsNullOrWhiteSpace(txt_monthlyRent.Text))
            {
                MessageBox.Show("每月租金不能为空!");
                return false;
            }
            fo.MonthlyRent = txt_monthlyRent.Text;
            if (string.IsNullOrWhiteSpace(txt_geographicalPosition.Text))
            {
                MessageBox.Show("地理位置不能为空!");
                return false;
            }
            fo.GeographicalPosition = txt_geographicalPosition.Text;
            if (string.IsNullOrWhiteSpace(txt_operatingArea.Text))
            {
                MessageBox.Show("店铺面积不能为空!");
                return false;
            }
            fo.OperatingArea = txt_operatingArea.Text;
            fo.PublisherIdentity = radioButton1.Checked == true ? "个人" : "经纪人";
            if (string.IsNullOrWhiteSpace(txt_businessDescription.Text))
            {
                MessageBox.Show("营业描述不能为空!");
                return false;
            }
            fo.BusinessDescription = txt_businessDescription.Text;
            fo.IndustryChoice = cob_industryChoice.Text;
            if (string.IsNullOrWhiteSpace(txt_transferReason.Text))
            {
                MessageBox.Show("转让原因不能为空!");
                return false;
            }
            fo.TransferReason = txt_transferReason.Text;
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
            fo.ImageArray = txt_imageArray.Text.Substring(0,txt_imageArray.Text.Length-1);

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
            int tt=(txt_imageArray.Text.Split(',').Length-1);
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
                    if (str!= null) {
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
        private void timer1_Tick_1(object sender, EventArgs e)
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
            }else{
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
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void businessTransfer_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            cob_industryChoice.SelectedIndex = 0;
            cob_City.SelectedText = PublicField.address;
            //判断id,update是否为空
            if (!string.IsNullOrWhiteSpace(this.id)&&!string.IsNullOrWhiteSpace(this.update)) {
                btn_ok.Text = "修改";
                timer1.Interval = 2500;
                //根据id得到数据
                List<ReleaseInfo> infoList = sql.getWhereList("where id='" + this.id + "'");
                foreach (ReleaseInfo info in infoList)
                {
                    this.df = info.Df;
                    txt_title.Text = info.Title;
                    cob_City.Text = info.CurrentCity;
                    txt_threshold.Text = info.Threshold.ToString();
                    txt_phone.Text = info.Phone;
                    txt_operatingArea.Text = info.OperatingArea;
                    txt_monthlyRent.Text = info.MonthlyRent;
                    if (info.PublisherIdentity == "个人") radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                    txt_imageArray.Text = info.ImageArray;
                    //设置获取图片数量
                    lbl_ImgNuber.Text = "总共：" + (txt_imageArray.Text.Split(',').Length) + "张";
                    txt_geographicalPosition.Text = info.GeographicalPosition;
                    txt_geographicalPosition.ReadOnly = true;
                    txt_businessDescription.Text = info.BusinessDescription;
                    txt_transferReason.Text = info.TransferReason;
                    cob_industryChoice.Text = info.IndustryChoice;
                }
            }//判断id是否为空
            else if (!string.IsNullOrWhiteSpace(this.id)) {
                btn_clear.Text = "通过";
                btn_ok.Text = "不通过";
                timer1.Interval = 2500;
                //根据id得到数据
                List<ReleaseInfo> infoList= sql.getWhereList("where id='"+this.id+"'");
                foreach (ReleaseInfo info in infoList) {
                    txt_title.Text = info.Title;
                    txt_title.ReadOnly = true;

                    cob_City.Text = info.CurrentCity;
                    cob_City.Enabled = false;

                    txt_threshold.Text = info.Threshold.ToString();
                    txt_threshold.ReadOnly = true;

                    txt_phone.Text = info.Phone;
                    txt_phone.ReadOnly = true;

                    txt_operatingArea.Text = info.OperatingArea;
                    txt_operatingArea.ReadOnly = true;

                    txt_monthlyRent.Text = info.MonthlyRent;
                    txt_monthlyRent.ReadOnly = true;

                    if (info.PublisherIdentity == "个人") radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;

                    txt_imageArray.Text = info.ImageArray;
                    //设置获取图片数量
                    lbl_ImgNuber.Text = "总共：" + (txt_imageArray.Text.Split(',').Length) + "张";
                    button1.Enabled = false;

                    txt_geographicalPosition.Text = info.GeographicalPosition;
                    txt_geographicalPosition.ReadOnly = true;

                    txt_businessDescription.Text = info.BusinessDescription;
                    txt_businessDescription.ReadOnly = true;

                    txt_transferReason.Text = info.TransferReason;
                    txt_transferReason.ReadOnly = true;
                    cob_industryChoice.Text = info.IndustryChoice;
                    cob_industryChoice.Enabled = false;
                }
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
