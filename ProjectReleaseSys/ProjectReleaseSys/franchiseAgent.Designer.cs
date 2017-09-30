namespace ProjectReleaseSys
{
    partial class franchiseAgent
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
            this.txt_teamIntroduction = new System.Windows.Forms.TextBox();
            this.lab_teamIntroduction = new System.Windows.Forms.Label();
            this.txt_incomeDescription = new System.Windows.Forms.TextBox();
            this.lab_incomeDescription = new System.Windows.Forms.Label();
            this.txt_projectDescription = new System.Windows.Forms.TextBox();
            this.lab_projectDescription = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cob_industryChoice = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_imageArray = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_imageArray = new System.Windows.Forms.TextBox();
            this.lab_industryChoice = new System.Windows.Forms.Label();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.lab_threshold = new System.Windows.Forms.Label();
            this.txt_headquartersLocation = new System.Windows.Forms.TextBox();
            this.lab_headquartersLocation = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_fundDistribution = new System.Windows.Forms.Label();
            this.txt_fundDistribution = new System.Windows.Forms.TextBox();
            this.lab_throwInTheCity = new System.Windows.Forms.Label();
            this.cob_throwInTheCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_teamIntroduction
            // 
            this.txt_teamIntroduction.Location = new System.Drawing.Point(138, 364);
            this.txt_teamIntroduction.Multiline = true;
            this.txt_teamIntroduction.Name = "txt_teamIntroduction";
            this.txt_teamIntroduction.Size = new System.Drawing.Size(348, 71);
            this.txt_teamIntroduction.TabIndex = 118;
            // 
            // lab_teamIntroduction
            // 
            this.lab_teamIntroduction.AutoSize = true;
            this.lab_teamIntroduction.Location = new System.Drawing.Point(39, 367);
            this.lab_teamIntroduction.Name = "lab_teamIntroduction";
            this.lab_teamIntroduction.Size = new System.Drawing.Size(59, 12);
            this.lab_teamIntroduction.TabIndex = 115;
            this.lab_teamIntroduction.Text = "团队介绍:";
            // 
            // txt_incomeDescription
            // 
            this.txt_incomeDescription.Location = new System.Drawing.Point(138, 287);
            this.txt_incomeDescription.Multiline = true;
            this.txt_incomeDescription.Name = "txt_incomeDescription";
            this.txt_incomeDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_incomeDescription.TabIndex = 117;
            // 
            // lab_incomeDescription
            // 
            this.lab_incomeDescription.AutoSize = true;
            this.lab_incomeDescription.Location = new System.Drawing.Point(39, 290);
            this.lab_incomeDescription.Name = "lab_incomeDescription";
            this.lab_incomeDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_incomeDescription.TabIndex = 114;
            this.lab_incomeDescription.Text = "收益描述:";
            // 
            // txt_projectDescription
            // 
            this.txt_projectDescription.Location = new System.Drawing.Point(138, 210);
            this.txt_projectDescription.Multiline = true;
            this.txt_projectDescription.Name = "txt_projectDescription";
            this.txt_projectDescription.Size = new System.Drawing.Size(348, 71);
            this.txt_projectDescription.TabIndex = 116;
            // 
            // lab_projectDescription
            // 
            this.lab_projectDescription.AutoSize = true;
            this.lab_projectDescription.Location = new System.Drawing.Point(39, 213);
            this.lab_projectDescription.Name = "lab_projectDescription";
            this.lab_projectDescription.Size = new System.Drawing.Size(59, 12);
            this.lab_projectDescription.TabIndex = 113;
            this.lab_projectDescription.Text = "项目描述:";
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(393, 635);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 112;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(202, 635);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 111;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(41, 635);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 110;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
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
            this.cob_industryChoice.Location = new System.Drawing.Point(138, 130);
            this.cob_industryChoice.Name = "cob_industryChoice";
            this.cob_industryChoice.Size = new System.Drawing.Size(348, 20);
            this.cob_industryChoice.TabIndex = 109;
            this.cob_industryChoice.Text = "其他";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(138, 467);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(348, 21);
            this.txt_phone.TabIndex = 106;
            // 
            // lab_imageArray
            // 
            this.lab_imageArray.AutoSize = true;
            this.lab_imageArray.Location = new System.Drawing.Point(39, 497);
            this.lab_imageArray.Name = "lab_imageArray";
            this.lab_imageArray.Size = new System.Drawing.Size(59, 12);
            this.lab_imageArray.TabIndex = 102;
            this.lab_imageArray.Text = "图片路径:";
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Location = new System.Drawing.Point(39, 470);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_phone.TabIndex = 103;
            this.lab_phone.Text = "电话号码:";
            // 
            // txt_imageArray
            // 
            this.txt_imageArray.Location = new System.Drawing.Point(138, 494);
            this.txt_imageArray.Multiline = true;
            this.txt_imageArray.Name = "txt_imageArray";
            this.txt_imageArray.Size = new System.Drawing.Size(348, 100);
            this.txt_imageArray.TabIndex = 105;
            this.txt_imageArray.Text = "web.echsoft.cn/admin/20170919/,\r\nweb.echsoft.cn/admin/20170919/,\r\nweb.echsoft.cn/" +
    "admin/20170919/,\r\nweb.echsoft.cn/admin/20170919/,\r\nweb.echsoft.cn/admin/20170919" +
    "/,\r\nweb.echsoft.cn/admin/20170919/,";
            // 
            // lab_industryChoice
            // 
            this.lab_industryChoice.AutoSize = true;
            this.lab_industryChoice.Location = new System.Drawing.Point(39, 132);
            this.lab_industryChoice.Name = "lab_industryChoice";
            this.lab_industryChoice.Size = new System.Drawing.Size(59, 12);
            this.lab_industryChoice.TabIndex = 101;
            this.lab_industryChoice.Text = "行业选择:";
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(138, 103);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(348, 21);
            this.txt_threshold.TabIndex = 104;
            // 
            // lab_threshold
            // 
            this.lab_threshold.AutoSize = true;
            this.lab_threshold.Location = new System.Drawing.Point(39, 106);
            this.lab_threshold.Name = "lab_threshold";
            this.lab_threshold.Size = new System.Drawing.Size(59, 12);
            this.lab_threshold.TabIndex = 100;
            this.lab_threshold.Text = "加盟金额:";
            // 
            // txt_headquartersLocation
            // 
            this.txt_headquartersLocation.Location = new System.Drawing.Point(138, 156);
            this.txt_headquartersLocation.Name = "txt_headquartersLocation";
            this.txt_headquartersLocation.Size = new System.Drawing.Size(348, 21);
            this.txt_headquartersLocation.TabIndex = 108;
            // 
            // lab_headquartersLocation
            // 
            this.lab_headquartersLocation.AutoSize = true;
            this.lab_headquartersLocation.Location = new System.Drawing.Point(39, 159);
            this.lab_headquartersLocation.Name = "lab_headquartersLocation";
            this.lab_headquartersLocation.Size = new System.Drawing.Size(59, 12);
            this.lab_headquartersLocation.TabIndex = 99;
            this.lab_headquartersLocation.Text = "总部位置:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(138, 42);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(348, 21);
            this.txt_title.TabIndex = 107;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(63, 45);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(35, 12);
            this.lab_title.TabIndex = 98;
            this.lab_title.Text = "标题:";
            // 
            // lab_fundDistribution
            // 
            this.lab_fundDistribution.AutoSize = true;
            this.lab_fundDistribution.Location = new System.Drawing.Point(39, 186);
            this.lab_fundDistribution.Name = "lab_fundDistribution";
            this.lab_fundDistribution.Size = new System.Drawing.Size(59, 12);
            this.lab_fundDistribution.TabIndex = 99;
            this.lab_fundDistribution.Text = "资金规划:";
            // 
            // txt_fundDistribution
            // 
            this.txt_fundDistribution.Location = new System.Drawing.Point(138, 183);
            this.txt_fundDistribution.Name = "txt_fundDistribution";
            this.txt_fundDistribution.Size = new System.Drawing.Size(348, 21);
            this.txt_fundDistribution.TabIndex = 108;
            // 
            // lab_throwInTheCity
            // 
            this.lab_throwInTheCity.AutoSize = true;
            this.lab_throwInTheCity.Location = new System.Drawing.Point(39, 444);
            this.lab_throwInTheCity.Name = "lab_throwInTheCity";
            this.lab_throwInTheCity.Size = new System.Drawing.Size(59, 12);
            this.lab_throwInTheCity.TabIndex = 103;
            this.lab_throwInTheCity.Text = "投放城市:";
            // 
            // cob_throwInTheCity
            // 
            this.cob_throwInTheCity.FormattingEnabled = true;
            this.cob_throwInTheCity.Items.AddRange(new object[] {
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
            this.cob_throwInTheCity.Location = new System.Drawing.Point(138, 441);
            this.cob_throwInTheCity.Name = "cob_throwInTheCity";
            this.cob_throwInTheCity.Size = new System.Drawing.Size(348, 20);
            this.cob_throwInTheCity.TabIndex = 109;
            this.cob_throwInTheCity.Text = "其他";
            // 
            // franchiseAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 735);
            this.Controls.Add(this.txt_teamIntroduction);
            this.Controls.Add(this.lab_teamIntroduction);
            this.Controls.Add(this.txt_incomeDescription);
            this.Controls.Add(this.lab_incomeDescription);
            this.Controls.Add(this.txt_projectDescription);
            this.Controls.Add(this.lab_projectDescription);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cob_throwInTheCity);
            this.Controls.Add(this.cob_industryChoice);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_throwInTheCity);
            this.Controls.Add(this.lab_imageArray);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_imageArray);
            this.Controls.Add(this.lab_industryChoice);
            this.Controls.Add(this.txt_threshold);
            this.Controls.Add(this.lab_threshold);
            this.Controls.Add(this.txt_fundDistribution);
            this.Controls.Add(this.lab_fundDistribution);
            this.Controls.Add(this.txt_headquartersLocation);
            this.Controls.Add(this.lab_headquartersLocation);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lab_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "franchiseAgent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加盟代理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_teamIntroduction;
        private System.Windows.Forms.Label lab_teamIntroduction;
        private System.Windows.Forms.TextBox txt_incomeDescription;
        private System.Windows.Forms.Label lab_incomeDescription;
        private System.Windows.Forms.TextBox txt_projectDescription;
        private System.Windows.Forms.Label lab_projectDescription;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cob_industryChoice;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_imageArray;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_imageArray;
        private System.Windows.Forms.Label lab_industryChoice;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.Label lab_threshold;
        private System.Windows.Forms.TextBox txt_headquartersLocation;
        private System.Windows.Forms.Label lab_headquartersLocation;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_fundDistribution;
        private System.Windows.Forms.TextBox txt_fundDistribution;
        private System.Windows.Forms.Label lab_throwInTheCity;
        private System.Windows.Forms.ComboBox cob_throwInTheCity;
    }
}