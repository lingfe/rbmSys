namespace ProjectReleaseSys
{
    partial class sysAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sysAddUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_NO = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_adminId = new System.Windows.Forms.TextBox();
            this.txt_adminName = new System.Windows.Forms.TextBox();
            this.lab_adminId = new System.Windows.Forms.Label();
            this.lab_adminName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_NO
            // 
            this.btn_NO.Location = new System.Drawing.Point(327, 196);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(75, 23);
            this.btn_NO.TabIndex = 8;
            this.btn_NO.Text = "重新生成";
            this.btn_NO.UseVisualStyleBackColor = true;
            this.btn_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(197, 196);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "确定使用";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_adminId
            // 
            this.txt_adminId.Location = new System.Drawing.Point(162, 91);
            this.txt_adminId.Name = "txt_adminId";
            this.txt_adminId.ReadOnly = true;
            this.txt_adminId.Size = new System.Drawing.Size(240, 21);
            this.txt_adminId.TabIndex = 6;
            this.txt_adminId.Text = "B86F5533AA384C5BBBE3F35A2EE65768";
            // 
            // txt_adminName
            // 
            this.txt_adminName.Location = new System.Drawing.Point(162, 34);
            this.txt_adminName.Name = "txt_adminName";
            this.txt_adminName.ShortcutsEnabled = false;
            this.txt_adminName.Size = new System.Drawing.Size(240, 21);
            this.txt_adminName.TabIndex = 7;
            this.txt_adminName.Text = "快讯";
            // 
            // lab_adminId
            // 
            this.lab_adminId.AutoSize = true;
            this.lab_adminId.Location = new System.Drawing.Point(85, 94);
            this.lab_adminId.Name = "lab_adminId";
            this.lab_adminId.Size = new System.Drawing.Size(59, 12);
            this.lab_adminId.TabIndex = 4;
            this.lab_adminId.Text = "管理员id:";
            // 
            // lab_adminName
            // 
            this.lab_adminName.AutoSize = true;
            this.lab_adminName.Location = new System.Drawing.Point(73, 37);
            this.lab_adminName.Name = "lab_adminName";
            this.lab_adminName.Size = new System.Drawing.Size(71, 12);
            this.lab_adminName.TabIndex = 5;
            this.lab_adminName.Text = "管理员名称:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sysAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_adminId);
            this.Controls.Add(this.txt_adminName);
            this.Controls.Add(this.lab_adminId);
            this.Controls.Add(this.lab_adminName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "sysAddUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "系统生成用户";
            this.Load += new System.EventHandler(this.sysAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_NO;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_adminId;
        private System.Windows.Forms.TextBox txt_adminName;
        private System.Windows.Forms.Label lab_adminId;
        private System.Windows.Forms.Label lab_adminName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}