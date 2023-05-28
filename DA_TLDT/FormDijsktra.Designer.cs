namespace DA_TLDT
{
    partial class FrmDijkstra
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
            this.txtDinhEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ptbDtra = new System.Windows.Forms.PictureBox();
            this.lb_Canh = new System.Windows.Forms.ListBox();
            this.lb_Dinh = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrimOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbPrimReadFile = new System.Windows.Forms.ToolStripButton();
            this.tsbPrimSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbPrimDelete = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbDeleteEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbDeleteVertex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPrimSaveWeight = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDtra)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtDinhEnd);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ptbDtra);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lb_Canh);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lb_Dinh);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1250, 704);
            this.toolStripContainer1.Location = new System.Drawing.Point(-1, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1250, 735);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // txtDinhEnd
            // 
            this.txtDinhEnd.Location = new System.Drawing.Point(188, 668);
            this.txtDinhEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhEnd.Name = "txtDinhEnd";
            this.txtDinhEnd.Size = new System.Drawing.Size(89, 22);
            this.txtDinhEnd.TabIndex = 35;
            this.txtDinhEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinhEnd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 674);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Đỉnh đích";
            // 
            // txtDinhStart
            // 
            this.txtDinhStart.Location = new System.Drawing.Point(188, 642);
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
            this.lb3.Location = new System.Drawing.Point(28, 644);
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
            // ptbDtra
            // 
            this.ptbDtra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptbDtra.Location = new System.Drawing.Point(640, 26);
            this.ptbDtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbDtra.Name = "ptbDtra";
            this.ptbDtra.Size = new System.Drawing.Size(532, 658);
            this.ptbDtra.TabIndex = 18;
            this.ptbDtra.TabStop = false;
            this.ptbDtra.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbDtra_Paint);
            this.ptbDtra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbDtra_MouseClick);
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
            this.lb_Dinh.Location = new System.Drawing.Point(32, 26);
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
            this.tsbPrimOpenFile,
            this.tsbPrimReadFile,
            this.tsbPrimSaveFile,
            this.toolStripSeparator1,
            this.tsddbPrimDelete,
            this.tsbPrimSaveWeight});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(173, 31);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbPrimOpenFile
            // 
            this.tsbPrimOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimOpenFile.Image = global::DA_TLDT.Properties.Resources.open_file_40455;
            this.tsbPrimOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimOpenFile.Name = "tsbPrimOpenFile";
            this.tsbPrimOpenFile.Size = new System.Drawing.Size(29, 28);
            this.tsbPrimOpenFile.Text = "Mở file";
            this.tsbPrimOpenFile.Click += new System.EventHandler(this.tsbPrimOpenFile_Click);
            // 
            // tsbPrimReadFile
            // 
            this.tsbPrimReadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimReadFile.Image = global::DA_TLDT.Properties.Resources.Readfile;
            this.tsbPrimReadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimReadFile.Name = "tsbPrimReadFile";
            this.tsbPrimReadFile.Size = new System.Drawing.Size(29, 28);
            this.tsbPrimReadFile.Text = "Đọc file";
            this.tsbPrimReadFile.Click += new System.EventHandler(this.tsbPrimReadFile_Click);
            // 
            // tsbPrimSaveFile
            // 
            this.tsbPrimSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimSaveFile.Image = global::DA_TLDT.Properties.Resources.Save;
            this.tsbPrimSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimSaveFile.Name = "tsbPrimSaveFile";
            this.tsbPrimSaveFile.Size = new System.Drawing.Size(29, 28);
            this.tsbPrimSaveFile.Text = "Lưu file";
            this.tsbPrimSaveFile.Click += new System.EventHandler(this.tsbPrimSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsddbPrimDelete
            // 
            this.tsddbPrimDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbPrimDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbDeleteEdge,
            this.tsddbDeleteVertex});
            this.tsddbPrimDelete.Image = global::DA_TLDT.Properties.Resources.delete_icon;
            this.tsddbPrimDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbPrimDelete.Name = "tsddbPrimDelete";
            this.tsddbPrimDelete.Size = new System.Drawing.Size(38, 28);
            this.tsddbPrimDelete.Text = "Delete";
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
            // tsbPrimSaveWeight
            // 
            this.tsbPrimSaveWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimSaveWeight.Image = global::DA_TLDT.Properties.Resources.save_as;
            this.tsbPrimSaveWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimSaveWeight.Name = "tsbPrimSaveWeight";
            this.tsbPrimSaveWeight.Size = new System.Drawing.Size(29, 28);
            this.tsbPrimSaveWeight.Text = "Lưu trọng số";
            this.tsbPrimSaveWeight.Click += new System.EventHandler(this.tsbPrimSaveWeight_Click);
            // 
            // FrmDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 735);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDijkstra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijsktra";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDtra)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox txtDinhEnd;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.PictureBox ptbDtra;
        private System.Windows.Forms.ListBox lb_Canh;
        private System.Windows.Forms.ListBox lb_Dinh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrimOpenFile;
        private System.Windows.Forms.ToolStripButton tsbPrimReadFile;
        private System.Windows.Forms.ToolStripButton tsbPrimSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbPrimDelete;
        private System.Windows.Forms.ToolStripMenuItem tsddbDeleteEdge;
        private System.Windows.Forms.ToolStripMenuItem tsddbDeleteVertex;
        private System.Windows.Forms.ToolStripButton tsbPrimSaveWeight;
    }
}