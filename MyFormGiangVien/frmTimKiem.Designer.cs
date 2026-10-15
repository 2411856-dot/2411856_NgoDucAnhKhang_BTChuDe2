namespace MyFormGiangVien
{
    partial class frmTimKiem
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
            this.groupboxTim = new System.Windows.Forms.GroupBox();
            this.rdTimSDT = new System.Windows.Forms.RadioButton();
            this.rdTimHoTen = new System.Windows.Forms.RadioButton();
            this.rdTimMaGV = new System.Windows.Forms.RadioButton();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupboxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxTim
            // 
            this.groupboxTim.Controls.Add(this.rdTimSDT);
            this.groupboxTim.Controls.Add(this.rdTimHoTen);
            this.groupboxTim.Controls.Add(this.rdTimMaGV);
            this.groupboxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupboxTim.Location = new System.Drawing.Point(85, 13);
            this.groupboxTim.Name = "groupboxTim";
            this.groupboxTim.Size = new System.Drawing.Size(517, 100);
            this.groupboxTim.TabIndex = 0;
            this.groupboxTim.TabStop = false;
            this.groupboxTim.Text = "Tìm theo";
            // 
            // rdTimSDT
            // 
            this.rdTimSDT.AutoSize = true;
            this.rdTimSDT.Location = new System.Drawing.Point(361, 35);
            this.rdTimSDT.Name = "rdTimSDT";
            this.rdTimSDT.Size = new System.Drawing.Size(127, 24);
            this.rdTimSDT.TabIndex = 2;
            this.rdTimSDT.Text = "Số điện thoại";
            this.rdTimSDT.UseVisualStyleBackColor = true;
            this.rdTimSDT.CheckedChanged += new System.EventHandler(this.rdTimSDT_CheckedChanged);
            // 
            // rdTimHoTen
            // 
            this.rdTimHoTen.AutoSize = true;
            this.rdTimHoTen.Location = new System.Drawing.Point(194, 35);
            this.rdTimHoTen.Name = "rdTimHoTen";
            this.rdTimHoTen.Size = new System.Drawing.Size(80, 24);
            this.rdTimHoTen.TabIndex = 1;
            this.rdTimHoTen.Text = "Họ tên";
            this.rdTimHoTen.UseVisualStyleBackColor = true;
            this.rdTimHoTen.CheckedChanged += new System.EventHandler(this.rdTimHoTen_CheckedChanged);
            // 
            // rdTimMaGV
            // 
            this.rdTimMaGV.AutoSize = true;
            this.rdTimMaGV.Checked = true;
            this.rdTimMaGV.Location = new System.Drawing.Point(36, 35);
            this.rdTimMaGV.Name = "rdTimMaGV";
            this.rdTimMaGV.Size = new System.Drawing.Size(82, 24);
            this.rdTimMaGV.TabIndex = 0;
            this.rdTimMaGV.TabStop = true;
            this.rdTimMaGV.Text = "Mã GV";
            this.rdTimMaGV.UseVisualStyleBackColor = true;
            this.rdTimMaGV.CheckedChanged += new System.EventHandler(this.rdTimMaGV_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.Location = new System.Drawing.Point(117, 121);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(61, 20);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Mã GV";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(203, 119);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 24);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(472, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 32);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 163);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.groupboxTim);
            this.Name = "frmTimKiem";
            this.Text = "Tìm thông tin giảng viên";
            this.groupboxTim.ResumeLayout(false);
            this.groupboxTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxTim;
        private System.Windows.Forms.RadioButton rdTimSDT;
        private System.Windows.Forms.RadioButton rdTimHoTen;
        private System.Windows.Forms.RadioButton rdTimMaGV;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
    }
}