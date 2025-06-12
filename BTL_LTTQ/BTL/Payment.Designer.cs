
namespace BTL
{
    partial class Payment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
			panel1 = new Panel();
			userid = new Label();
			button7 = new Button();
			button4 = new Button();
			label2 = new Label();
			panel5 = new Panel();
			button10 = new Button();
			button9 = new Button();
			button8 = new Button();
			button5 = new Button();
			button3 = new Button();
			button1 = new Button();
			panel2 = new Panel();
			panel4 = new Panel();
			NgaySinh = new TextBox();
			DiaChi = new TextBox();
			Sdt = new TextBox();
			HoVaTen = new TextBox();
			label8 = new Label();
			label7 = new Label();
			label5 = new Label();
			label9 = new Label();
			label4 = new Label();
			label1 = new Label();
			button6 = new Button();
			label3 = new Label();
			rbViettelMoney = new RadioButton();
			button2 = new Button();
			rbPayal = new RadioButton();
			rbChuyenKhoanNganHang = new RadioButton();
			rbTienMat = new RadioButton();
			panel3 = new Panel();
			panel6 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 128, 255);
			panel1.Controls.Add(userid);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(panel5);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(5, 4, 5, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1197, 68);
			panel1.TabIndex = 20;
			panel1.Paint += panel1_Paint;
			// 
			// userid
			// 
			userid.AutoSize = true;
			userid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			userid.Location = new Point(1013, 29);
			userid.Name = "userid";
			userid.Size = new Size(83, 20);
			userid.TabIndex = 22;
			userid.Text = "UserName";
			userid.VisibleChanged += lblTen_Load;
			userid.Click += label1_Click;
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
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button10.ForeColor = SystemColors.GrayText;
			button10.Image = Properties.Resources.icons8_exit_48;
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(20, 474);
			button10.Margin = new Padding(5, 4, 5, 4);
			button10.Name = "button10";
			button10.Size = new Size(276, 85);
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
			button9.Location = new Point(20, 381);
			button9.Margin = new Padding(5, 4, 5, 4);
			button9.Name = "button9";
			button9.Size = new Size(276, 85);
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
			button8.Location = new Point(12, 195);
			button8.Margin = new Padding(5, 4, 5, 4);
			button8.Name = "button8";
			button8.Size = new Size(284, 85);
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
			button5.Location = new Point(16, 288);
			button5.Margin = new Padding(5, 4, 5, 4);
			button5.Name = "button5";
			button5.Size = new Size(280, 85);
			button5.TabIndex = 3;
			button5.Text = "              Thanh toán";
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
			button3.Location = new Point(16, 103);
			button3.Margin = new Padding(5, 4, 5, 4);
			button3.Name = "button3";
			button3.Size = new Size(280, 85);
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
			button1.Location = new Point(5, 10);
			button1.Margin = new Padding(5, 4, 5, 4);
			button1.Name = "button1";
			button1.Size = new Size(291, 85);
			button1.TabIndex = 0;
			button1.Text = "                 Trang chủ";
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Window;
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 64);
			panel2.Margin = new Padding(0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1197, 581);
			panel2.TabIndex = 21;
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Controls.Add(NgaySinh);
			panel4.Controls.Add(DiaChi);
			panel4.Controls.Add(Sdt);
			panel4.Controls.Add(HoVaTen);
			panel4.Controls.Add(label8);
			panel4.Controls.Add(label7);
			panel4.Controls.Add(label5);
			panel4.Controls.Add(label9);
			panel4.Controls.Add(label4);
			panel4.Controls.Add(label1);
			panel4.Controls.Add(button6);
			panel4.Controls.Add(label3);
			panel4.Controls.Add(rbViettelMoney);
			panel4.Controls.Add(button2);
			panel4.Controls.Add(rbPayal);
			panel4.Controls.Add(rbChuyenKhoanNganHang);
			panel4.Controls.Add(rbTienMat);
			panel4.Location = new Point(296, 0);
			panel4.Margin = new Padding(0);
			panel4.Name = "panel4";
			panel4.Size = new Size(900, 578);
			panel4.TabIndex = 8;
			// 
			// NgaySinh
			// 
			NgaySinh.BackColor = SystemColors.ButtonHighlight;
			NgaySinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			NgaySinh.Location = new Point(96, 304);
			NgaySinh.Margin = new Padding(5, 4, 5, 4);
			NgaySinh.Multiline = true;
			NgaySinh.Name = "NgaySinh";
			NgaySinh.ReadOnly = true;
			NgaySinh.Size = new Size(177, 33);
			NgaySinh.TabIndex = 40;
			NgaySinh.VisibleChanged += HienThongTin;
			// 
			// DiaChi
			// 
			DiaChi.BackColor = SystemColors.ButtonHighlight;
			DiaChi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			DiaChi.Location = new Point(96, 374);
			DiaChi.Margin = new Padding(5, 4, 5, 4);
			DiaChi.Multiline = true;
			DiaChi.Name = "DiaChi";
			DiaChi.ReadOnly = true;
			DiaChi.Size = new Size(327, 33);
			DiaChi.TabIndex = 39;
			DiaChi.VisibleChanged += HienThongTin;
			// 
			// Sdt
			// 
			Sdt.BackColor = SystemColors.ButtonHighlight;
			Sdt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			Sdt.Location = new Point(283, 304);
			Sdt.Margin = new Padding(5, 4, 5, 4);
			Sdt.Multiline = true;
			Sdt.Name = "Sdt";
			Sdt.ReadOnly = true;
			Sdt.Size = new Size(140, 33);
			Sdt.TabIndex = 38;
			Sdt.VisibleChanged += HienThongTin;
			// 
			// HoVaTen
			// 
			HoVaTen.BackColor = SystemColors.ButtonHighlight;
			HoVaTen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			HoVaTen.Location = new Point(96, 233);
			HoVaTen.Margin = new Padding(5, 4, 5, 4);
			HoVaTen.Multiline = true;
			HoVaTen.Name = "HoVaTen";
			HoVaTen.ReadOnly = true;
			HoVaTen.Size = new Size(327, 33);
			HoVaTen.TabIndex = 36;
			HoVaTen.VisibleChanged += HienThongTin;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = SystemColors.ControlDark;
			label8.Location = new Point(96, 350);
			label8.Margin = new Padding(5, 0, 5, 0);
			label8.Name = "label8";
			label8.Size = new Size(56, 20);
			label8.TabIndex = 35;
			label8.Text = "Địa chỉ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = SystemColors.ControlDark;
			label7.Location = new Point(283, 280);
			label7.Margin = new Padding(5, 0, 5, 0);
			label7.Name = "label7";
			label7.Size = new Size(99, 20);
			label7.TabIndex = 34;
			label7.Text = "Số điện thoại";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.ControlDark;
			label5.Location = new Point(98, 280);
			label5.Margin = new Padding(5, 0, 5, 0);
			label5.Name = "label5";
			label5.Size = new Size(78, 20);
			label5.TabIndex = 32;
			label5.Text = "Ngày sinh";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.ForeColor = SystemColors.ControlDark;
			label9.Location = new Point(98, 209);
			label9.Margin = new Padding(5, 0, 5, 0);
			label9.Name = "label9";
			label9.Size = new Size(75, 20);
			label9.TabIndex = 31;
			label9.Text = "Họ và tên";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(96, 175);
			label4.Name = "label4";
			label4.Size = new Size(213, 28);
			label4.TabIndex = 10;
			label4.Text = "Thông tin khách hàng";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ControlDark;
			label1.Location = new Point(249, 108);
			label1.Name = "label1";
			label1.Size = new Size(402, 20);
			label1.TabIndex = 9;
			label1.Text = "Vui lòng kiểm tra lại thông tin trước khi nhấn thanh toán!";
			// 
			// button6
			// 
			button6.BackgroundImageLayout = ImageLayout.Zoom;
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.Image = Properties.Resources.icons8_pay_1001;
			button6.Location = new Point(309, 19);
			button6.Name = "button6";
			button6.Size = new Size(252, 94);
			button6.TabIndex = 8;
			button6.Text = " Thanh Toán";
			button6.TextImageRelation = TextImageRelation.ImageBeforeText;
			button6.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(467, 175);
			label3.Name = "label3";
			label3.Size = new Size(341, 28);
			label3.TabIndex = 6;
			label3.Text = "Hãy Chọn Phương Thức Thanh Toán";
			// 
			// rbViettelMoney
			// 
			rbViettelMoney.AutoSize = true;
			rbViettelMoney.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbViettelMoney.Location = new Point(470, 233);
			rbViettelMoney.Name = "rbViettelMoney";
			rbViettelMoney.Size = new Size(126, 24);
			rbViettelMoney.TabIndex = 4;
			rbViettelMoney.TabStop = true;
			rbViettelMoney.Text = "Viettel Money";
			rbViettelMoney.UseVisualStyleBackColor = true;
			rbViettelMoney.CheckedChanged += radioButton5_CheckedChanged;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Highlight;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(96, 439);
			button2.Name = "button2";
			button2.Size = new Size(712, 47);
			button2.TabIndex = 5;
			button2.Text = "Thanh Toán";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// rbPayal
			// 
			rbPayal.AutoSize = true;
			rbPayal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbPayal.Location = new Point(470, 375);
			rbPayal.Name = "rbPayal";
			rbPayal.Size = new Size(76, 24);
			rbPayal.TabIndex = 3;
			rbPayal.TabStop = true;
			rbPayal.Text = "Paypal";
			rbPayal.UseVisualStyleBackColor = true;
			rbPayal.CheckedChanged += rbPayal_CheckedChanged;
			// 
			// rbChuyenKhoanNganHang
			// 
			rbChuyenKhoanNganHang.AutoSize = true;
			rbChuyenKhoanNganHang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbChuyenKhoanNganHang.Location = new Point(470, 280);
			rbChuyenKhoanNganHang.Name = "rbChuyenKhoanNganHang";
			rbChuyenKhoanNganHang.Size = new Size(207, 24);
			rbChuyenKhoanNganHang.TabIndex = 1;
			rbChuyenKhoanNganHang.TabStop = true;
			rbChuyenKhoanNganHang.Text = "Chuyển khoản ngân hàng";
			rbChuyenKhoanNganHang.UseVisualStyleBackColor = true;
			rbChuyenKhoanNganHang.CheckedChanged += rbChuyenKhoanNganHang_CheckedChanged;
			// 
			// rbTienMat
			// 
			rbTienMat.AutoSize = true;
			rbTienMat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbTienMat.Location = new Point(470, 327);
			rbTienMat.Name = "rbTienMat";
			rbTienMat.Size = new Size(75, 24);
			rbTienMat.TabIndex = 2;
			rbTienMat.TabStop = true;
			rbTienMat.Text = "Momo";
			rbTienMat.UseVisualStyleBackColor = true;
			rbTienMat.CheckedChanged += rbTienMat_CheckedChanged;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(button1);
			panel3.Controls.Add(button5);
			panel3.Controls.Add(button10);
			panel3.Controls.Add(button3);
			panel3.Controls.Add(button9);
			panel3.Controls.Add(button8);
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Margin = new Padding(0);
			panel3.Name = "panel3";
			panel3.Size = new Size(297, 579);
			panel3.TabIndex = 7;
			// 
			// panel6
			// 
			panel6.BorderStyle = BorderStyle.FixedSingle;
			panel6.Location = new Point(297, 68);
			panel6.Margin = new Padding(0);
			panel6.Name = "panel6";
			panel6.Size = new Size(899, 581);
			panel6.TabIndex = 22;
			// 
			// Payment
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1197, 645);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Controls.Add(panel6);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MaximumSize = new Size(1215, 692);
			Name = "Payment";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Payment_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		private void GetHoTen(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private Panel panel1;
        private Button button7;
        private Button button4;
        private Label label2;
        private Panel panel5;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button5;
        private Button button3;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel4;
        private Label label3;
        private Button button2;
		private RadioButton rbViettelMoney;
		private RadioButton rbPayal;
		private RadioButton rbTienMat;
		private RadioButton rbChuyenKhoanNganHang;
		private Label userid;
		private Button button6;
		private Label label4;
		private Label label1;
		private TextBox NgaySinh;
		private TextBox DiaChi;
		private TextBox Sdt;
		private TextBox HoVaTen;
		private Label label8;
		private Label label7;
		private Label label5;
		private Label label9;
	}
}