namespace ProjectReleaseSys
{
    partial class businessTransfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cob_industryChoice = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_imageArray = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_transferReason = new System.Windows.Forms.TextBox();
            this.lab_transferReason = new System.Windows.Forms.Label();
            this.txt_businessDescription = new System.Windows.Forms.TextBox();
            this.lab_businessDescription = new System.Windows.Forms.Label();
            this.lab_projectDescription = new System.Windows.Forms.Label();
            this.txt_operatingArea = new System.Windows.Forms.TextBox();
            this.lab_operatingArea = new System.Windows.Forms.Label();
            this.txt_geographicalPosition = new System.Windows.Forms.TextBox();
            this.lab_geographicalPosition = new System.Windows.Forms.Label();
            this.lab_industryChoice = new System.Windows.Forms.Label();
            this.txt_monthlyRent = new System.Windows.Forms.TextBox();
            this.lab_monthlyRent = new System.Windows.Forms.Label();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.lab_threshold = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ImgNuber = new System.Windows.Forms.Label();
            this.lab_diji = new System.Windows.Forms.Label();
            this.txt_imageArray = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(399, 722);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 51;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(208, 722);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 50;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(47, 722);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cob_industryChoice
            // 
            this.cob_industryChoice.FormattingEnabled = true;
            this.cob_industryChoice.Items.AddRange(new object[] {
            "餐饮",
            "休闲娱乐",
            "旅游与酒店",
            "美发美容",
            "教育",
            "服饰鞋包",
            "生活服务",
            "汽车",
            "地产",
            "金融",
            "家装建材",
            "百货超市",
            "医疗保健",
            "建筑工程",
            "工厂",
            "其他"});
            this.cob_industryChoice.Location = new System.Drawing.Point(144, 157);
            this.cob_industryChoice.Name = "cob_industryChoice";
            this.cob_industryChoice.Size = new System.Drawing.Size(348, 20);
            this.cob_industryChoice.TabIndex = 48;
            this.cob_industryChoice.Text = "其他";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(144, 425);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(348, 21);
            this.txt_phone.TabIndex = 46;
            // 
            // lab_imageArray
            // 
            this.lab_imageArray.AutoSize = true;
            this.lab_imageArray.Location = new System.Drawing.Point(45, 455);
            this.lab_imageArray.Name = "lab_imageArray";
            this.lab_imageArray.Size = new System.Drawing.Size(59, 12);
            this.lab_imageArray.TabIndex = 31;
            this.lab_imageArray.Text = "图片路径:";
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Location = new System.Drawing.Point(45, 428);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_phone.TabIndex = 32;
            this.lab_phone.Text = "电话号码:";
            // 
            // txt_transferReason
            // 
            this.txt_transferReason.Location = new System.Drawing.Point(144, 348);
            this.txt_transferReason.Multiline = true;
            this.txt_transferReason.Name = "txt_transferReason";
            this.txt_transferReason.Size = new System.Drawing.Size(348, 71);
            this.txt_transferReason.TabIndex = 43;
            // 
            // lab_transferReason
            // 
            this.lab_transferReason.AutoSize = true;
            this.lab_transferReason.Location = new System.Drawing.Point(45, 351);
            this.lab_transferReason.Name = "lab_transferReason";
            this.lab_transferReason.Size = new System.Drawing.Size(59, 12);
            this.lab_transferReason.TabIndex = 35;
            this.lab_transferReason.Text = "转让原因:";
            // 
            // txt_businessDescription
            // 
            this.txt_businessDescription.Location = new System.Drawing.Point(144, 271);
            this.txt_businessDescription.Multiline = true;
            this.txt_businessDescription.Name = "txt_businessDescription";
            this.txt_businessDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_businessDescription.TabIndex = 42;
            // 
            // lab_businessDescription
            // 
            this.lab_businessDescription.AutoSize = true;
            this.lab_businessDescription.Location = new System.Drawing.Point(45, 274);
            this.lab_businessDescription.Name = "lab_businessDescription";
            this.lab_businessDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_businessDescription.TabIndex = 36;
            this.lab_businessDescription.Text = "营业描述:";
            // 
            // lab_projectDescription
            // 
            this.lab_projectDescription.AutoSize = true;
            this.lab_projectDescription.Location = new System.Drawing.Point(45, 244);
            this.lab_projectDescription.Name = "lab_projectDescription";
            this.lab_projectDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_projectDescription.TabIndex = 33;
            this.lab_projectDescription.Text = "发布身份:";
            // 
            // txt_operatingArea
            // 
            this.txt_operatingArea.Location = new System.Drawing.Point(144, 210);
            this.txt_operatingArea.Name = "txt_operatingArea";
            this.txt_operatingArea.Size = new System.Drawing.Size(348, 21);
            this.txt_operatingArea.TabIndex = 39;
            // 
            // lab_operatingArea
            // 
            this.lab_operatingArea.AutoSize = true;
            this.lab_operatingArea.Location = new System.Drawing.Point(45, 213);
            this.lab_operatingArea.Name = "lab_operatingArea";
            this.lab_operatingArea.Size = new System.Drawing.Size(59, 12);
            this.lab_operatingArea.TabIndex = 30;
            this.lab_operatingArea.Text = "店铺面积:";
            // 
            // txt_geographicalPosition
            // 
            this.txt_geographicalPosition.Location = new System.Drawing.Point(144, 183);
            this.txt_geographicalPosition.Name = "txt_geographicalPosition";
            this.txt_geographicalPosition.Size = new System.Drawing.Size(348, 21);
            this.txt_geographicalPosition.TabIndex = 40;
            // 
            // lab_geographicalPosition
            // 
            this.lab_geographicalPosition.AutoSize = true;
            this.lab_geographicalPosition.Location = new System.Drawing.Point(45, 186);
            this.lab_geographicalPosition.Name = "lab_geographicalPosition";
            this.lab_geographicalPosition.Size = new System.Drawing.Size(59, 12);
            this.lab_geographicalPosition.TabIndex = 29;
            this.lab_geographicalPosition.Text = "地理位置:";
            // 
            // lab_industryChoice
            // 
            this.lab_industryChoice.AutoSize = true;
            this.lab_industryChoice.Location = new System.Drawing.Point(45, 159);
            this.lab_industryChoice.Name = "lab_industryChoice";
            this.lab_industryChoice.Size = new System.Drawing.Size(59, 12);
            this.lab_industryChoice.TabIndex = 28;
            this.lab_industryChoice.Text = "行业选择:";
            // 
            // txt_monthlyRent
            // 
            this.txt_monthlyRent.Location = new System.Drawing.Point(144, 130);
            this.txt_monthlyRent.Name = "txt_monthlyRent";
            this.txt_monthlyRent.Size = new System.Drawing.Size(348, 21);
            this.txt_monthlyRent.TabIndex = 37;
            // 
            // lab_monthlyRent
            // 
            this.lab_monthlyRent.AutoSize = true;
            this.lab_monthlyRent.Location = new System.Drawing.Point(45, 133);
            this.lab_monthlyRent.Name = "lab_monthlyRent";
            this.lab_monthlyRent.Size = new System.Drawing.Size(59, 12);
            this.lab_monthlyRent.TabIndex = 27;
            this.lab_monthlyRent.Text = "每月租金:";
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(144, 103);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(348, 21);
            this.txt_threshold.TabIndex = 38;
            // 
            // lab_threshold
            // 
            this.lab_threshold.AutoSize = true;
            this.lab_threshold.Location = new System.Drawing.Point(45, 106);
            this.lab_threshold.Name = "lab_threshold";
            this.lab_threshold.Size = new System.Drawing.Size(59, 12);
            this.lab_threshold.TabIndex = 26;
            this.lab_threshold.Text = "转让门槛:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(144, 42);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(348, 21);
            this.txt_title.TabIndex = 47;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(69, 45);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(35, 12);
            this.lab_title.TabIndex = 25;
            this.lab_title.Text = "标题:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(144, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 28);
            this.panel1.TabIndex = 52;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "经纪人";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "个人";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(304, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ImgNuber
            // 
            this.lbl_ImgNuber.AutoSize = true;
            this.lbl_ImgNuber.Location = new System.Drawing.Point(302, 456);
            this.lbl_ImgNuber.Name = "lbl_ImgNuber";
            this.lbl_ImgNuber.Size = new System.Drawing.Size(53, 12);
            this.lbl_ImgNuber.TabIndex = 55;
            this.lbl_ImgNuber.Text = "总数量:0";
            // 
            // lab_diji
            // 
            this.lab_diji.AutoSize = true;
            this.lab_diji.Location = new System.Drawing.Point(413, 456);
            this.lab_diji.Name = "lab_diji";
            this.lab_diji.Size = new System.Drawing.Size(35, 12);
            this.lab_diji.TabIndex = 56;
            this.lab_diji.Text = "第0张";
            // 
            // txt_imageArray
            // 
            this.txt_imageArray.Location = new System.Drawing.Point(144, 452);
            this.txt_imageArray.Multiline = true;
            this.txt_imageArray.Name = "txt_imageArray";
            this.txt_imageArray.Size = new System.Drawing.Size(152, 206);
            this.txt_imageArray.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // businessTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 794);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ImgNuber);
            this.Controls.Add(this.lab_diji);
            this.Controls.Add(this.txt_imageArray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cob_industryChoice);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_imageArray);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_transferReason);
            this.Controls.Add(this.lab_transferReason);
            this.Controls.Add(this.txt_businessDescription);
            this.Controls.Add(this.lab_businessDescription);
            this.Controls.Add(this.lab_projectDescription);
            this.Controls.Add(this.txt_operatingArea);
            this.Controls.Add(this.lab_operatingArea);
            this.Controls.Add(this.txt_geographicalPosition);
            this.Controls.Add(this.lab_geographicalPosition);
            this.Controls.Add(this.lab_industryChoice);
            this.Controls.Add(this.txt_monthlyRent);
            this.Controls.Add(this.lab_monthlyRent);
            this.Controls.Add(this.txt_threshold);
            this.Controls.Add(this.lab_threshold);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lab_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "businessTransfer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生意转让";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cob_industryChoice;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_imageArray;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_transferReason;
        private System.Windows.Forms.Label lab_transferReason;
        private System.Windows.Forms.TextBox txt_businessDescription;
        private System.Windows.Forms.Label lab_businessDescription;
        private System.Windows.Forms.Label lab_projectDescription;
        private System.Windows.Forms.TextBox txt_operatingArea;
        private System.Windows.Forms.Label lab_operatingArea;
        private System.Windows.Forms.TextBox txt_geographicalPosition;
        private System.Windows.Forms.Label lab_geographicalPosition;
        private System.Windows.Forms.Label lab_industryChoice;
        private System.Windows.Forms.TextBox txt_monthlyRent;
        private System.Windows.Forms.Label lab_monthlyRent;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.Label lab_threshold;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ImgNuber;
        private System.Windows.Forms.Label lab_diji;
        private System.Windows.Forms.TextBox txt_imageArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}