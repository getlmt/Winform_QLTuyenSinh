namespace BTL
{
	partial class ThemThanhToan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThanhToan));
			dgvThongTin = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtMaHoSo = new TextBox();
			txtHinhThucThanhToan = new TextBox();
			txtSoTienThanhToan = new TextBox();
			txtBienLai = new TextBox();
			btnThem = new Button();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
			SuspendLayout();
			// 
			// dgvThongTin
			// 
			dgvThongTin.BackgroundColor = SystemColors.ButtonHighlight;
			dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvThongTin.Location = new Point(385, 32);
			dgvThongTin.Name = "dgvThongTin";
			dgvThongTin.RowHeadersWidth = 51;
			dgvThongTin.Size = new Size(620, 392);
			dgvThongTin.TabIndex = 0;
			dgvThongTin.CellContentClick += dgvThongTin_CellContentClick;
			dgvThongTin.VisibleChanged += Form1_Load;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label1.Location = new Point(34, 8);
			label1.Name = "label1";
			label1.Size = new Size(72, 20);
			label1.TabIndex = 1;
			label1.Text = "Mã hồ sơ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label2.Location = new Point(34, 100);
			label2.Name = "label2";
			label2.Size = new Size(155, 20);
			label2.TabIndex = 2;
			label2.Text = "Hình thức thanh toán";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label3.Location = new Point(34, 192);
			label3.Name = "label3";
			label3.Size = new Size(135, 20);
			label3.TabIndex = 3;
			label3.Text = "Số tiền thanh toán";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label4.Location = new Point(34, 287);
			label4.Name = "label4";
			label4.Size = new Size(59, 20);
			label4.TabIndex = 4;
			label4.Text = "Biên lai";
			// 
			// txtMaHoSo
			// 
			txtMaHoSo.Location = new Point(34, 31);
			txtMaHoSo.Multiline = true;
			txtMaHoSo.Name = "txtMaHoSo";
			txtMaHoSo.Size = new Size(332, 42);
			txtMaHoSo.TabIndex = 5;
			txtMaHoSo.TextChanged += txtMaHoSo_TextChanged;
			// 
			// txtHinhThucThanhToan
			// 
			txtHinhThucThanhToan.Location = new Point(34, 123);
			txtHinhThucThanhToan.Multiline = true;
			txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
			txtHinhThucThanhToan.Size = new Size(332, 42);
			txtHinhThucThanhToan.TabIndex = 6;
			txtHinhThucThanhToan.TextChanged += txtHinhThucThanhToan_TextChanged;
			// 
			// txtSoTienThanhToan
			// 
			txtSoTienThanhToan.Location = new Point(34, 215);
			txtSoTienThanhToan.Multiline = true;
			txtSoTienThanhToan.Name = "txtSoTienThanhToan";
			txtSoTienThanhToan.Size = new Size(332, 42);
			txtSoTienThanhToan.TabIndex = 7;
			txtSoTienThanhToan.TextChanged += txtSoTienThanhToan_TextChanged;
			// 
			// txtBienLai
			// 
			txtBienLai.Location = new Point(34, 310);
			txtBienLai.Multiline = true;
			txtBienLai.Name = "txtBienLai";
			txtBienLai.Size = new Size(332, 42);
			txtBienLai.TabIndex = 8;
			txtBienLai.TextChanged += txtBienLai_TextChanged;
			// 
			// btnThem
			// 
			btnThem.BackColor = SystemColors.Highlight;
			btnThem.FlatStyle = FlatStyle.Flat;
			btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnThem.ForeColor = SystemColors.ButtonHighlight;
			btnThem.Location = new Point(34, 381);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(100, 46);
			btnThem.TabIndex = 9;
			btnThem.Text = "Thêm ";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Highlight;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(267, 381);
			button1.Name = "button1";
			button1.Size = new Size(100, 46);
			button1.TabIndex = 10;
			button1.Text = "Quay về";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Highlight;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(147, 381);
			button2.Name = "button2";
			button2.Size = new Size(100, 46);
			button2.TabIndex = 11;
			button2.Text = "Sửa";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// ThemThanhToan
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(1032, 450);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(btnThem);
			Controls.Add(txtBienLai);
			Controls.Add(txtSoTienThanhToan);
			Controls.Add(txtHinhThucThanhToan);
			Controls.Add(txtMaHoSo);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvThongTin);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			ForeColor = SystemColors.ControlText;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(1050, 497);
			Name = "ThemThanhToan";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Thêm thanh toán";
			Load += ThemThanhToan_Load;
			((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvThongTin;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtMaHoSo;
		private TextBox txtHinhThucThanhToan;
		private TextBox txtSoTienThanhToan;
		private TextBox txtBienLai;
		private Button btnThem;
		private Button button1;
		private Button button2;
	}
}