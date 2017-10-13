namespace ProjectReleaseSys
{
    partial class equityTradingFrm
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
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_teamIntroduction = new System.Windows.Forms.TextBox();
            this.lab_teamIntroduction = new System.Windows.Forms.Label();
            this.txt_incomeDescription = new System.Windows.Forms.TextBox();
            this.lab_incomeDescription = new System.Windows.Forms.Label();
            this.txt_projectDescription = new System.Windows.Forms.TextBox();
            this.lab_projectDescription = new System.Windows.Forms.Label();
            this.txt_geographicalPosition = new System.Windows.Forms.TextBox();
            this.lab_geographicalPosition = new System.Windows.Forms.Label();
            this.lab_industryChoice = new System.Windows.Forms.Label();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.lab_threshold = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_shareDivision = new System.Windows.Forms.Label();
            this.txt_shareDivision = new System.Windows.Forms.TextBox();
            this.lab_operatingArea = new System.Windows.Forms.Label();
            this.txt_operatingArea = new System.Windows.Forms.TextBox();
            this.lab_transferReason = new System.Windows.Forms.Label();
            this.txt_transferReason = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ImgNuber = new System.Windows.Forms.Label();
            this.lab_diji = new System.Windows.Forms.Label();
            this.txt_imageArray = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_imageArray = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cob_City = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(399, 808);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 24;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(208, 808);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 23;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(29, 808);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cob_industryChoice
            // 
            this.cob_industryChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_industryChoice.FormattingEnabled = true;
            this.cob_industryChoice.Items.AddRange(new object[] {
            "餐饮",
            "休闲娱乐",
            "旅游酒店",
            "互联网",
            "传媒",
            "教育",
            "装修",
            "生活服务",
            "百货",
            "医疗保健",
            "美容美发",
            "汽车",
            "地产",
            "金融",
            "其他"});
            this.cob_industryChoice.Location = new System.Drawing.Point(144, 146);
            this.cob_industryChoice.Name = "cob_industryChoice";
            this.cob_industryChoice.Size = new System.Drawing.Size(348, 20);
            this.cob_industryChoice.TabIndex = 21;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(144, 534);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(348, 21);
            this.txt_phone.TabIndex = 19;
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Location = new System.Drawing.Point(45, 537);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_phone.TabIndex = 9;
            this.lab_phone.Text = "电话号码:";
            // 
            // txt_teamIntroduction
            // 
            this.txt_teamIntroduction.Location = new System.Drawing.Point(144, 457);
            this.txt_teamIntroduction.Multiline = true;
            this.txt_teamIntroduction.Name = "txt_teamIntroduction";
            this.txt_teamIntroduction.Size = new System.Drawing.Size(348, 71);
            this.txt_teamIntroduction.TabIndex = 17;
            // 
            // lab_teamIntroduction
            // 
            this.lab_teamIntroduction.AutoSize = true;
            this.lab_teamIntroduction.Location = new System.Drawing.Point(45, 460);
            this.lab_teamIntroduction.Name = "lab_teamIntroduction";
            this.lab_teamIntroduction.Size = new System.Drawing.Size(59, 12);
            this.lab_teamIntroduction.TabIndex = 11;
            this.lab_teamIntroduction.Text = "团队介绍:";
            // 
            // txt_incomeDescription
            // 
            this.txt_incomeDescription.Location = new System.Drawing.Point(144, 303);
            this.txt_incomeDescription.Multiline = true;
            this.txt_incomeDescription.Name = "txt_incomeDescription";
            this.txt_incomeDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_incomeDescription.TabIndex = 16;
            // 
            // lab_incomeDescription
            // 
            this.lab_incomeDescription.AutoSize = true;
            this.lab_incomeDescription.Location = new System.Drawing.Point(45, 306);
            this.lab_incomeDescription.Name = "lab_incomeDescription";
            this.lab_incomeDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_incomeDescription.TabIndex = 12;
            this.lab_incomeDescription.Text = "收益描述:";
            // 
            // txt_projectDescription
            // 
            this.txt_projectDescription.Location = new System.Drawing.Point(144, 226);
            this.txt_projectDescription.Multiline = true;
            this.txt_projectDescription.Name = "txt_projectDescription";
            this.txt_projectDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_projectDescription.TabIndex = 15;
            // 
            // lab_projectDescription
            // 
            this.lab_projectDescription.AutoSize = true;
            this.lab_projectDescription.Location = new System.Drawing.Point(45, 229);
            this.lab_projectDescription.Name = "lab_projectDescription";
            this.lab_projectDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_projectDescription.TabIndex = 10;
            this.lab_projectDescription.Text = "项目描述:";
            // 
            // txt_geographicalPosition
            // 
            this.txt_geographicalPosition.Location = new System.Drawing.Point(144, 172);
            this.txt_geographicalPosition.Name = "txt_geographicalPosition";
            this.txt_geographicalPosition.Size = new System.Drawing.Size(348, 21);
            this.txt_geographicalPosition.TabIndex = 14;
            // 
            // lab_geographicalPosition
            // 
            this.lab_geographicalPosition.AutoSize = true;
            this.lab_geographicalPosition.Location = new System.Drawing.Point(45, 175);
            this.lab_geographicalPosition.Name = "lab_geographicalPosition";
            this.lab_geographicalPosition.Size = new System.Drawing.Size(59, 12);
            this.lab_geographicalPosition.TabIndex = 7;
            this.lab_geographicalPosition.Text = "地理位置:";
            // 
            // lab_industryChoice
            // 
            this.lab_industryChoice.AutoSize = true;
            this.lab_industryChoice.Location = new System.Drawing.Point(45, 148);
            this.lab_industryChoice.Name = "lab_industryChoice";
            this.lab_industryChoice.Size = new System.Drawing.Size(59, 12);
            this.lab_industryChoice.TabIndex = 6;
            this.lab_industryChoice.Text = "行业选择:";
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(144, 92);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(348, 21);
            this.txt_threshold.TabIndex = 13;
            // 
            // lab_threshold
            // 
            this.lab_threshold.AutoSize = true;
            this.lab_threshold.Location = new System.Drawing.Point(45, 95);
            this.lab_threshold.Name = "lab_threshold";
            this.lab_threshold.Size = new System.Drawing.Size(59, 12);
            this.lab_threshold.TabIndex = 5;
            this.lab_threshold.Text = "出售金额:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(144, 31);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(348, 21);
            this.txt_title.TabIndex = 20;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(69, 34);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(35, 12);
            this.lab_title.TabIndex = 4;
            this.lab_title.Text = "标题:";
            // 
            // lab_shareDivision
            // 
            this.lab_shareDivision.AutoSize = true;
            this.lab_shareDivision.Location = new System.Drawing.Point(45, 122);
            this.lab_shareDivision.Name = "lab_shareDivision";
            this.lab_shareDivision.Size = new System.Drawing.Size(59, 12);
            this.lab_shareDivision.TabIndex = 5;
            this.lab_shareDivision.Text = "出售股份:";
            // 
            // txt_shareDivision
            // 
            this.txt_shareDivision.Location = new System.Drawing.Point(144, 119);
            this.txt_shareDivision.Name = "txt_shareDivision";
            this.txt_shareDivision.Size = new System.Drawing.Size(348, 21);
            this.txt_shareDivision.TabIndex = 13;
            // 
            // lab_operatingArea
            // 
            this.lab_operatingArea.AutoSize = true;
            this.lab_operatingArea.Location = new System.Drawing.Point(45, 202);
            this.lab_operatingArea.Name = "lab_operatingArea";
            this.lab_operatingArea.Size = new System.Drawing.Size(59, 12);
            this.lab_operatingArea.TabIndex = 7;
            this.lab_operatingArea.Text = "项目面积:";
            // 
            // txt_operatingArea
            // 
            this.txt_operatingArea.Location = new System.Drawing.Point(144, 199);
            this.txt_operatingArea.Name = "txt_operatingArea";
            this.txt_operatingArea.Size = new System.Drawing.Size(348, 21);
            this.txt_operatingArea.TabIndex = 14;
            // 
            // lab_transferReason
            // 
            this.lab_transferReason.AutoSize = true;
            this.lab_transferReason.Location = new System.Drawing.Point(45, 383);
            this.lab_transferReason.Name = "lab_transferReason";
            this.lab_transferReason.Size = new System.Drawing.Size(59, 12);
            this.lab_transferReason.TabIndex = 12;
            this.lab_transferReason.Text = "转让原因:";
            // 
            // txt_transferReason
            // 
            this.txt_transferReason.Location = new System.Drawing.Point(144, 380);
            this.txt_transferReason.Multiline = true;
            this.txt_transferReason.Name = "txt_transferReason";
            this.txt_transferReason.Size = new System.Drawing.Size(348, 71);
            this.txt_transferReason.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(304, 586);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ImgNuber
            // 
            this.lbl_ImgNuber.AutoSize = true;
            this.lbl_ImgNuber.Location = new System.Drawing.Point(302, 565);
            this.lbl_ImgNuber.Name = "lbl_ImgNuber";
            this.lbl_ImgNuber.Size = new System.Drawing.Size(53, 12);
            this.lbl_ImgNuber.TabIndex = 63;
            this.lbl_ImgNuber.Text = "总数量:0";
            // 
            // lab_diji
            // 
            this.lab_diji.AutoSize = true;
            this.lab_diji.Location = new System.Drawing.Point(413, 565);
            this.lab_diji.Name = "lab_diji";
            this.lab_diji.Size = new System.Drawing.Size(35, 12);
            this.lab_diji.TabIndex = 64;
            this.lab_diji.Text = "第0张";
            // 
            // txt_imageArray
            // 
            this.txt_imageArray.Location = new System.Drawing.Point(144, 561);
            this.txt_imageArray.Multiline = true;
            this.txt_imageArray.Name = "txt_imageArray";
            this.txt_imageArray.ReadOnly = true;
            this.txt_imageArray.Size = new System.Drawing.Size(152, 206);
            this.txt_imageArray.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_imageArray
            // 
            this.lab_imageArray.AutoSize = true;
            this.lab_imageArray.Location = new System.Drawing.Point(45, 564);
            this.lab_imageArray.Name = "lab_imageArray";
            this.lab_imageArray.Size = new System.Drawing.Size(59, 12);
            this.lab_imageArray.TabIndex = 60;
            this.lab_imageArray.Text = "图片路径:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cob_City
            // 
            this.cob_City.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cob_City.FormattingEnabled = true;
            this.cob_City.Items.AddRange(new object[] {
            "成都",
            "重庆",
            "贵阳",
            "昆明",
            "南宁",
            "广州",
            "深圳",
            "遵义"});
            this.cob_City.Location = new System.Drawing.Point(469, 5);
            this.cob_City.Name = "cob_City";
            this.cob_City.Size = new System.Drawing.Size(55, 20);
            this.cob_City.TabIndex = 66;
            this.cob_City.SelectedIndexChanged += new System.EventHandler(this.cob_City_SelectedIndexChanged);
            // 
            // equityTradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 853);
            this.Controls.Add(this.cob_City);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ImgNuber);
            this.Controls.Add(this.lab_diji);
            this.Controls.Add(this.txt_imageArray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_imageArray);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cob_industryChoice);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_teamIntroduction);
            this.Controls.Add(this.lab_teamIntroduction);
            this.Controls.Add(this.txt_transferReason);
            this.Controls.Add(this.lab_transferReason);
            this.Controls.Add(this.txt_incomeDescription);
            this.Controls.Add(this.lab_incomeDescription);
            this.Controls.Add(this.txt_projectDescription);
            this.Controls.Add(this.lab_projectDescription);
            this.Controls.Add(this.txt_operatingArea);
            this.Controls.Add(this.lab_operatingArea);
            this.Controls.Add(this.txt_geographicalPosition);
            this.Controls.Add(this.lab_geographicalPosition);
            this.Controls.Add(this.lab_industryChoice);
            this.Controls.Add(this.txt_shareDivision);
            this.Controls.Add(this.lab_shareDivision);
            this.Controls.Add(this.txt_threshold);
            this.Controls.Add(this.lab_threshold);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lab_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "equityTradingFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "股权交易";
            this.Load += new System.EventHandler(this.equityTradingFrm_Load);
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
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_teamIntroduction;
        private System.Windows.Forms.Label lab_teamIntroduction;
        private System.Windows.Forms.TextBox txt_incomeDescription;
        private System.Windows.Forms.Label lab_incomeDescription;
        private System.Windows.Forms.TextBox txt_projectDescription;
        private System.Windows.Forms.Label lab_projectDescription;
        private System.Windows.Forms.TextBox txt_geographicalPosition;
        private System.Windows.Forms.Label lab_geographicalPosition;
        private System.Windows.Forms.Label lab_industryChoice;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.Label lab_threshold;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_shareDivision;
        private System.Windows.Forms.TextBox txt_shareDivision;
        private System.Windows.Forms.Label lab_operatingArea;
        private System.Windows.Forms.TextBox txt_operatingArea;
        private System.Windows.Forms.Label lab_transferReason;
        private System.Windows.Forms.TextBox txt_transferReason;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ImgNuber;
        private System.Windows.Forms.Label lab_diji;
        private System.Windows.Forms.TextBox txt_imageArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_imageArray;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cob_City;

    }
}