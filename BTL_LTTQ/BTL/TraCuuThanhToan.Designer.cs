namespace BTL
{
	partial class TraCuuThanhToan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuThanhToan));
			pbBienLai = new PictureBox();
			btnTimKiem = new Button();
			txtSoTienThanhToan = new TextBox();
			txtHinhThucThanhToan = new TextBox();
			txtMaHoSo = new TextBox();
			txtNhapMaHoSo = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			panel1 = new Panel();
			label1 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pbBienLai).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// pbBienLai
			// 
			pbBienLai.BorderStyle = BorderStyle.FixedSingle;
			pbBienLai.Location = new Point(476, 143);
			pbBienLai.Name = "pbBienLai";
			pbBienLai.Size = new Size(267, 250);
			pbBienLai.TabIndex = 21;
			pbBienLai.TabStop = false;
			// 
			// btnTimKiem
			// 
			btnTimKiem.BackColor = SystemColors.Highlight;
			btnTimKiem.FlatStyle = FlatStyle.Flat;
			btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
			btnTimKiem.Location = new Point(534, 41);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(103, 40);
			btnTimKiem.TabIndex = 20;
			btnTimKiem.Text = "Tìm kiếm";
			btnTimKiem.UseVisualStyleBackColor = false;
			btnTimKiem.Click += btnTimKiem_Click_1;
			// 
			// txtSoTienThanhToan
			// 
			txtSoTienThanhToan.Location = new Point(61, 235);
			txtSoTienThanhToan.Multiline = true;
			txtSoTienThanhToan.Name = "txtSoTienThanhToan";
			txtSoTienThanhToan.Size = new Size(312, 40);
			txtSoTienThanhToan.TabIndex = 19;
			// 
			// txtHinhThucThanhToan
			// 
			txtHinhThucThanhToan.Location = new Point(61, 142);
			txtHinhThucThanhToan.Multiline = true;
			txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
			txtHinhThucThanhToan.Size = new Size(312, 40);
			txtHinhThucThanhToan.TabIndex = 18;
			// 
			// txtMaHoSo
			// 
			txtMaHoSo.Location = new Point(61, 47);
			txtMaHoSo.Multiline = true;
			txtMaHoSo.Name = "txtMaHoSo";
			txtMaHoSo.Size = new Size(312, 40);
			txtMaHoSo.TabIndex = 17;
			// 
			// txtNhapMaHoSo
			// 
			txtNhapMaHoSo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			txtNhapMaHoSo.Location = new Point(45, 41);
			txtNhapMaHoSo.Multiline = true;
			txtNhapMaHoSo.Name = "txtNhapMaHoSo";
			txtNhapMaHoSo.PlaceholderText = "Nhập mã hồ sơ để tra cứu!!";
			txtNhapMaHoSo.Size = new Size(454, 40);
			txtNhapMaHoSo.TabIndex = 16;
			txtNhapMaHoSo.TextChanged += txtNhapMaHoSo_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(637, 16);
			label5.Name = "label5";
			label5.Size = new Size(60, 20);
			label5.TabIndex = 15;
			label5.Text = "Biên lai";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(61, 212);
			label4.Name = "label4";
			label4.Size = new Size(135, 20);
			label4.TabIndex = 14;
			label4.Text = "Số tiền thanh toán";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(61, 119);
			label3.Name = "label3";
			label3.Size = new Size(155, 20);
			label3.TabIndex = 13;
			label3.Text = "Hình thức thanh toán";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(61, 24);
			label2.Name = "label2";
			label2.Size = new Size(72, 20);
			label2.TabIndex = 12;
			label2.Text = "Mã hồ sơ";
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtSoTienThanhToan);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(txtHinhThucThanhToan);
			panel1.Controls.Add(txtMaHoSo);
			panel1.Controls.Add(label4);
			panel1.Location = new Point(45, 103);
			panel1.Name = "panel1";
			panel1.Size = new Size(728, 322);
			panel1.TabIndex = 22;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(45, 18);
			label1.Name = "label1";
			label1.Size = new Size(113, 20);
			label1.TabIndex = 23;
			label1.Text = "Nhập mã hồ sơ";
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Highlight;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(670, 41);
			button1.Name = "button1";
			button1.Size = new Size(103, 40);
			button1.TabIndex = 24;
			button1.Text = "Trở về ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// TraCuuThanhToan
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(btnTimKiem);
			Controls.Add(pbBienLai);
			Controls.Add(txtNhapMaHoSo);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(818, 497);
			Name = "TraCuuThanhToan";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tra cứu thanh toán";
			Load += TraCuuThanhToan_Load;
			((System.ComponentModel.ISupportInitialize)pbBienLai).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbBienLai;
		private Button btnTimKiem;
		private TextBox txtSoTienThanhToan;
		private TextBox txtHinhThucThanhToan;
		private TextBox txtMaHoSo;
		private TextBox txtNhapMaHoSo;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Panel panel1;
		private Label label1;
		private Button button1;
	}
}