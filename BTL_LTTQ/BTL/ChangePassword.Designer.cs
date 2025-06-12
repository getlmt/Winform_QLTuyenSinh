namespace BTL
{
    partial class ChangePassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
			panel1 = new Panel();
			label5 = new Label();
			button7 = new Button();
			button4 = new Button();
			label2 = new Label();
			panel5 = new Panel();
			btnHome = new Button();
			btnSupport = new Button();
			btnSignOut = new Button();
			btnPreferences = new Button();
			btnChangePassword = new Button();
			btnPayment = new Button();
			panel2 = new Panel();
			txtMKcu = new TextBox();
			txtMKmoi = new TextBox();
			txtXNMKMoi = new TextBox();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			button1 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 128, 255);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(panel5);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(5, 4, 5, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1197, 68);
			panel1.TabIndex = 33;
			panel1.Paint += panel1_Paint;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(1013, 29);
			label5.Name = "label5";
			label5.Size = new Size(83, 20);
			label5.TabIndex = 45;
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
			// btnHome
			// 
			btnHome.FlatAppearance.BorderSize = 0;
			btnHome.FlatStyle = FlatStyle.Flat;
			btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnHome.ForeColor = SystemColors.GrayText;
			btnHome.Image = Properties.Resources.icons8_building_100;
			btnHome.ImageAlign = ContentAlignment.MiddleLeft;
			btnHome.Location = new Point(-1, 7);
			btnHome.Margin = new Padding(5, 4, 5, 4);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(289, 85);
			btnHome.TabIndex = 21;
			btnHome.Text = "                 Trang chủ";
			btnHome.TextAlign = ContentAlignment.MiddleLeft;
			btnHome.UseVisualStyleBackColor = true;
			btnHome.Click += btnHome_Click;
			// 
			// btnSupport
			// 
			btnSupport.FlatAppearance.BorderSize = 0;
			btnSupport.FlatStyle = FlatStyle.Flat;
			btnSupport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btnSupport.ForeColor = SystemColors.GrayText;
			btnSupport.Image = Properties.Resources.icons8_support_50;
			btnSupport.ImageAlign = ContentAlignment.MiddleLeft;
			btnSupport.Location = new Point(17, 379);
			btnSupport.Margin = new Padding(5, 4, 5, 4);
			btnSupport.Name = "btnSupport";
			btnSupport.Size = new Size(271, 85);
			btnSupport.TabIndex = 25;
			btnSupport.Text = "             Hỗ trợ";
			btnSupport.TextAlign = ContentAlignment.MiddleLeft;
			btnSupport.UseVisualStyleBackColor = true;
			btnSupport.Click += btnSupport_Click;
			// 
			// btnSignOut
			// 
			btnSignOut.FlatAppearance.BorderSize = 0;
			btnSignOut.FlatStyle = FlatStyle.Flat;
			btnSignOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSignOut.ForeColor = SystemColors.GrayText;
			btnSignOut.Image = Properties.Resources.icons8_exit_48;
			btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
			btnSignOut.Location = new Point(17, 472);
			btnSignOut.Margin = new Padding(5, 4, 5, 4);
			btnSignOut.Name = "btnSignOut";
			btnSignOut.Size = new Size(271, 85);
			btnSignOut.TabIndex = 26;
			btnSignOut.Text = "             Đăng xuất";
			btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
			btnSignOut.UseVisualStyleBackColor = true;
			btnSignOut.Click += btnSignOut_Click;
			// 
			// btnPreferences
			// 
			btnPreferences.FlatAppearance.BorderSize = 0;
			btnPreferences.FlatStyle = FlatStyle.Flat;
			btnPreferences.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btnPreferences.ForeColor = SystemColors.GrayText;
			btnPreferences.Image = Properties.Resources.icons8_create_64;
			btnPreferences.ImageAlign = ContentAlignment.TopLeft;
			btnPreferences.Location = new Point(8, 100);
			btnPreferences.Margin = new Padding(5, 4, 5, 4);
			btnPreferences.Name = "btnPreferences";
			btnPreferences.Size = new Size(280, 85);
			btnPreferences.TabIndex = 22;
			btnPreferences.Text = "               Nguyện vọng";
			btnPreferences.TextAlign = ContentAlignment.MiddleLeft;
			btnPreferences.UseVisualStyleBackColor = true;
			btnPreferences.Click += btnPreferences_Click;
			// 
			// btnChangePassword
			// 
			btnChangePassword.FlatAppearance.BorderSize = 0;
			btnChangePassword.FlatStyle = FlatStyle.Flat;
			btnChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btnChangePassword.ForeColor = SystemColors.GrayText;
			btnChangePassword.Image = Properties.Resources.icons8_change_password_58;
			btnChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
			btnChangePassword.Location = new Point(8, 193);
			btnChangePassword.Margin = new Padding(5, 4, 5, 4);
			btnChangePassword.Name = "btnChangePassword";
			btnChangePassword.Size = new Size(280, 85);
			btnChangePassword.TabIndex = 24;
			btnChangePassword.Text = "               Đổi mật khẩu";
			btnChangePassword.TextAlign = ContentAlignment.MiddleLeft;
			btnChangePassword.UseVisualStyleBackColor = true;
			// 
			// btnPayment
			// 
			btnPayment.FlatAppearance.BorderSize = 0;
			btnPayment.FlatStyle = FlatStyle.Flat;
			btnPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btnPayment.ForeColor = SystemColors.GrayText;
			btnPayment.Image = Properties.Resources.icons8_payment_64;
			btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
			btnPayment.Location = new Point(13, 286);
			btnPayment.Margin = new Padding(5, 4, 5, 4);
			btnPayment.Name = "btnPayment";
			btnPayment.Size = new Size(275, 85);
			btnPayment.TabIndex = 23;
			btnPayment.Text = "              Thanh toán";
			btnPayment.TextAlign = ContentAlignment.MiddleLeft;
			btnPayment.UseVisualStyleBackColor = true;
			btnPayment.Click += btnPayment_Click;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(btnHome);
			panel2.Controls.Add(btnSupport);
			panel2.Controls.Add(btnSignOut);
			panel2.Controls.Add(btnPreferences);
			panel2.Controls.Add(btnChangePassword);
			panel2.Controls.Add(btnPayment);
			panel2.Location = new Point(0, 68);
			panel2.Name = "panel2";
			panel2.Size = new Size(295, 581);
			panel2.TabIndex = 34;
			// 
			// txtMKcu
			// 
			txtMKcu.Location = new Point(409, 227);
			txtMKcu.Multiline = true;
			txtMKcu.Name = "txtMKcu";
			txtMKcu.Size = new Size(641, 33);
			txtMKcu.TabIndex = 38;
			txtMKcu.TextChanged += textBox1_TextChanged;
			// 
			// txtMKmoi
			// 
			txtMKmoi.Location = new Point(409, 304);
			txtMKmoi.Multiline = true;
			txtMKmoi.Name = "txtMKmoi";
			txtMKmoi.Size = new Size(641, 33);
			txtMKmoi.TabIndex = 39;
			// 
			// txtXNMKMoi
			// 
			txtXNMKMoi.Location = new Point(409, 379);
			txtXNMKMoi.Multiline = true;
			txtXNMKMoi.Name = "txtXNMKMoi";
			txtXNMKMoi.Size = new Size(641, 33);
			txtXNMKMoi.TabIndex = 40;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(409, 204);
			label1.Name = "label1";
			label1.Size = new Size(94, 20);
			label1.TabIndex = 41;
			label1.Text = "Mật khẩu cũ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(409, 281);
			label3.Name = "label3";
			label3.Size = new Size(104, 20);
			label3.TabIndex = 42;
			label3.Text = "Mật khẩu mới";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(409, 356);
			label4.Name = "label4";
			label4.Size = new Size(170, 20);
			label4.TabIndex = 43;
			label4.Text = "Xác nhận mật khẩu mới";
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Highlight;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(904, 448);
			button1.Name = "button1";
			button1.Size = new Size(146, 43);
			button1.TabIndex = 44;
			button1.Text = "Lưu";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// ChangePassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(1197, 648);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(txtXNMKMoi);
			Controls.Add(txtMKmoi);
			Controls.Add(txtMKcu);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "ChangePassword";
			StartPosition = FormStartPosition.CenterScreen;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Button button7;
        private Button button4;
        private Label label2;
        private Panel panel5;
        private Button btnHome;
        private Button btnSupport;
        private Button btnSignOut;
        private Button btnPreferences;
        private Button btnChangePassword;
        private Button btnPayment;
        private Panel panel2;
        private TextBox txtMKcu;
        private TextBox txtMKmoi;
        private TextBox txtXNMKMoi;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
		private Label label5;
	}
}