namespace ProjectReleaseSys
{
    partial class loginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.lab_adminName = new System.Windows.Forms.Label();
            this.txt_adminName = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lab_adminId = new System.Windows.Forms.Label();
            this.txt_adminId = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_NO = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // lab_adminName
            // 
            this.lab_adminName.AutoSize = true;
            this.lab_adminName.Location = new System.Drawing.Point(55, 60);
            this.lab_adminName.Name = "lab_adminName";
            this.lab_adminName.Size = new System.Drawing.Size(71, 12);
            this.lab_adminName.TabIndex = 0;
            this.lab_adminName.Text = "管理员名称:";
            // 
            // txt_adminName
            // 
            this.txt_adminName.Location = new System.Drawing.Point(144, 57);
            this.txt_adminName.Name = "txt_adminName";
            this.txt_adminName.ReadOnly = true;
            this.txt_adminName.Size = new System.Drawing.Size(240, 21);
            this.txt_adminName.TabIndex = 1;
            this.txt_adminName.Text = "快讯";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lab_adminId
            // 
            this.lab_adminId.AutoSize = true;
            this.lab_adminId.Location = new System.Drawing.Point(67, 117);
            this.lab_adminId.Name = "lab_adminId";
            this.lab_adminId.Size = new System.Drawing.Size(59, 12);
            this.lab_adminId.TabIndex = 0;
            this.lab_adminId.Text = "管理员id:";
            // 
            // txt_adminId
            // 
            this.txt_adminId.Location = new System.Drawing.Point(144, 114);
            this.txt_adminId.Name = "txt_adminId";
            this.txt_adminId.ReadOnly = true;
            this.txt_adminId.Size = new System.Drawing.Size(240, 21);
            this.txt_adminId.TabIndex = 1;
            this.txt_adminId.Text = "B86F5533AA384C5BBBE3F35A2EE65768";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(179, 219);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_NO
            // 
            this.btn_NO.Location = new System.Drawing.Point(309, 219);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(75, 23);
            this.btn_NO.TabIndex = 2;
            this.btn_NO.Text = "取消";
            this.btn_NO.UseVisualStyleBackColor = true;
            this.btn_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "切换身份>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_adminId);
            this.Controls.Add(this.txt_adminName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_adminId);
            this.Controls.Add(this.lab_adminName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.loginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox txt_adminId;
        private System.Windows.Forms.TextBox txt_adminName;
        private System.Windows.Forms.Label lab_adminId;
        private System.Windows.Forms.Label lab_adminName;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_NO;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}