namespace BTL
{
    partial class UserInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
			panel1 = new Panel();
			label1 = new Label();
			button7 = new Button();
			button4 = new Button();
			label2 = new Label();
			panel5 = new Panel();
			panel2 = new Panel();
			button10 = new Button();
			button9 = new Button();
			button8 = new Button();
			button5 = new Button();
			button3 = new Button();
			button1 = new Button();
			maHoSo = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			panel4 = new Panel();
			button2 = new Button();
			NgaySinh = new TextBox();
			DiaChi = new TextBox();
			Sdt = new TextBox();
			GioiTinh = new TextBox();
			HoVaTen = new TextBox();
			AnhHoSo = new PictureBox();
			panel6 = new Panel();
			fileSystemWatcher1 = new FileSystemWatcher();
			button6 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AnhHoSo).BeginInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 128, 255);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(panel5);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(5, 4, 5, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1195, 68);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(1014, 29);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(83, 20);
			label1.TabIndex = 22;
			label1.Text = "UserName";
			label1.VisibleChanged += lblTen_Load;
			// 
			// button7
			// 
			button7.FlatAppearance.BorderSize = 0;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.ForeColor = SystemColors.ControlText;
			button7.Image = Properties.Resources.icons8_find_24;
			button7.ImageAlign = ContentAlignment.MiddleLeft;
			button7.Location = new Point(760, 9);
			button7.Margin = new Padding(5, 4, 5, 4);
			button7.Name = "button7";
			button7.Size = new Size(178, 45);
			button7.TabIndex = 20;
			button7.Text = "      Tra cứu điểm";
			button7.TextAlign = ContentAlignment.MiddleLeft;
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button4
			// 
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button4.ForeColor = SystemColors.GrayText;
			button4.Image = Properties.Resources.icons8_user_50;
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(946, 3);
			button4.Margin = new Padding(5, 4, 5, 4);
			button4.Name = "button4";
			button4.Size = new Size(59, 60);
			button4.TabIndex = 14;
			button4.TextAlign = ContentAlignment.MiddleLeft;
			button4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(1013, 11);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 3;
			label2.Text = "Xin chào,";
			// 
			// panel5
			// 
			panel5.BorderStyle = BorderStyle.FixedSingle;
			panel5.Location = new Point(297, 68);
			panel5.Margin = new Padding(0);
			panel5.Name = "panel5";
			panel5.Size = new Size(899, 581);
			panel5.TabIndex = 19;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Window;
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(button10);
			panel2.Controls.Add(button9);
			panel2.Controls.Add(button8);
			panel2.Controls.Add(button5);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button1);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 68);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.Size = new Size(298, 580);
			panel2.TabIndex = 1;
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button10.ForeColor = SystemColors.GrayText;
			button10.Image = Properties.Resources.icons8_exit_48;
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(21, 468);
			button10.Margin = new Padding(5, 4, 5, 4);
			button10.Name = "button10";
			button10.Size = new Size(277, 85);
			button10.TabIndex = 6;
			button10.Text = "             Đăng xuất";
			button10.TextAlign = ContentAlignment.MiddleLeft;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// button9
			// 
			button9.FlatAppearance.BorderSize = 0;
			button9.FlatStyle = FlatStyle.Flat;
			button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button9.ForeColor = SystemColors.GrayText;
			button9.Image = Properties.Resources.icons8_support_50;
			button9.ImageAlign = ContentAlignment.MiddleLeft;
			button9.Location = new Point(19, 375);
			button9.Margin = new Padding(5, 4, 5, 4);
			button9.Name = "button9";
			button9.Size = new Size(277, 85);
			button9.TabIndex = 5;
			button9.Text = "             Hỗ trợ";
			button9.TextAlign = ContentAlignment.MiddleLeft;
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// button8
			// 
			button8.FlatAppearance.BorderSize = 0;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button8.ForeColor = SystemColors.GrayText;
			button8.Image = Properties.Resources.icons8_change_password_58;
			button8.ImageAlign = ContentAlignment.MiddleLeft;
			button8.Location = new Point(11, 189);
			button8.Margin = new Padding(5, 4, 5, 4);
			button8.Name = "button8";
			button8.Size = new Size(285, 85);
			button8.TabIndex = 4;
			button8.Text = "               Đổi mật khẩu";
			button8.TextAlign = ContentAlignment.MiddleLeft;
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button5
			// 
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button5.ForeColor = SystemColors.GrayText;
			button5.Image = Properties.Resources.icons8_payment_64;
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(7, 282);
			button5.Margin = new Padding(5, 4, 5, 4);
			button5.Name = "button5";
			button5.Size = new Size(289, 85);
			button5.TabIndex = 3;
			button5.Text = "               Thanh toán";
			button5.TextAlign = ContentAlignment.MiddleLeft;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button3.ForeColor = SystemColors.GrayText;
			button3.Image = Properties.Resources.icons8_create_64;
			button3.ImageAlign = ContentAlignment.TopLeft;
			button3.Location = new Point(11, 96);
			button3.Margin = new Padding(5, 4, 5, 4);
			button3.Name = "button3";
			button3.Size = new Size(285, 85);
			button3.TabIndex = 2;
			button3.Text = "               Nguyện vọng";
			button3.TextAlign = ContentAlignment.MiddleLeft;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button1.ForeColor = SystemColors.GrayText;
			button1.Image = Properties.Resources.icons8_building_100;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(5, 4);
			button1.Margin = new Padding(5, 4, 5, 4);
			button1.Name = "button1";
			button1.Size = new Size(292, 85);
			button1.TabIndex = 0;
			button1.Text = "                 Trang chủ";
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// maHoSo
			// 
			maHoSo.BackColor = SystemColors.ButtonHighlight;
			maHoSo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			maHoSo.Location = new Point(26, 57);
			maHoSo.Margin = new Padding(5, 4, 5, 4);
			maHoSo.Multiline = true;
			maHoSo.Name = "maHoSo";
			maHoSo.ReadOnly = true;
			maHoSo.Size = new Size(484, 41);
			maHoSo.TabIndex = 2;
			maHoSo.TextChanged += textBox1_TextChanged;
			maHoSo.VisibleChanged += HienUserId;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(26, 33);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(72, 20);
			label3.TabIndex = 5;
			label3.Text = "Mã hồ sơ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(26, 119);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(75, 20);
			label4.TabIndex = 6;
			label4.Text = "Họ và tên";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(26, 197);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(78, 20);
			label5.TabIndex = 7;
			label5.Text = "Ngày sinh";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(24, 281);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(67, 20);
			label6.TabIndex = 9;
			label6.Text = "Giới tính";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(278, 281);
			label7.Margin = new Padding(5, 0, 5, 0);
			label7.Name = "label7";
			label7.Size = new Size(99, 20);
			label7.TabIndex = 11;
			label7.Text = "Số điện thoại";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(26, 365);
			label8.Margin = new Padding(5, 0, 5, 0);
			label8.Name = "label8";
			label8.Size = new Size(56, 20);
			label8.TabIndex = 13;
			label8.Text = "Địa chỉ";
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.Window;
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Controls.Add(button2);
			panel4.Controls.Add(NgaySinh);
			panel4.Controls.Add(DiaChi);
			panel4.Controls.Add(Sdt);
			panel4.Controls.Add(GioiTinh);
			panel4.Controls.Add(HoVaTen);
			panel4.Controls.Add(AnhHoSo);
			panel4.Controls.Add(label8);
			panel4.Controls.Add(label7);
			panel4.Controls.Add(label6);
			panel4.Controls.Add(label5);
			panel4.Controls.Add(label4);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(maHoSo);
			panel4.Location = new Point(366, 131);
			panel4.Name = "panel4";
			panel4.Size = new Size(748, 463);
			panel4.TabIndex = 18;
			panel4.Paint += panel4_Paint;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
			button2.Location = new Point(548, 294);
			button2.Name = "button2";
			button2.Size = new Size(170, 54);
			button2.TabIndex = 29;
			button2.TabStop = false;
			button2.Text = "Mở bảng điểm";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// NgaySinh
			// 
			NgaySinh.BackColor = SystemColors.ButtonHighlight;
			NgaySinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			NgaySinh.Location = new Point(24, 221);
			NgaySinh.Margin = new Padding(5, 4, 5, 4);
			NgaySinh.Multiline = true;
			NgaySinh.Name = "NgaySinh";
			NgaySinh.ReadOnly = true;
			NgaySinh.Size = new Size(484, 41);
			NgaySinh.TabIndex = 28;
			NgaySinh.TextChanged += textBox5_TextChanged;
			NgaySinh.VisibleChanged += HienThongTin;
			// 
			// DiaChi
			// 
			DiaChi.BackColor = SystemColors.ButtonHighlight;
			DiaChi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			DiaChi.Location = new Point(26, 389);
			DiaChi.Margin = new Padding(5, 4, 5, 4);
			DiaChi.Multiline = true;
			DiaChi.Name = "DiaChi";
			DiaChi.ReadOnly = true;
			DiaChi.Size = new Size(484, 41);
			DiaChi.TabIndex = 27;
			DiaChi.TextChanged += DiaChi_TextChanged;
			DiaChi.VisibleChanged += HienThongTin;
			// 
			// Sdt
			// 
			Sdt.BackColor = SystemColors.ButtonHighlight;
			Sdt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			Sdt.Location = new Point(278, 307);
			Sdt.Margin = new Padding(5, 4, 5, 4);
			Sdt.Multiline = true;
			Sdt.Name = "Sdt";
			Sdt.ReadOnly = true;
			Sdt.Size = new Size(230, 41);
			Sdt.TabIndex = 26;
			Sdt.VisibleChanged += HienThongTin;
			// 
			// GioiTinh
			// 
			GioiTinh.BackColor = SystemColors.ButtonHighlight;
			GioiTinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			GioiTinh.Location = new Point(26, 307);
			GioiTinh.Margin = new Padding(5, 4, 5, 4);
			GioiTinh.Multiline = true;
			GioiTinh.Name = "GioiTinh";
			GioiTinh.ReadOnly = true;
			GioiTinh.Size = new Size(230, 41);
			GioiTinh.TabIndex = 25;
			GioiTinh.VisibleChanged += HienThongTin;
			// 
			// HoVaTen
			// 
			HoVaTen.BackColor = SystemColors.ButtonHighlight;
			HoVaTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
			HoVaTen.Location = new Point(24, 143);
			HoVaTen.Margin = new Padding(5, 4, 5, 4);
			HoVaTen.Multiline = true;
			HoVaTen.Name = "HoVaTen";
			HoVaTen.ReadOnly = true;
			HoVaTen.Size = new Size(484, 41);
			HoVaTen.TabIndex = 24;
			HoVaTen.TextChanged += textBox6_TextChanged;
			HoVaTen.VisibleChanged += HienThongTin;
			// 
			// AnhHoSo
			// 
			AnhHoSo.BorderStyle = BorderStyle.FixedSingle;
			AnhHoSo.Location = new Point(548, 57);
			AnhHoSo.Margin = new Padding(5, 4, 5, 4);
			AnhHoSo.Name = "AnhHoSo";
			AnhHoSo.Size = new Size(170, 205);
			AnhHoSo.SizeMode = PictureBoxSizeMode.StretchImage;
			AnhHoSo.TabIndex = 21;
			AnhHoSo.TabStop = false;
			AnhHoSo.VisibleChanged += HienThongTin;
			AnhHoSo.Click += pictureBox1_Click_1;
			// 
			// panel6
			// 
			panel6.BorderStyle = BorderStyle.FixedSingle;
			panel6.Location = new Point(297, 68);
			panel6.Margin = new Padding(0);
			panel6.Name = "panel6";
			panel6.Size = new Size(899, 581);
			panel6.TabIndex = 19;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// button6
			// 
			button6.Location = new Point(1205, 459);
			button6.Name = "button6";
			button6.Size = new Size(94, 29);
			button6.TabIndex = 20;
			button6.Text = "button6";
			button6.UseVisualStyleBackColor = true;
			// 
			// UserInterface
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(1195, 648);
			Controls.Add(button6);
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(panel6);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 4, 5, 4);
			MaximizeBox = false;
			Name = "UserInterface";
			StartPosition = FormStartPosition.CenterScreen;
			Load += UserInterface_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)AnhHoSo).EndInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Label label2;
        private Button button5;
        private Button button4;
        private TextBox maHoSo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox AnhHoSo;
        private Button button7;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox DiaChi;
        private TextBox Sdt;
        private TextBox GioiTinh;
        private TextBox HoVaTen;
        private TextBox NgaySinh;
        private Button button8;
        private Button button10;
        private Button button9;
		//private Button button2;
		private Button button6;
        private Button button2;
		private Label label1;
	}
}