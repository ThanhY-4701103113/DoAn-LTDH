namespace DA_TLDT
{
    partial class FrmDFS
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.txtDinhStart = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.bttReset = new System.Windows.Forms.Button();
            this.bttKiemTraDoThi = new System.Windows.Forms.Button();
            this.bttChayTuDong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMatranke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblCuoi = new System.Windows.Forms.Label();
            this.lblDau = new System.Windows.Forms.Label();
            this.txtTrongSo = new System.Windows.Forms.TextBox();
            this.txtDinhCuoi = new System.Windows.Forms.TextBox();
            this.txtDinhDau = new System.Windows.Forms.TextBox();
            this.ptbDFS = new System.Windows.Forms.PictureBox();
            this.lb_Canh = new System.Windows.Forms.ListBox();
            this.lb_Dinh = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDFSOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbDFSReadFile = new System.Windows.Forms.ToolStripButton();
            this.tsbDFSSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbDFSPrimDelete = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbDeleteEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbDeleteVertex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDFSSaveWeight = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDFS)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtDinhStart);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lb3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bttReset);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bttKiemTraDoThi);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bttChayTuDong);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtKetQua);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtMatranke);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblW);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblCuoi);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblDau);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtTrongSo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtDinhCuoi);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtDinhDau);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ptbDFS);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lb_Canh);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lb_Dinh);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1405, 704);
            this.toolStripContainer1.Location = new System.Drawing.Point(-1, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1405, 735);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // txtDinhStart
            // 
            this.txtDinhStart.Location = new System.Drawing.Point(164, 666);
            this.txtDinhStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhStart.Name = "txtDinhStart";
            this.txtDinhStart.Size = new System.Drawing.Size(89, 22);
            this.txtDinhStart.TabIndex = 33;
            this.txtDinhStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhStart_KeyPress);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(28, 666);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(106, 19);
            this.lb3.TabIndex = 32;
            this.lb3.Text = "Đỉnh xuất phát";
            // 
            // bttReset
            // 
            this.bttReset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReset.Location = new System.Drawing.Point(446, 250);
            this.bttReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(161, 90);
            this.bttReset.TabIndex = 31;
            this.bttReset.Text = "Reset";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.bttReset_Click);
            // 
            // bttKiemTraDoThi
            // 
            this.bttKiemTraDoThi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttKiemTraDoThi.Location = new System.Drawing.Point(446, 566);
            this.bttKiemTraDoThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttKiemTraDoThi.Name = "bttKiemTraDoThi";
            this.bttKiemTraDoThi.Size = new System.Drawing.Size(161, 90);
            this.bttKiemTraDoThi.TabIndex = 30;
            this.bttKiemTraDoThi.Text = "Chạy từng bước";
            this.bttKiemTraDoThi.UseVisualStyleBackColor = true;
            this.bttKiemTraDoThi.Click += new System.EventHandler(this.bttKiemTraDoThi_Click);
            // 
            // bttChayTuDong
            // 
            this.bttChayTuDong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttChayTuDong.Location = new System.Drawing.Point(446, 442);
            this.bttChayTuDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttChayTuDong.Name = "bttChayTuDong";
            this.bttChayTuDong.Size = new System.Drawing.Size(161, 90);
            this.bttChayTuDong.TabIndex = 29;
            this.bttChayTuDong.Text = "Chạy tự động";
            this.bttChayTuDong.UseVisualStyleBackColor = true;
            this.bttChayTuDong.Click += new System.EventHandler(this.bttChayTuDong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(32, 442);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKetQua.Size = new System.Drawing.Size(344, 194);
            this.txtKetQua.TabIndex = 27;
            // 
            // txtMatranke
            // 
            this.txtMatranke.Location = new System.Drawing.Point(32, 204);
            this.txtMatranke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatranke.Multiline = true;
            this.txtMatranke.Name = "txtMatranke";
            this.txtMatranke.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatranke.Size = new System.Drawing.Size(344, 194);
            this.txtMatranke.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ma trận kề";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(412, 139);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(68, 19);
            this.lblW.TabIndex = 24;
            this.lblW.Text = "Trọng số";
            // 
            // lblCuoi
            // 
            this.lblCuoi.AutoSize = true;
            this.lblCuoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuoi.Location = new System.Drawing.Point(412, 82);
            this.lblCuoi.Name = "lblCuoi";
            this.lblCuoi.Size = new System.Drawing.Size(76, 19);
            this.lblCuoi.TabIndex = 23;
            this.lblCuoi.Text = "Đỉnh cuối";
            // 
            // lblDau
            // 
            this.lblDau.AutoSize = true;
            this.lblDau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDau.Location = new System.Drawing.Point(412, 26);
            this.lblDau.Name = "lblDau";
            this.lblDau.Size = new System.Drawing.Size(70, 19);
            this.lblDau.TabIndex = 22;
            this.lblDau.Text = "Đỉnh đầu";
            // 
            // txtTrongSo
            // 
            this.txtTrongSo.Location = new System.Drawing.Point(518, 139);
            this.txtTrongSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrongSo.Name = "txtTrongSo";
            this.txtTrongSo.Size = new System.Drawing.Size(89, 22);
            this.txtTrongSo.TabIndex = 21;
            this.txtTrongSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongSo_KeyPress);
            // 
            // txtDinhCuoi
            // 
            this.txtDinhCuoi.Location = new System.Drawing.Point(518, 82);
            this.txtDinhCuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhCuoi.Name = "txtDinhCuoi";
            this.txtDinhCuoi.Size = new System.Drawing.Size(89, 22);
            this.txtDinhCuoi.TabIndex = 20;
            this.txtDinhCuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhCuoi_KeyPress);
            // 
            // txtDinhDau
            // 
            this.txtDinhDau.Location = new System.Drawing.Point(518, 26);
            this.txtDinhDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhDau.Name = "txtDinhDau";
            this.txtDinhDau.Size = new System.Drawing.Size(89, 22);
            this.txtDinhDau.TabIndex = 19;
            this.txtDinhDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhDau_KeyPress);
            // 
            // ptbDFS
            // 
            this.ptbDFS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptbDFS.Location = new System.Drawing.Point(639, 26);
            this.ptbDFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbDFS.Name = "ptbDFS";
            this.ptbDFS.Size = new System.Drawing.Size(549, 658);
            this.ptbDFS.TabIndex = 18;
            this.ptbDFS.TabStop = false;
            this.ptbDFS.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbDFS_Paint);
            this.ptbDFS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbDFS_MouseClick);
            // 
            // lb_Canh
            // 
            this.lb_Canh.FormattingEnabled = true;
            this.lb_Canh.ItemHeight = 16;
            this.lb_Canh.Location = new System.Drawing.Point(223, 26);
            this.lb_Canh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Canh.Name = "lb_Canh";
            this.lb_Canh.Size = new System.Drawing.Size(153, 132);
            this.lb_Canh.TabIndex = 17;
            // 
            // lb_Dinh
            // 
            this.lb_Dinh.FormattingEnabled = true;
            this.lb_Dinh.ItemHeight = 16;
            this.lb_Dinh.Location = new System.Drawing.Point(32, 29);
            this.lb_Dinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Dinh.Name = "lb_Dinh";
            this.lb_Dinh.Size = new System.Drawing.Size(153, 132);
            this.lb_Dinh.TabIndex = 16;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDFSOpenFile,
            this.tsbDFSReadFile,
            this.tsbDFSSaveFile,
            this.toolStripSeparator1,
            this.tsddbDFSPrimDelete,
            this.tsbDFSSaveWeight});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(173, 31);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbDFSOpenFile
            // 
            this.tsbDFSOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDFSOpenFile.Image = global::DA_TLDT.Properties.Resources.open_file_40455;
            this.tsbDFSOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDFSOpenFile.Name = "tsbDFSOpenFile";
            this.tsbDFSOpenFile.Size = new System.Drawing.Size(29, 28);
            this.tsbDFSOpenFile.Text = "Mở file";
            this.tsbDFSOpenFile.Click += new System.EventHandler(this.tsbDFSOpenFile_Click);
            // 
            // tsbDFSReadFile
            // 
            this.tsbDFSReadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDFSReadFile.Image = global::DA_TLDT.Properties.Resources.Readfile;
            this.tsbDFSReadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDFSReadFile.Name = "tsbDFSReadFile";
            this.tsbDFSReadFile.Size = new System.Drawing.Size(29, 28);
            this.tsbDFSReadFile.Text = "Đọc file";
            this.tsbDFSReadFile.Click += new System.EventHandler(this.tsbDFSReadFile_Click);
            // 
            // tsbDFSSaveFile
            // 
            this.tsbDFSSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDFSSaveFile.Image = global::DA_TLDT.Properties.Resources.Save;
            this.tsbDFSSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDFSSaveFile.Name = "tsbDFSSaveFile";
            this.tsbDFSSaveFile.Size = new System.Drawing.Size(29, 28);
            this.tsbDFSSaveFile.Text = "Lưu file";
            this.tsbDFSSaveFile.Click += new System.EventHandler(this.tsbDFSSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsddbDFSPrimDelete
            // 
            this.tsddbDFSPrimDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbDFSPrimDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbDeleteEdge,
            this.tsddbDeleteVertex});
            this.tsddbDFSPrimDelete.Image = global::DA_TLDT.Properties.Resources.delete_icon;
            this.tsddbDFSPrimDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbDFSPrimDelete.Name = "tsddbDFSPrimDelete";
            this.tsddbDFSPrimDelete.Size = new System.Drawing.Size(38, 28);
            this.tsddbDFSPrimDelete.Text = "Delete";
            // 
            // tsddbDeleteEdge
            // 
            this.tsddbDeleteEdge.Image = global::DA_TLDT.Properties.Resources.Xóa_cạnh;
            this.tsddbDeleteEdge.Name = "tsddbDeleteEdge";
            this.tsddbDeleteEdge.Size = new System.Drawing.Size(153, 26);
            this.tsddbDeleteEdge.Text = "Xóa cạnh";
            this.tsddbDeleteEdge.Click += new System.EventHandler(this.tsddbDeleteEdge_Click);
            // 
            // tsddbDeleteVertex
            // 
            this.tsddbDeleteVertex.Image = global::DA_TLDT.Properties.Resources.Xóa_đỉnh;
            this.tsddbDeleteVertex.Name = "tsddbDeleteVertex";
            this.tsddbDeleteVertex.Size = new System.Drawing.Size(153, 26);
            this.tsddbDeleteVertex.Text = "Xóa đỉnh";
            this.tsddbDeleteVertex.Click += new System.EventHandler(this.tsddbDeleteVertex_Click);
            // 
            // tsbDFSSaveWeight
            // 
            this.tsbDFSSaveWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDFSSaveWeight.Image = global::DA_TLDT.Properties.Resources.save_as;
            this.tsbDFSSaveWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDFSSaveWeight.Name = "tsbDFSSaveWeight";
            this.tsbDFSSaveWeight.Size = new System.Drawing.Size(29, 28);
            this.tsbDFSSaveWeight.Text = "Lưu trọng số";
            this.tsbDFSSaveWeight.Click += new System.EventHandler(this.tsbDFSSaveWeight_Click);
            // 
            // FrmDFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1482, 735);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFS";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDFS)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox txtDinhStart;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.Button bttKiemTraDoThi;
        private System.Windows.Forms.Button bttChayTuDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMatranke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblCuoi;
        private System.Windows.Forms.Label lblDau;
        private System.Windows.Forms.TextBox txtTrongSo;
        private System.Windows.Forms.TextBox txtDinhCuoi;
        private System.Windows.Forms.TextBox txtDinhDau;
        private System.Windows.Forms.PictureBox ptbDFS;
        private System.Windows.Forms.ListBox lb_Canh;
        private System.Windows.Forms.ListBox lb_Dinh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDFSOpenFile;
        private System.Windows.Forms.ToolStripButton tsbDFSReadFile;
        private System.Windows.Forms.ToolStripButton tsbDFSSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbDFSPrimDelete;
        private System.Windows.Forms.ToolStripMenuItem tsddbDeleteEdge;
        private System.Windows.Forms.ToolStripMenuItem tsddbDeleteVertex;
        private System.Windows.Forms.ToolStripButton tsbDFSSaveWeight;
    }
}