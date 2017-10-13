namespace ProjectReleaseSys
{
    partial class upload
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_imageArray = new System.Windows.Forms.TextBox();
            this.lab_diji = new System.Windows.Forms.Label();
            this.lbl_ImgNuber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_imageArray
            // 
            this.txt_imageArray.Location = new System.Drawing.Point(229, 141);
            this.txt_imageArray.Multiline = true;
            this.txt_imageArray.Name = "txt_imageArray";
            this.txt_imageArray.ReadOnly = true;
            this.txt_imageArray.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_imageArray.Size = new System.Drawing.Size(106, 245);
            this.txt_imageArray.TabIndex = 3;
            // 
            // lab_diji
            // 
            this.lab_diji.AutoSize = true;
            this.lab_diji.Location = new System.Drawing.Point(467, 145);
            this.lab_diji.Name = "lab_diji";
            this.lab_diji.Size = new System.Drawing.Size(35, 12);
            this.lab_diji.TabIndex = 4;
            this.lab_diji.Text = "第0张";
            // 
            // lbl_ImgNuber
            // 
            this.lbl_ImgNuber.AutoSize = true;
            this.lbl_ImgNuber.Location = new System.Drawing.Point(356, 145);
            this.lbl_ImgNuber.Name = "lbl_ImgNuber";
            this.lbl_ImgNuber.Size = new System.Drawing.Size(53, 12);
            this.lbl_ImgNuber.TabIndex = 4;
            this.lbl_ImgNuber.Text = "总数量:0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(358, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Violet;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ImgNuber);
            this.Controls.Add(this.lab_diji);
            this.Controls.Add(this.txt_imageArray);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "upload";
            this.Text = "upload";
            this.Load += new System.EventHandler(this.upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_imageArray;
        private System.Windows.Forms.Label lab_diji;
        private System.Windows.Forms.Label lbl_ImgNuber;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}