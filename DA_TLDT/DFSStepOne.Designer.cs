namespace DA_TLDT
{
    partial class DFSStepOne
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLui = new System.Windows.Forms.Button();
            this.btnTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(732, 716);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnLui
            // 
            this.btnLui.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLui.Location = new System.Drawing.Point(209, 731);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(75, 60);
            this.btnLui.TabIndex = 4;
            this.btnLui.Text = "<";
            this.btnLui.UseVisualStyleBackColor = true;
            this.btnLui.Click += new System.EventHandler(this.btnLui_Click);
            // 
            // btnTien
            // 
            this.btnTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTien.Location = new System.Drawing.Point(408, 731);
            this.btnTien.Name = "btnTien";
            this.btnTien.Size = new System.Drawing.Size(75, 60);
            this.btnTien.TabIndex = 5;
            this.btnTien.Text = ">";
            this.btnTien.UseVisualStyleBackColor = true;
            this.btnTien.Click += new System.EventHandler(this.btnTien_Click);
            // 
            // DFSStepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 803);
            this.Controls.Add(this.btnTien);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.pnlMain);
            this.Name = "DFSStepOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chạy từng bước thuật toán DFS";
            this.Load += new System.EventHandler(this.DFSStepOne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Button btnTien;
    }
}