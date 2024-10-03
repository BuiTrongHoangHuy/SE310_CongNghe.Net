namespace WindowsFormsApp1
{
    partial class form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InputTextTenSP = new System.Windows.Forms.TextBox();
            this.InputTextDonGia = new System.Windows.Forms.TextBox();
            this.InputTextXuatXu = new System.Windows.Forms.TextBox();
            this.InputTextSoLuong = new System.Windows.Forms.TextBox();
            this.InputTextMaSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGVTimKiem = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputTextMaxPrice = new System.Windows.Forms.TextBox();
            this.InputTextMinPrice = new System.Windows.Forms.TextBox();
            this.btnXSPDGT = new System.Windows.Forms.Button();
            this.btnXTBQH = new System.Windows.Forms.Button();
            this.btnSPNB = new System.Windows.Forms.Button();
            this.btnSPDGCN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InputTextXX = new System.Windows.Forms.TextBox();
            this.btnXSPTXX = new System.Windows.Forms.Button();
            this.btnKTKQH = new System.Windows.Forms.Button();
            this.btnXoaToanBoQH = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.dataGVAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTimKiem)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnLuuSP);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.InputTextTenSP);
            this.panel1.Controls.Add(this.InputTextDonGia);
            this.panel1.Controls.Add(this.InputTextXuatXu);
            this.panel1.Controls.Add(this.InputTextSoLuong);
            this.panel1.Controls.Add(this.InputTextMaSP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 309);
            this.panel1.TabIndex = 0;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaSP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXoaSP.Location = new System.Drawing.Point(224, 259);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 12;
            this.btnXoaSP.Text = "Xóa SP";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BackColor = System.Drawing.SystemColors.Info;
            this.btnLuuSP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLuuSP.Location = new System.Drawing.Point(132, 259);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSP.TabIndex = 0;
            this.btnLuuSP.Text = "Lưu SP";
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSP_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // InputTextTenSP
            // 
            this.InputTextTenSP.Location = new System.Drawing.Point(132, 60);
            this.InputTextTenSP.Name = "InputTextTenSP";
            this.InputTextTenSP.Size = new System.Drawing.Size(167, 23);
            this.InputTextTenSP.TabIndex = 11;
            // 
            // InputTextDonGia
            // 
            this.InputTextDonGia.Location = new System.Drawing.Point(132, 140);
            this.InputTextDonGia.Name = "InputTextDonGia";
            this.InputTextDonGia.Size = new System.Drawing.Size(167, 23);
            this.InputTextDonGia.TabIndex = 10;
            // 
            // InputTextXuatXu
            // 
            this.InputTextXuatXu.Location = new System.Drawing.Point(132, 176);
            this.InputTextXuatXu.Name = "InputTextXuatXu";
            this.InputTextXuatXu.Size = new System.Drawing.Size(167, 23);
            this.InputTextXuatXu.TabIndex = 9;
            // 
            // InputTextSoLuong
            // 
            this.InputTextSoLuong.Location = new System.Drawing.Point(132, 101);
            this.InputTextSoLuong.Name = "InputTextSoLuong";
            this.InputTextSoLuong.Size = new System.Drawing.Size(167, 23);
            this.InputTextSoLuong.TabIndex = 8;
            // 
            // InputTextMaSP
            // 
            this.InputTextMaSP.Location = new System.Drawing.Point(132, 21);
            this.InputTextMaSP.Name = "InputTextMaSP";
            this.InputTextMaSP.Size = new System.Drawing.Size(167, 23);
            this.InputTextMaSP.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(23, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày hết hạn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(23, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Xuất xứ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(23, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn giá";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên SP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã SP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.dataGVTimKiem);
            this.panel2.Controls.Add(this.InputTextMaxPrice);
            this.panel2.Controls.Add(this.InputTextMinPrice);
            this.panel2.Controls.Add(this.btnXSPDGT);
            this.panel2.Controls.Add(this.btnXTBQH);
            this.panel2.Controls.Add(this.btnSPNB);
            this.panel2.Controls.Add(this.btnSPDGCN);
            this.panel2.Location = new System.Drawing.Point(394, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 309);
            this.panel2.TabIndex = 1;
            // 
            // dataGVTimKiem
            // 
            this.dataGVTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.XuatXu,
            this.NgayHetHan});
            this.dataGVTimKiem.Location = new System.Drawing.Point(36, 86);
            this.dataGVTimKiem.Name = "dataGVTimKiem";
            this.dataGVTimKiem.RowHeadersWidth = 51;
            this.dataGVTimKiem.RowTemplate.Height = 24;
            this.dataGVTimKiem.Size = new System.Drawing.Size(732, 196);
            this.dataGVTimKiem.TabIndex = 19;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // XuatXu
            // 
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.MinimumWidth = 6;
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.Width = 125;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Width = 125;
            // 
            // InputTextMaxPrice
            // 
            this.InputTextMaxPrice.Location = new System.Drawing.Point(718, 32);
            this.InputTextMaxPrice.Name = "InputTextMaxPrice";
            this.InputTextMaxPrice.Size = new System.Drawing.Size(50, 23);
            this.InputTextMaxPrice.TabIndex = 18;
            this.InputTextMaxPrice.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // InputTextMinPrice
            // 
            this.InputTextMinPrice.Location = new System.Drawing.Point(645, 32);
            this.InputTextMinPrice.Name = "InputTextMinPrice";
            this.InputTextMinPrice.Size = new System.Drawing.Size(51, 23);
            this.InputTextMinPrice.TabIndex = 17;
            // 
            // btnXSPDGT
            // 
            this.btnXSPDGT.BackColor = System.Drawing.SystemColors.Info;
            this.btnXSPDGT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXSPDGT.Location = new System.Drawing.Point(514, 21);
            this.btnXSPDGT.Name = "btnXSPDGT";
            this.btnXSPDGT.Size = new System.Drawing.Size(105, 45);
            this.btnXSPDGT.TabIndex = 16;
            this.btnXSPDGT.Text = "Xuất các SP có ĐG [a...b]";
            this.btnXSPDGT.UseVisualStyleBackColor = false;
            this.btnXSPDGT.Click += new System.EventHandler(this.btnXSPDGT_Click);
            // 
            // btnXTBQH
            // 
            this.btnXTBQH.BackColor = System.Drawing.SystemColors.Info;
            this.btnXTBQH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXTBQH.Location = new System.Drawing.Point(289, 21);
            this.btnXTBQH.Name = "btnXTBQH";
            this.btnXTBQH.Size = new System.Drawing.Size(98, 45);
            this.btnXTBQH.TabIndex = 15;
            this.btnXTBQH.Text = "Xuất toàn bộ SP quá hạn";
            this.btnXTBQH.UseVisualStyleBackColor = false;
            this.btnXTBQH.Click += new System.EventHandler(this.btnXTBQH_Click);
            // 
            // btnSPNB
            // 
            this.btnSPNB.BackColor = System.Drawing.SystemColors.Info;
            this.btnSPNB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSPNB.Location = new System.Drawing.Point(175, 21);
            this.btnSPNB.Name = "btnSPNB";
            this.btnSPNB.Size = new System.Drawing.Size(86, 45);
            this.btnSPNB.TabIndex = 14;
            this.btnSPNB.Text = "1 SP từ Nhật Bản";
            this.btnSPNB.UseVisualStyleBackColor = false;
            this.btnSPNB.Click += new System.EventHandler(this.btnSPNB_Click);
            // 
            // btnSPDGCN
            // 
            this.btnSPDGCN.BackColor = System.Drawing.SystemColors.Info;
            this.btnSPDGCN.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSPDGCN.Location = new System.Drawing.Point(36, 21);
            this.btnSPDGCN.Name = "btnSPDGCN";
            this.btnSPDGCN.Size = new System.Drawing.Size(111, 45);
            this.btnSPDGCN.TabIndex = 13;
            this.btnSPDGCN.Text = " 1 SP có ĐG cao nhất";
            this.btnSPDGCN.UseVisualStyleBackColor = false;
            this.btnSPDGCN.Click += new System.EventHandler(this.btnSPDGCN_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(717, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn chức năng tìm kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGVAll);
            this.panel3.Location = new System.Drawing.Point(12, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 273);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(896, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Chọn thao tác";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.InputTextXX);
            this.panel4.Controls.Add(this.btnXSPTXX);
            this.panel4.Controls.Add(this.btnKTKQH);
            this.panel4.Controls.Add(this.btnXoaToanBoQH);
            this.panel4.Controls.Add(this.btnXoaToanBo);
            this.panel4.Location = new System.Drawing.Point(819, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 269);
            this.panel4.TabIndex = 20;
            // 
            // InputTextXX
            // 
            this.InputTextXX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextXX.Location = new System.Drawing.Point(198, 30);
            this.InputTextXX.Name = "InputTextXX";
            this.InputTextXX.Size = new System.Drawing.Size(103, 45);
            this.InputTextXX.TabIndex = 18;
            // 
            // btnXSPTXX
            // 
            this.btnXSPTXX.BackColor = System.Drawing.SystemColors.Info;
            this.btnXSPTXX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXSPTXX.Location = new System.Drawing.Point(46, 30);
            this.btnXSPTXX.Name = "btnXSPTXX";
            this.btnXSPTXX.Size = new System.Drawing.Size(118, 49);
            this.btnXSPTXX.TabIndex = 16;
            this.btnXSPTXX.Text = "Xóa SP theo xuất xứ bất kỳ:";
            this.btnXSPTXX.UseVisualStyleBackColor = false;
            this.btnXSPTXX.Click += new System.EventHandler(this.btnXSPTXX_Click);
            // 
            // btnKTKQH
            // 
            this.btnKTKQH.BackColor = System.Drawing.SystemColors.Info;
            this.btnKTKQH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnKTKQH.Location = new System.Drawing.Point(46, 111);
            this.btnKTKQH.Name = "btnKTKQH";
            this.btnKTKQH.Size = new System.Drawing.Size(255, 49);
            this.btnKTKQH.TabIndex = 15;
            this.btnKTKQH.Text = "Kiểm tra kho SP có quá hạn không";
            this.btnKTKQH.UseVisualStyleBackColor = false;
            this.btnKTKQH.Click += new System.EventHandler(this.btnKTKQH_Click);
            // 
            // btnXoaToanBoQH
            // 
            this.btnXoaToanBoQH.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaToanBoQH.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXoaToanBoQH.Location = new System.Drawing.Point(180, 193);
            this.btnXoaToanBoQH.Name = "btnXoaToanBoQH";
            this.btnXoaToanBoQH.Size = new System.Drawing.Size(121, 47);
            this.btnXoaToanBoQH.TabIndex = 13;
            this.btnXoaToanBoQH.Text = "Xóa toàn bộ SP quá hạn";
            this.btnXoaToanBoQH.UseVisualStyleBackColor = false;
            this.btnXoaToanBoQH.Click += new System.EventHandler(this.btnXoaToanBoQH_Click);
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaToanBo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnXoaToanBo.Location = new System.Drawing.Point(46, 193);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(118, 47);
            this.btnXoaToanBo.TabIndex = 14;
            this.btnXoaToanBo.Text = "Xóa toàn bộ SP trong kho";
            this.btnXoaToanBo.UseVisualStyleBackColor = false;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // dataGVAll
            // 
            this.dataGVAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGVAll.Location = new System.Drawing.Point(15, 21);
            this.dataGVAll.Name = "dataGVAll";
            this.dataGVAll.RowHeadersWidth = 51;
            this.dataGVAll.RowTemplate.Height = 24;
            this.dataGVAll.Size = new System.Drawing.Size(798, 240);
            this.dataGVAll.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Xuất xứ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(27, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Danh sách các sản phẩm sau khi nhập";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 675);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LINQ to OBJECT - Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTimKiem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextTenSP;
        private System.Windows.Forms.TextBox InputTextDonGia;
        private System.Windows.Forms.TextBox InputTextXuatXu;
        private System.Windows.Forms.TextBox InputTextSoLuong;
        private System.Windows.Forms.TextBox InputTextMaSP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.TextBox InputTextMaxPrice;
        private System.Windows.Forms.TextBox InputTextMinPrice;
        private System.Windows.Forms.Button btnXSPDGT;
        private System.Windows.Forms.Button btnXTBQH;
        private System.Windows.Forms.Button btnSPNB;
        private System.Windows.Forms.Button btnSPDGCN;
        private System.Windows.Forms.DataGridView dataGVTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox InputTextXX;
        private System.Windows.Forms.Button btnXSPTXX;
        private System.Windows.Forms.DataGridView dataGVAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnKTKQH;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.Button btnXoaToanBoQH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

