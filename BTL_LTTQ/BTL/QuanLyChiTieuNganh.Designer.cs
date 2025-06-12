namespace BTL
{
    partial class QuanLyChiTieuNganh
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChiTieuNganh));
			panel4 = new Panel();
			btnQLD = new Button();
			button1 = new Button();
			button5 = new Button();
			button2 = new Button();
			button4 = new Button();
			button3 = new Button();
			button7 = new Button();
			button6 = new Button();
			panel2 = new Panel();
			panel3 = new Panel();
			panel1 = new Panel();
			txtTTNV = new TextBox();
			lblTTNV = new Label();
			txtTHXT = new TextBox();
			lblTHXT = new Label();
			txtDXT = new TextBox();
			lblDXT = new Label();
			button16 = new Button();
			textBox4 = new TextBox();
			label5 = new Label();
			button15 = new Button();
			dataGridView1 = new DataGridView();
			textBox3 = new TextBox();
			label4 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			button14 = new Button();
			button10 = new Button();
			comboBox1 = new ComboBox();
			button11 = new Button();
			label1 = new Label();
			button9 = new Button();
			button12 = new Button();
			button8 = new Button();
			saveFileDialog1 = new SaveFileDialog();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.Window;
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Controls.Add(btnQLD);
			panel4.Controls.Add(button1);
			panel4.Controls.Add(button5);
			panel4.Controls.Add(button2);
			panel4.Controls.Add(button4);
			panel4.Controls.Add(button3);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(0, 0);
			panel4.Margin = new Padding(0);
			panel4.Name = "panel4";
			panel4.Size = new Size(413, 641);
			panel4.TabIndex = 11;
			panel4.Paint += panel4_Paint;
			// 
			// btnQLD
			// 
			btnQLD.FlatAppearance.BorderSize = 0;
			btnQLD.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQLD.ForeColor = Color.Black;
			btnQLD.Image = Properties.Resources.icons8_user_50;
			btnQLD.ImageAlign = ContentAlignment.MiddleLeft;
			btnQLD.Location = new Point(10, 351);
			btnQLD.Name = "btnQLD";
			btnQLD.Size = new Size(383, 77);
			btnQLD.TabIndex = 16;
			btnQLD.Text = "               Quản lý điểm";
			btnQLD.TextAlign = ContentAlignment.MiddleLeft;
			btnQLD.UseVisualStyleBackColor = true;
			btnQLD.Click += btnQLD_Click;
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Black;
			button1.Image = Properties.Resources.icons8_manager_60;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(12, 72);
			button1.Name = "button1";
			button1.Size = new Size(384, 77);
			button1.TabIndex = 11;
			button1.Text = "                Quản lý hồ sơ";
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button5
			// 
			button5.FlatAppearance.BorderSize = 0;
			button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.ForeColor = Color.Black;
			button5.Image = Properties.Resources.icons8_support_50;
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(9, 535);
			button5.Name = "button5";
			button5.Size = new Size(383, 77);
			button5.TabIndex = 15;
			button5.Text = "              Quản lý hỗ trợ";
			button5.TextAlign = ContentAlignment.MiddleLeft;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button2
			// 
			button2.FlatAppearance.BorderSize = 0;
			button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Black;
			button2.Image = Properties.Resources.icons8_device_manager_64;
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(12, 164);
			button2.Name = "button2";
			button2.Size = new Size(384, 77);
			button2.TabIndex = 12;
			button2.Text = "                Quản lý ngành học";
			button2.TextAlign = ContentAlignment.MiddleLeft;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button4
			// 
			button4.FlatAppearance.BorderSize = 0;
			button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Black;
			button4.Image = Properties.Resources.icons8_exam_64;
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(9, 443);
			button4.Name = "button4";
			button4.Size = new Size(383, 77);
			button4.TabIndex = 14;
			button4.Text = "                Quản lý chỉ tiêu ngành  ";
			button4.TextAlign = ContentAlignment.MiddleLeft;
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderSize = 0;
			button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.Black;
			button3.Image = Properties.Resources.icons8_payment_64;
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(12, 259);
			button3.Name = "button3";
			button3.Size = new Size(383, 77);
			button3.TabIndex = 13;
			button3.Text = "                Quản lý thanh toán";
			button3.TextAlign = ContentAlignment.MiddleLeft;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button7
			// 
			button7.FlatAppearance.BorderSize = 0;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.ForeColor = SystemColors.ControlLightLight;
			button7.Image = Properties.Resources.icons8_menu_32;
			button7.ImageAlign = ContentAlignment.MiddleLeft;
			button7.Location = new Point(1, 1);
			button7.Margin = new Padding(5, 4, 5, 4);
			button7.Name = "button7";
			button7.Size = new Size(259, 61);
			button7.TabIndex = 13;
			button7.Text = "      Danh mục quản lý";
			button7.TextAlign = ContentAlignment.MiddleLeft;
			button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.ForeColor = SystemColors.ControlLightLight;
			button6.Image = Properties.Resources.icons8_exit_48;
			button6.ImageAlign = ContentAlignment.MiddleLeft;
			button6.Location = new Point(1042, 1);
			button6.Margin = new Padding(5, 4, 5, 4);
			button6.Name = "button6";
			button6.Size = new Size(150, 61);
			button6.TabIndex = 12;
			button6.Text = "        Đăng xuất";
			button6.TextAlign = ContentAlignment.MiddleLeft;
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.RoyalBlue;
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button6);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1197, 67);
			panel2.TabIndex = 14;
			// 
			// panel3
			// 
			panel3.Location = new Point(0, 63);
			panel3.Name = "panel3";
			panel3.Size = new Size(371, 491);
			panel3.TabIndex = 11;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Window;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(txtTTNV);
			panel1.Controls.Add(lblTTNV);
			panel1.Controls.Add(txtTHXT);
			panel1.Controls.Add(lblTHXT);
			panel1.Controls.Add(txtDXT);
			panel1.Controls.Add(lblDXT);
			panel1.Controls.Add(button16);
			panel1.Controls.Add(textBox4);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(button15);
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(textBox3);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(button14);
			panel1.Controls.Add(button10);
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(button11);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button12);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(panel4);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1197, 643);
			panel1.TabIndex = 13;
			// 
			// txtTTNV
			// 
			txtTTNV.BackColor = Color.FromArgb(235, 230, 255);
			txtTTNV.BorderStyle = BorderStyle.None;
			txtTTNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			txtTTNV.ForeColor = Color.FromArgb(100, 100, 180);
			txtTTNV.Location = new Point(946, 536);
			txtTTNV.Margin = new Padding(0);
			txtTTNV.Multiline = true;
			txtTTNV.Name = "txtTTNV";
			txtTTNV.Size = new Size(250, 27);
			txtTTNV.TabIndex = 46;
			// 
			// lblTTNV
			// 
			lblTTNV.AutoSize = true;
			lblTTNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTTNV.ForeColor = Color.FromArgb(100, 100, 180);
			lblTTNV.Location = new Point(946, 513);
			lblTTNV.Name = "lblTTNV";
			lblTTNV.Size = new Size(173, 23);
			lblTTNV.TabIndex = 47;
			lblTTNV.Text = "Thứ tự nguyện vọng";
			// 
			// txtTHXT
			// 
			txtTHXT.BackColor = Color.FromArgb(235, 230, 255);
			txtTHXT.BorderStyle = BorderStyle.None;
			txtTHXT.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			txtTHXT.ForeColor = Color.FromArgb(100, 100, 180);
			txtTHXT.Location = new Point(693, 536);
			txtTHXT.Margin = new Padding(0);
			txtTHXT.Multiline = true;
			txtTHXT.Name = "txtTHXT";
			txtTHXT.Size = new Size(240, 27);
			txtTHXT.TabIndex = 44;
			// 
			// lblTHXT
			// 
			lblTHXT.AutoSize = true;
			lblTHXT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTHXT.ForeColor = Color.FromArgb(100, 100, 180);
			lblTHXT.Location = new Point(693, 513);
			lblTHXT.Name = "lblTHXT";
			lblTHXT.Size = new Size(147, 23);
			lblTHXT.TabIndex = 45;
			lblTHXT.Text = "Tổ hợp xét tuyển";
			// 
			// txtDXT
			// 
			txtDXT.BackColor = Color.FromArgb(235, 230, 255);
			txtDXT.BorderStyle = BorderStyle.None;
			txtDXT.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			txtDXT.ForeColor = Color.FromArgb(100, 100, 180);
			txtDXT.Location = new Point(413, 536);
			txtDXT.Margin = new Padding(0);
			txtDXT.Multiline = true;
			txtDXT.Name = "txtDXT";
			txtDXT.Size = new Size(270, 27);
			txtDXT.TabIndex = 42;
			// 
			// lblDXT
			// 
			lblDXT.AutoSize = true;
			lblDXT.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDXT.ForeColor = Color.FromArgb(100, 100, 180);
			lblDXT.Location = new Point(416, 513);
			lblDXT.Name = "lblDXT";
			lblDXT.Size = new Size(133, 23);
			lblDXT.TabIndex = 43;
			lblDXT.Text = "Điểm xét tuyển";
			// 
			// button16
			// 
			button16.BackColor = Color.Transparent;
			button16.BackgroundImageLayout = ImageLayout.Zoom;
			button16.Cursor = Cursors.IBeam;
			button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button16.ForeColor = Color.FromArgb(100, 100, 180);
			button16.Location = new Point(424, 572);
			button16.Margin = new Padding(0);
			button16.Name = "button16";
			button16.Size = new Size(123, 57);
			button16.TabIndex = 41;
			button16.Text = "Nhập từ Excel";
			button16.UseVisualStyleBackColor = false;
			button16.Click += button16_Click;
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.FromArgb(235, 230, 255);
			textBox4.BorderStyle = BorderStyle.None;
			textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			textBox4.ForeColor = Color.FromArgb(100, 100, 180);
			textBox4.Location = new Point(946, 486);
			textBox4.Margin = new Padding(0);
			textBox4.Multiline = true;
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(250, 27);
			textBox4.TabIndex = 39;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.FromArgb(100, 100, 180);
			label5.Location = new Point(946, 463);
			label5.Name = "label5";
			label5.Size = new Size(127, 23);
			label5.TabIndex = 40;
			label5.Text = "Mã ngành mới";
			label5.Click += label5_Click;
			// 
			// button15
			// 
			button15.BackColor = Color.Transparent;
			button15.BackgroundImageLayout = ImageLayout.Zoom;
			button15.Cursor = Cursors.IBeam;
			button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button15.ForeColor = Color.FromArgb(100, 100, 180);
			button15.Location = new Point(547, 572);
			button15.Margin = new Padding(0);
			button15.Name = "button15";
			button15.Size = new Size(123, 57);
			button15.TabIndex = 38;
			button15.Text = "Tìm Kiếm";
			button15.UseVisualStyleBackColor = false;
			button15.Click += button15_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = SystemColors.Window;
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.GridColor = Color.Honeydew;
			dataGridView1.Location = new Point(413, 57);
			dataGridView1.Margin = new Padding(0);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RightToLeft = RightToLeft.No;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.ScrollBars = ScrollBars.None;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(782, 399);
			dataGridView1.TabIndex = 12;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.FromArgb(235, 230, 255);
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			textBox3.ForeColor = Color.FromArgb(100, 100, 180);
			textBox3.Location = new Point(693, 486);
			textBox3.Margin = new Padding(0);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(240, 27);
			textBox3.TabIndex = 36;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.FromArgb(100, 100, 180);
			label4.Location = new Point(693, 463);
			label4.Name = "label4";
			label4.Size = new Size(113, 23);
			label4.TabIndex = 37;
			label4.Text = "Mã ngành cũ";
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(235, 230, 255);
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			textBox2.ForeColor = Color.FromArgb(100, 100, 180);
			textBox2.Location = new Point(413, 486);
			textBox2.Margin = new Padding(0);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Nhập mã hồ sơ để tìm kiếm ở đây!!!";
			textBox2.Size = new Size(270, 27);
			textBox2.TabIndex = 34;
			textBox2.MouseClick += textBox2_MouseClick;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.FromArgb(100, 100, 180);
			label3.Location = new Point(416, 463);
			label3.Name = "label3";
			label3.Size = new Size(83, 23);
			label3.TabIndex = 35;
			label3.Text = "Mã hồ sơ";
			// 
			// button14
			// 
			button14.BackgroundImageLayout = ImageLayout.Zoom;
			button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button14.ForeColor = Color.FromArgb(100, 100, 180);
			button14.Location = new Point(673, 572);
			button14.Margin = new Padding(3, 4, 3, 4);
			button14.Name = "button14";
			button14.Size = new Size(121, 57);
			button14.TabIndex = 33;
			button14.Text = "Sửa";
			button14.UseVisualStyleBackColor = true;
			button14.Click += button14_Click;
			// 
			// button10
			// 
			button10.BackgroundImageLayout = ImageLayout.Zoom;
			button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button10.ForeColor = Color.FromArgb(100, 100, 180);
			button10.Location = new Point(1050, 572);
			button10.Margin = new Padding(3, 4, 3, 4);
			button10.Name = "button10";
			button10.Size = new Size(121, 57);
			button10.TabIndex = 31;
			button10.Text = "Xuất Excel";
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.FromArgb(235, 230, 255);
			comboBox1.FlatStyle = FlatStyle.Flat;
			comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
			comboBox1.ForeColor = Color.FromArgb(100, 100, 180);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(413, 536);
			comboBox1.Margin = new Padding(0);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(781, 28);
			comboBox1.TabIndex = 24;
			// 
			// button11
			// 
			button11.BackgroundImageLayout = ImageLayout.Zoom;
			button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button11.ForeColor = Color.FromArgb(100, 100, 180);
			button11.Location = new Point(800, 572);
			button11.Margin = new Padding(3, 4, 3, 4);
			button11.Name = "button11";
			button11.Size = new Size(121, 58);
			button11.TabIndex = 27;
			button11.Text = "Xóa";
			button11.UseVisualStyleBackColor = true;
			button11.Click += button11_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(100, 100, 180);
			label1.Location = new Point(413, 513);
			label1.Name = "label1";
			label1.Size = new Size(100, 23);
			label1.TabIndex = 25;
			label1.Text = "Tên Ngành ";
			// 
			// button9
			// 
			button9.BackColor = Color.Transparent;
			button9.BackgroundImageLayout = ImageLayout.Zoom;
			button9.Cursor = Cursors.IBeam;
			button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.ForeColor = Color.FromArgb(100, 100, 180);
			button9.Location = new Point(924, 572);
			button9.Margin = new Padding(0);
			button9.Name = "button9";
			button9.Size = new Size(123, 57);
			button9.TabIndex = 26;
			button9.Text = "DS Trúng Tuyển";
			button9.UseVisualStyleBackColor = false;
			button9.Click += button9_Click;
			// 
			// button12
			// 
			button12.Location = new Point(0, 0);
			button12.Margin = new Padding(3, 4, 3, 4);
			button12.Name = "button12";
			button12.Size = new Size(86, 31);
			button12.TabIndex = 19;
			button12.Text = "button12";
			button12.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			button8.Location = new Point(0, 0);
			button8.Margin = new Padding(3, 4, 3, 4);
			button8.Name = "button8";
			button8.Size = new Size(86, 31);
			button8.TabIndex = 15;
			button8.Text = "button8";
			button8.UseVisualStyleBackColor = true;
			// 
			// QuanLyChiTieuNganh
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1197, 648);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "QuanLyChiTieuNganh";
			StartPosition = FormStartPosition.CenterScreen;
			panel4.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel4;
        private Button button7;
        private Button button6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button8;
        private Button button12;
		private SaveFileDialog saveFileDialog1;
		private DataGridView dataGridView1;
		private Button button10;
		private ComboBox comboBox1;
		private Button button11;
		private Button button9;
		private Label label1;
		private Button button14;
		private TextBox textBox3;
		private Label label4;
		private TextBox textBox2;
		private Label label3;
		private Button button15;
		private TextBox textBox4;
		private Label label5;
		private Button button16;
		private Button btnQLD;
		private TextBox txtTTNV;
		private Label lblTTNV;
		private TextBox txtTHXT;
		private Label lblTHXT;
		private TextBox txtDXT;
		private Label lblDXT;
	}
}