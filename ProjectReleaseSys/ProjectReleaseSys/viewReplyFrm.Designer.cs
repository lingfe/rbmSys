namespace ProjectReleaseSys
{
    partial class viewReplyFrm
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
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.r_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_releaseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_personalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_avatarUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_replypersonalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_cdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_mdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_commentinfoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_personalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(313, 16);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(281, 21);
            this.txt_content.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "帖子评论>回复信息";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(781, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "删除回复";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(619, 16);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "添加回复";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_id,
            this.r_commentinfoId,
            this.r_releaseId,
            this.r_personalId,
            this.r_personalName,
            this.r_avatarUrl,
            this.r_content,
            this.r_replypersonalId,
            this.c_cdate,
            this.c_mdate});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(886, 607);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // r_id
            // 
            this.r_id.Text = "编号";
            this.r_id.Width = 100;
            // 
            // r_releaseId
            // 
            this.r_releaseId.Text = "发布信息id";
            this.r_releaseId.Width = 100;
            // 
            // r_personalId
            // 
            this.r_personalId.Text = "回复者Id";
            this.r_personalId.Width = 100;
            // 
            // r_content
            // 
            this.r_content.Text = "回复内容";
            this.r_content.Width = 100;
            // 
            // r_avatarUrl
            // 
            this.r_avatarUrl.Text = "回复者头像";
            this.r_avatarUrl.Width = 100;
            // 
            // r_replypersonalId
            // 
            this.r_replypersonalId.Text = "回复谁(id)";
            // 
            // c_cdate
            // 
            this.c_cdate.Text = "创建时间";
            this.c_cdate.Width = 100;
            // 
            // c_mdate
            // 
            this.c_mdate.Text = "最后修改时间";
            this.c_mdate.Width = 100;
            // 
            // r_commentinfoId
            // 
            this.r_commentinfoId.Text = "评论表id";
            // 
            // r_personalName
            // 
            this.r_personalName.Text = "回复者名称";
            // 
            // viewReplyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 664);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewReplyFrm";
            this.ShowIcon = false;
            this.Text = "查看回复界面";
            this.Load += new System.EventHandler(this.viewReplyFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader r_id;
        private System.Windows.Forms.ColumnHeader r_commentinfoId;
        private System.Windows.Forms.ColumnHeader r_releaseId;
        private System.Windows.Forms.ColumnHeader r_personalId;
        private System.Windows.Forms.ColumnHeader r_personalName;
        private System.Windows.Forms.ColumnHeader r_avatarUrl;
        private System.Windows.Forms.ColumnHeader r_content;
        private System.Windows.Forms.ColumnHeader r_replypersonalId;
        private System.Windows.Forms.ColumnHeader c_cdate;
        private System.Windows.Forms.ColumnHeader c_mdate;
    }
}