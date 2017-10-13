namespace ProjectReleaseSys
{
    partial class ganguSatisfiedBefore
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
            this.txt_incomeDescription = new System.Windows.Forms.TextBox();
            this.lab_incomeDescription = new System.Windows.Forms.Label();
            this.txt_projectDescription = new System.Windows.Forms.TextBox();
            this.lab_projectDescription = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cob_industryChoice = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_phone = new System.Windows.Forms.Label();
            this.lab_industryChoice = new System.Windows.Forms.Label();
            this.txt_resourceRequirements = new System.Windows.Forms.TextBox();
            this.lab_resourceRequirements = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_shareDivision = new System.Windows.Forms.Label();
            this.txt_shareDivision = new System.Windows.Forms.TextBox();
            this.lab_teamIntroduction = new System.Windows.Forms.Label();
            this.txt_teamIntroduction = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ImgNuber = new System.Windows.Forms.Label();
            this.lab_diji = new System.Windows.Forms.Label();
            this.txt_imageArray = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_imageArray = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cob_City = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_incomeDescription
            // 
            this.txt_incomeDescription.Location = new System.Drawing.Point(136, 304);
            this.txt_incomeDescription.Multiline = true;
            this.txt_incomeDescription.Name = "txt_incomeDescription";
            this.txt_incomeDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_incomeDescription.TabIndex = 97;
            // 
            // lab_incomeDescription
            // 
            this.lab_incomeDescription.AutoSize = true;
            this.lab_incomeDescription.Location = new System.Drawing.Point(37, 307);
            this.lab_incomeDescription.Name = "lab_incomeDescription";
            this.lab_incomeDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_incomeDescription.TabIndex = 95;
            this.lab_incomeDescription.Text = "收益描述:";
            // 
            // txt_projectDescription
            // 
            this.txt_projectDescription.Location = new System.Drawing.Point(136, 227);
            this.txt_projectDescription.Multiline = true;
            this.txt_projectDescription.Name = "txt_projectDescription";
            this.txt_projectDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_projectDescription.TabIndex = 96;
            // 
            // lab_projectDescription
            // 
            this.lab_projectDescription.AutoSize = true;
            this.lab_projectDescription.Location = new System.Drawing.Point(37, 230);
            this.lab_projectDescription.Name = "lab_projectDescription";
            this.lab_projectDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_projectDescription.TabIndex = 94;
            this.lab_projectDescription.Text = "项目描述:";
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(391, 752);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 93;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(200, 752);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 92;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(39, 752);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 91;
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
            this.cob_industryChoice.Location = new System.Drawing.Point(136, 174);
            this.cob_industryChoice.Name = "cob_industryChoice";
            this.cob_industryChoice.Size = new System.Drawing.Size(348, 20);
            this.cob_industryChoice.TabIndex = 90;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(136, 458);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(348, 21);
            this.txt_phone.TabIndex = 88;
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Location = new System.Drawing.Point(37, 461);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_phone.TabIndex = 85;
            this.lab_phone.Text = "电话号码:";
            // 
            // lab_industryChoice
            // 
            this.lab_industryChoice.AutoSize = true;
            this.lab_industryChoice.Location = new System.Drawing.Point(37, 176);
            this.lab_industryChoice.Name = "lab_industryChoice";
            this.lab_industryChoice.Size = new System.Drawing.Size(59, 12);
            this.lab_industryChoice.TabIndex = 83;
            this.lab_industryChoice.Text = "行业选择:";
            // 
            // txt_resourceRequirements
            // 
            this.txt_resourceRequirements.Location = new System.Drawing.Point(136, 97);
            this.txt_resourceRequirements.Multiline = true;
            this.txt_resourceRequirements.Name = "txt_resourceRequirements";
            this.txt_resourceRequirements.Size = new System.Drawing.Size(348, 71);
            this.txt_resourceRequirements.TabIndex = 86;
            // 
            // lab_resourceRequirements
            // 
            this.lab_resourceRequirements.AutoSize = true;
            this.lab_resourceRequirements.Location = new System.Drawing.Point(37, 100);
            this.lab_resourceRequirements.Name = "lab_resourceRequirements";
            this.lab_resourceRequirements.Size = new System.Drawing.Size(59, 12);
            this.lab_resourceRequirements.TabIndex = 82;
            this.lab_resourceRequirements.Text = "资源要求:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(136, 36);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(348, 21);
            this.txt_title.TabIndex = 89;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(61, 39);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(35, 12);
            this.lab_title.TabIndex = 81;
            this.lab_title.Text = "标题:";
            // 
            // lab_shareDivision
            // 
            this.lab_shareDivision.AutoSize = true;
            this.lab_shareDivision.Location = new System.Drawing.Point(37, 203);
            this.lab_shareDivision.Name = "lab_shareDivision";
            this.lab_shareDivision.Size = new System.Drawing.Size(59, 12);
            this.lab_shareDivision.TabIndex = 81;
            this.lab_shareDivision.Text = "股权配出:";
            // 
            // txt_shareDivision
            // 
            this.txt_shareDivision.Location = new System.Drawing.Point(136, 200);
            this.txt_shareDivision.Name = "txt_shareDivision";
            this.txt_shareDivision.Size = new System.Drawing.Size(348, 21);
            this.txt_shareDivision.TabIndex = 89;
            // 
            // lab_teamIntroduction
            // 
            this.lab_teamIntroduction.AutoSize = true;
            this.lab_teamIntroduction.Location = new System.Drawing.Point(37, 384);
            this.lab_teamIntroduction.Name = "lab_teamIntroduction";
            this.lab_teamIntroduction.Size = new System.Drawing.Size(59, 12);
            this.lab_teamIntroduction.TabIndex = 95;
            this.lab_teamIntroduction.Text = "团队介绍:";
            // 
            // txt_teamIntroduction
            // 
            this.txt_teamIntroduction.Location = new System.Drawing.Point(136, 381);
            this.txt_teamIntroduction.Multiline = true;
            this.txt_teamIntroduction.Name = "txt_teamIntroduction";
            this.txt_teamIntroduction.Size = new System.Drawing.Size(348, 71);
            this.txt_teamIntroduction.TabIndex = 97;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(296, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ImgNuber
            // 
            this.lbl_ImgNuber.AutoSize = true;
            this.lbl_ImgNuber.Location = new System.Drawing.Point(294, 489);
            this.lbl_ImgNuber.Name = "lbl_ImgNuber";
            this.lbl_ImgNuber.Size = new System.Drawing.Size(53, 12);
            this.lbl_ImgNuber.TabIndex = 129;
            this.lbl_ImgNuber.Text = "总数量:0";
            // 
            // lab_diji
            // 
            this.lab_diji.AutoSize = true;
            this.lab_diji.Location = new System.Drawing.Point(405, 489);
            this.lab_diji.Name = "lab_diji";
            this.lab_diji.Size = new System.Drawing.Size(35, 12);
            this.lab_diji.TabIndex = 130;
            this.lab_diji.Text = "第0张";
            // 
            // txt_imageArray
            // 
            this.txt_imageArray.Location = new System.Drawing.Point(136, 485);
            this.txt_imageArray.Multiline = true;
            this.txt_imageArray.Name = "txt_imageArray";
            this.txt_imageArray.ReadOnly = true;
            this.txt_imageArray.Size = new System.Drawing.Size(152, 206);
            this.txt_imageArray.TabIndex = 128;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_imageArray
            // 
            this.lab_imageArray.AutoSize = true;
            this.lab_imageArray.Location = new System.Drawing.Point(37, 488);
            this.lab_imageArray.Name = "lab_imageArray";
            this.lab_imageArray.Size = new System.Drawing.Size(59, 12);
            this.lab_imageArray.TabIndex = 126;
            this.lab_imageArray.Text = "图片路径:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.cob_City.Location = new System.Drawing.Point(469, 10);
            this.cob_City.Name = "cob_City";
            this.cob_City.Size = new System.Drawing.Size(55, 20);
            this.cob_City.TabIndex = 132;
            this.cob_City.SelectedIndexChanged += new System.EventHandler(this.cob_City_SelectedIndexChanged);
            // 
            // ganguSatisfiedBefore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 821);
            this.Controls.Add(this.cob_City);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ImgNuber);
            this.Controls.Add(this.lab_diji);
            this.Controls.Add(this.txt_imageArray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_imageArray);
            this.Controls.Add(this.txt_teamIntroduction);
            this.Controls.Add(this.lab_teamIntroduction);
            this.Controls.Add(this.txt_incomeDescription);
            this.Controls.Add(this.lab_incomeDescription);
            this.Controls.Add(this.txt_projectDescription);
            this.Controls.Add(this.lab_projectDescription);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cob_industryChoice);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.lab_industryChoice);
            this.Controls.Add(this.txt_resourceRequirements);
            this.Controls.Add(this.lab_resourceRequirements);
            this.Controls.Add(this.txt_shareDivision);
            this.Controls.Add(this.lab_shareDivision);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lab_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ganguSatisfiedBefore";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "干股纳才";
            this.Load += new System.EventHandler(this.ganguSatisfiedBefore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_incomeDescription;
        private System.Windows.Forms.Label lab_incomeDescription;
        private System.Windows.Forms.TextBox txt_projectDescription;
        private System.Windows.Forms.Label lab_projectDescription;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cob_industryChoice;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.Label lab_industryChoice;
        private System.Windows.Forms.TextBox txt_resourceRequirements;
        private System.Windows.Forms.Label lab_resourceRequirements;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_shareDivision;
        private System.Windows.Forms.TextBox txt_shareDivision;
        private System.Windows.Forms.Label lab_teamIntroduction;
        private System.Windows.Forms.TextBox txt_teamIntroduction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ImgNuber;
        private System.Windows.Forms.Label lab_diji;
        private System.Windows.Forms.TextBox txt_imageArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_imageArray;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cob_City;
    }
}