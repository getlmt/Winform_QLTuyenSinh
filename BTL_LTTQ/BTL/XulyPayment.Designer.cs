namespace BTL
{
    partial class XulyPayment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XulyPayment));
			panel3 = new Panel();
			btnLuu = new Button();
			txtSoTienThanhToan = new TextBox();
			txtHinhThucThanhToan = new TextBox();
			txtMaHoSo = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pbBienLai = new PictureBox();
			panel1 = new Panel();
			button1 = new Button();
			button9 = new Button();
			button10 = new Button();
			button3 = new Button();
			button8 = new Button();
			button5 = new Button();
			panel2 = new Panel();
			panel4 = new Panel();
			label5 = new Label();
			button7 = new Button();
			button4 = new Button();
			lblTen = new Label();
			label6 = new Label();
			panel5 = new Panel();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbBienLai).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.BackColor = SystemColors.ButtonHighlight;
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(btnLuu);
			panel3.Controls.Add(txtSoTienThanhToan);
			panel3.Controls.Add(txtHinhThucThanhToan);
			panel3.Controls.Add(txtMaHoSo);
			panel3.Controls.Add(label4);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(pbBienLai);
			panel3.Controls.Add(panel1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Margin = new Padding(0);
			panel3.Name = "panel3";
			panel3.Size = new Size(1197, 645);
			panel3.TabIndex = 8;
			panel3.Paint += panel3_Paint;
			// 
			// btnLuu
			// 
			btnLuu.BackColor = SystemColors.Highlight;
			btnLuu.FlatStyle = FlatStyle.Flat;
			btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLuu.ForeColor = SystemColors.ButtonHighlight;
			btnLuu.Location = new Point(379, 523);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(130, 49);
			btnLuu.TabIndex = 27;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// txtSoTienThanhToan
			// 
			txtSoTienThanhToan.BackColor = SystemColors.ButtonHighlight;
			txtSoTienThanhToan.Location = new Point(379, 436);
			txtSoTienThanhToan.Multiline = true;
			txtSoTienThanhToan.Name = "txtSoTienThanhToan";
			txtSoTienThanhToan.ReadOnly = true;
			txtSoTienThanhToan.Size = new Size(415, 51);
			txtSoTienThanhToan.TabIndex = 26;
			txtSoTienThanhToan.VisibleChanged += txtSoTienThanhToan_VisibleChanged;
			// 
			// txtHinhThucThanhToan
			// 
			txtHinhThucThanhToan.Location = new Point(379, 311);
			txtHinhThucThanhToan.Multiline = true;
			txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
			txtHinhThucThanhToan.Size = new Size(415, 51);
			txtHinhThucThanhToan.TabIndex = 25;
			// 
			// txtMaHoSo
			// 
			txtMaHoSo.BackColor = SystemColors.ButtonHighlight;
			txtMaHoSo.Location = new Point(379, 196);
			txtMaHoSo.Multiline = true;
			txtMaHoSo.Name = "txtMaHoSo";
			txtMaHoSo.ReadOnly = true;
			txtMaHoSo.Size = new Size(415, 51);
			txtMaHoSo.TabIndex = 24;
			txtMaHoSo.VisibleChanged += ShowMaHoSo;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label4.Location = new Point(1070, 173);
			label4.Name = "label4";
			label4.Size = new Size(59, 20);
			label4.TabIndex = 22;
			label4.Text = "Biên lai";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label3.Location = new Point(379, 413);
			label3.Name = "label3";
			label3.Size = new Size(139, 20);
			label3.TabIndex = 21;
			label3.Text = "Số tiền thanh toán ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label2.Location = new Point(379, 288);
			label2.Name = "label2";
			label2.Size = new Size(155, 20);
			label2.TabIndex = 20;
			label2.Text = "Hình thức thanh toán";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label1.Location = new Point(379, 173);
			label1.Name = "label1";
			label1.Size = new Size(72, 20);
			label1.TabIndex = 19;
			label1.Text = "Mã hồ sơ";
			// 
			// pbBienLai
			// 
			pbBienLai.BackColor = SystemColors.ControlLightLight;
			pbBienLai.BorderStyle = BorderStyle.FixedSingle;
			pbBienLai.Location = new Point(824, 196);
			pbBienLai.Name = "pbBienLai";
			pbBienLai.Size = new Size(305, 291);
			pbBienLai.TabIndex = 23;
			pbBienLai.TabStop = false;
			pbBienLai.Click += pbBienLai_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ButtonHighlight;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button10);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button5);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.MaximumSize = new Size(970, 639);
			panel1.Name = "panel1";
			panel1.Size = new Size(305, 639);
			panel1.TabIndex = 9;
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button1.ForeColor = SystemColors.GrayText;
			button1.Image = Properties.Resources.icons8_building_100;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(9, 74);
			button1.Margin = new Padding(5, 4, 5, 4);
			button1.Name = "button1";
			button1.Size = new Size(295, 85);
			button1.TabIndex = 27;
			button1.Text = "                 Trang chủ";
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button9
			// 
			button9.FlatAppearance.BorderSize = 0;
			button9.FlatStyle = FlatStyle.Flat;
			button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button9.ForeColor = SystemColors.GrayText;
			button9.Image = Properties.Resources.icons8_support_50;
			button9.ImageAlign = ContentAlignment.MiddleLeft;
			button9.Location = new Point(27, 446);
			button9.Margin = new Padding(5, 4, 5, 4);
			button9.Name = "button9";
			button9.Size = new Size(277, 85);
			button9.TabIndex = 31;
			button9.Text = "             Hỗ trợ";
			button9.TextAlign = ContentAlignment.MiddleLeft;
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button10.ForeColor = SystemColors.GrayText;
			button10.Image = Properties.Resources.icons8_exit_48;
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(27, 539);
			button10.Margin = new Padding(5, 4, 5, 4);
			button10.Name = "button10";
			button10.Size = new Size(277, 85);
			button10.TabIndex = 32;
			button10.Text = "             Đăng xuất";
			button10.TextAlign = ContentAlignment.MiddleLeft;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button3.ForeColor = SystemColors.GrayText;
			button3.Image = Properties.Resources.icons8_create_64;
			button3.ImageAlign = ContentAlignment.TopLeft;
			button3.Location = new Point(18, 167);
			button3.Margin = new Padding(5, 4, 5, 4);
			button3.Name = "button3";
			button3.Size = new Size(286, 85);
			button3.TabIndex = 28;
			button3.Text = "               Nguyện vọng";
			button3.TextAlign = ContentAlignment.MiddleLeft;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button8
			// 
			button8.FlatAppearance.BorderSize = 0;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			button8.ForeColor = SystemColors.GrayText;
			button8.Image = Properties.Resources.icons8_change_password_58;
			button8.ImageAlign = ContentAlignment.MiddleLeft;
			button8.Location = new Point(18, 260);
			button8.Margin = new Padding(5, 4, 5, 4);
			button8.Name = "button8";
			button8.Size = new Size(286, 85);
			button8.TabIndex = 30;
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
			button5.Location = new Point(19, 353);
			button5.Margin = new Padding(5, 4, 5, 4);
			button5.Name = "button5";
			button5.Size = new Size(285, 85);
			button5.TabIndex = 29;
			button5.Text = "              Thanh toán";
			button5.TextAlign = ContentAlignment.MiddleLeft;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(128, 128, 255);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button4);
			panel2.Controls.Add(lblTen);
			panel2.Controls.Add(label6);
			panel2.Controls.Add(panel5);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Margin = new Padding(5, 4, 5, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(1197, 68);
			panel2.TabIndex = 32;
			// 
			// panel4
			// 
			panel4.BorderStyle = BorderStyle.FixedSingle;
			panel4.Location = new Point(293, 67);
			panel4.Margin = new Padding(0);
			panel4.Name = "panel4";
			panel4.Size = new Size(905, 581);
			panel4.TabIndex = 43;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(1013, 29);
			label5.Name = "label5";
			label5.Size = new Size(83, 20);
			label5.TabIndex = 21;
			label5.Text = "UserName";
			label5.VisibleChanged += lblTen_Load;
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
			// lblTen
			// 
			lblTen.AutoSize = true;
			lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTen.Location = new Point(1013, 29);
			lblTen.Margin = new Padding(5, 0, 5, 0);
			lblTen.Name = "lblTen";
			lblTen.Size = new Size(0, 20);
			lblTen.TabIndex = 5;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(1013, 11);
			label6.Margin = new Padding(5, 0, 5, 0);
			label6.Name = "label6";
			label6.Size = new Size(73, 20);
			label6.TabIndex = 3;
			label6.Text = "Xin chào,";
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
			// XulyPayment
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1197, 645);
			Controls.Add(panel2);
			Controls.Add(panel3);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(1215, 692);
			Name = "XulyPayment";
			StartPosition = FormStartPosition.CenterScreen;
			Load += XulyPayment_Load;
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbBienLai).EndInit();
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
        private Panel panel1;
		private Panel panel2;
		private Panel panel4;
		private Label label5;
		private Button button7;
		private Button button4;
		private Label lblTen;
		private Label label6;
		private Panel panel5;
		private Button btnLuu;
		private TextBox txtSoTienThanhToan;
		private TextBox txtHinhThucThanhToan;
		private TextBox txtMaHoSo;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox pbBienLai;
		private Button button1;
		private Button button9;
		private Button button10;
		private Button button3;
		private Button button8;
		private Button button5;
	}
}