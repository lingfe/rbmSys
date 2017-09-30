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
        
        forMian mian=null;
        public businessTransfer(forMian mian)
        {
            InitializeComponent();
            this.mian = mian;
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
            txt_title.Text = "";
            txt_threshold.Text = "";
            txt_operatingArea.Text = "";
            txt_geographicalPosition.Text = "";
            txt_transferReason.Text = "";
            cob_industryChoice.SelectedIndex = 0;
            txt_businessDescription.Text = "";
            txt_phone.Text = "";
            txt_imageArray.Text = "";

        }

        /// <summary>
        /// 发布生意转让
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
            fo.ReleaseType = "生意转让";
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
                MessageBox.Show("转让门槛不能为空!");
                return false;
            }
            fo.Threshold = Convert.ToDouble(txt_threshold.Text);
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
            fo.PublisherIdentity = radioButton1.Text == "个人" ? "个人" : "经纪人";
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
            fo.ImageArray = txt_imageArray.Text;

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
                //设置获取图片数量
                lbl_ImgNuber.Text = "总共：" + di.FileNames.Length + "张";
                //遍历获取的图片
                for (int i = 0; i < di.FileNames.Length; ++i)
                {
                    //设置保存图片加路径
                    string safeFileName = "admin/" + di.SafeFileNames[i];
                    string fileName = di.FileNames[i];
                    //调用ftp上传
                    string str = uUtile.ftpUpload(safeFileName, fileName);
                    if (str!= null) {
                        imageList1.Images.Add(Image.FromFile(di.FileNames[i]));
                        txt_imageArray.Text += str + ",";
                    }
                }
            }

        }

        
        int tt = 0;
        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
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
}
