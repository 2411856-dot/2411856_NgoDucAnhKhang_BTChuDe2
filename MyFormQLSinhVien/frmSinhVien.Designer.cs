namespace MyFormQLSinhVien
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxTTSV = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongSinhVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMauChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextMauChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupboxTTSV.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupboxDSSV.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxTTSV);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupboxDSSV);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1116, 611);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupboxTTSV
            // 
            this.groupboxTTSV.Controls.Add(this.statusStrip1);
            this.groupboxTTSV.Controls.Add(this.btnThoat);
            this.groupboxTTSV.Controls.Add(this.btnMacDinh);
            this.groupboxTTSV.Controls.Add(this.btnSua);
            this.groupboxTTSV.Controls.Add(this.btnXoa);
            this.groupboxTTSV.Controls.Add(this.btnThem);
            this.groupboxTTSV.Controls.Add(this.clbChuyenNganh);
            this.groupboxTTSV.Controls.Add(this.rdNu);
            this.groupboxTTSV.Controls.Add(this.rdNam);
            this.groupboxTTSV.Controls.Add(this.pbHinh);
            this.groupboxTTSV.Controls.Add(this.btnBrowse);
            this.groupboxTTSV.Controls.Add(this.txtHinh);
            this.groupboxTTSV.Controls.Add(this.label8);
            this.groupboxTTSV.Controls.Add(this.label7);
            this.groupboxTTSV.Controls.Add(this.label6);
            this.groupboxTTSV.Controls.Add(this.cboLop);
            this.groupboxTTSV.Controls.Add(this.txtDiaChi);
            this.groupboxTTSV.Controls.Add(this.dtpNgaySinh);
            this.groupboxTTSV.Controls.Add(this.txtHoTen);
            this.groupboxTTSV.Controls.Add(this.mtxtMaSo);
            this.groupboxTTSV.Controls.Add(this.label5);
            this.groupboxTTSV.Controls.Add(this.label4);
            this.groupboxTTSV.Controls.Add(this.label3);
            this.groupboxTTSV.Controls.Add(this.label2);
            this.groupboxTTSV.Controls.Add(this.label1);
            this.groupboxTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupboxTTSV.Location = new System.Drawing.Point(0, 31);
            this.groupboxTTSV.Name = "groupboxTTSV";
            this.groupboxTTSV.Size = new System.Drawing.Size(519, 568);
            this.groupboxTTSV.TabIndex = 0;
            this.groupboxTTSV.TabStop = false;
            this.groupboxTTSV.Text = "Thông tin sinh viên";
            this.groupboxTTSV.Enter += new System.EventHandler(this.groupboxTTSV_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongSinhVien});
            this.statusStrip1.Location = new System.Drawing.Point(3, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSinhVien
            // 
            this.lblTongSinhVien.Name = "lblTongSinhVien";
            this.lblTongSinhVien.Size = new System.Drawing.Size(119, 20);
            this.lblTongSinhVien.Text = "Tổng sinh viên: 0";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(417, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(302, 498);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(91, 42);
            this.btnMacDinh.TabIndex = 22;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(205, 498);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(106, 498);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 498);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(140, 355);
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(201, 137);
            this.clbChuyenNganh.TabIndex = 18;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(207, 307);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(48, 22);
            this.rdNu.TabIndex = 17;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(140, 307);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(61, 22);
            this.rdNam.TabIndex = 16;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 43);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(169, 161);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 15;
            this.pbHinh.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(389, 256);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 28);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(82, 255);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(283, 24);
            this.txtHinh.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chuyên ngành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(21, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hình";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.cboLop.Location = new System.Drawing.Point(261, 178);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(132, 26);
            this.cboLop.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(261, 143);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 24);
            this.txtDiaChi.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(275, 104);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(118, 24);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(261, 68);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(183, 24);
            this.txtHoTen.TabIndex = 6;
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(261, 37);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(104, 24);
            this.mtxtMaSo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(190, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(190, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(187, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(190, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(190, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoFile,
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuMoFile
            // 
            this.mnuMoFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuMoFile.Image")));
            this.mnuMoFile.Name = "mnuMoFile";
            this.mnuMoFile.Size = new System.Drawing.Size(141, 26);
            this.mnuMoFile.Text = "Mở File";
            this.mnuMoFile.Click += new System.EventHandler(this.mnuMoFile_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(141, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThem,
            this.mnuXoa,
            this.mnuSua,
            this.mnuListView});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(49, 24);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuThem
            // 
            this.mnuThem.Image = ((System.Drawing.Image)(resources.GetObject("mnuThem.Image")));
            this.mnuThem.Name = "mnuThem";
            this.mnuThem.Size = new System.Drawing.Size(211, 26);
            this.mnuThem.Text = "Thêm   Ctrl+Alt+T";
            this.mnuThem.Click += new System.EventHandler(this.mnuThem_Click);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Image = ((System.Drawing.Image)(resources.GetObject("mnuXoa.Image")));
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(211, 26);
            this.mnuXoa.Text = "Xóa   Ctrl+Alt+Y";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // mnuSua
            // 
            this.mnuSua.Image = ((System.Drawing.Image)(resources.GetObject("mnuSua.Image")));
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(211, 26);
            this.mnuSua.Text = "Sửa   Ctrl+Alt+S";
            this.mnuSua.Click += new System.EventHandler(this.mnuSua_Click);
            // 
            // mnuListView
            // 
            this.mnuListView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.mnuMauChu,
            this.mnuSapXep,
            this.mnuTimKiem});
            this.mnuListView.Name = "mnuListView";
            this.mnuListView.Size = new System.Drawing.Size(211, 26);
            this.mnuListView.Text = "ListView";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(153, 26);
            this.mnuFont.Text = "Font";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuMauChu
            // 
            this.mnuMauChu.Name = "mnuMauChu";
            this.mnuMauChu.Size = new System.Drawing.Size(153, 26);
            this.mnuMauChu.Text = "Màu chữ";
            this.mnuMauChu.Click += new System.EventHandler(this.mnuMauChu_Click);
            // 
            // mnuSapXep
            // 
            this.mnuSapXep.Name = "mnuSapXep";
            this.mnuSapXep.Size = new System.Drawing.Size(153, 26);
            this.mnuSapXep.Text = "Sắp xếp";
            this.mnuSapXep.Click += new System.EventHandler(this.mnuSapXep_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(153, 26);
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);
            // 
            // groupboxDSSV
            // 
            this.groupboxDSSV.Controls.Add(this.lvSinhVien);
            this.groupboxDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupboxDSSV.Location = new System.Drawing.Point(2, 3);
            this.groupboxDSSV.Name = "groupboxDSSV";
            this.groupboxDSSV.Size = new System.Drawing.Size(584, 537);
            this.groupboxDSSV.TabIndex = 1;
            this.groupboxDSSV.TabStop = false;
            this.groupboxDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSinhVien.ContextMenuStrip = this.cmsListView;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 20);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(578, 514);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phái";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chuyên ngành";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hình";
            // 
            // cmsListView
            // 
            this.cmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextFont,
            this.mnuContextMauChu,
            this.mnuContextSapXep,
            this.mnuContextTimKiem});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(144, 108);
            // 
            // mnuContextFont
            // 
            this.mnuContextFont.Image = ((System.Drawing.Image)(resources.GetObject("mnuContextFont.Image")));
            this.mnuContextFont.Name = "mnuContextFont";
            this.mnuContextFont.Size = new System.Drawing.Size(143, 26);
            this.mnuContextFont.Text = "Font";
            this.mnuContextFont.Click += new System.EventHandler(this.mnuContextFont_Click);
            // 
            // mnuContextMauChu
            // 
            this.mnuContextMauChu.Image = ((System.Drawing.Image)(resources.GetObject("mnuContextMauChu.Image")));
            this.mnuContextMauChu.Name = "mnuContextMauChu";
            this.mnuContextMauChu.Size = new System.Drawing.Size(143, 26);
            this.mnuContextMauChu.Text = "Màu chữ";
            this.mnuContextMauChu.Click += new System.EventHandler(this.mnuContextMauChu_Click);
            // 
            // mnuContextSapXep
            // 
            this.mnuContextSapXep.Image = ((System.Drawing.Image)(resources.GetObject("mnuContextSapXep.Image")));
            this.mnuContextSapXep.Name = "mnuContextSapXep";
            this.mnuContextSapXep.Size = new System.Drawing.Size(143, 26);
            this.mnuContextSapXep.Text = "Sắp xếp ";
            this.mnuContextSapXep.Click += new System.EventHandler(this.mnuContextSapXep_Click);
            // 
            // mnuContextTimKiem
            // 
            this.mnuContextTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuContextTimKiem.Image")));
            this.mnuContextTimKiem.Name = "mnuContextTimKiem";
            this.mnuContextTimKiem.Size = new System.Drawing.Size(143, 26);
            this.mnuContextTimKiem.Text = "Tìm kiếm";
            this.mnuContextTimKiem.Click += new System.EventHandler(this.mnuContextTimKiem_Click);
            // 
            // OpenFileDialogHinh
            // 
            this.OpenFileDialogHinh.FileName = "openFileDialog1";
            this.OpenFileDialogHinh.Filter = "Image File (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSinhVien";
            this.Text = "Demo SinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupboxTTSV.ResumeLayout(false);
            this.groupboxTTSV.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupboxDSSV.ResumeLayout(false);
            this.cmsListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupboxTTSV;
        private System.Windows.Forms.GroupBox groupboxDSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogHinh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSinhVien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMoFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuThem;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuListView;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuMauChu;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXep;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem mnuContextFont;
        private System.Windows.Forms.ToolStripMenuItem mnuContextMauChu;
        private System.Windows.Forms.ToolStripMenuItem mnuContextSapXep;
        private System.Windows.Forms.ToolStripMenuItem mnuContextTimKiem;
    }
}

