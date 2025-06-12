namespace BTL
{
    partial class SuaHoTro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaHoTro));
			button2 = new Button();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			label5 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Highlight;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(511, 470);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(137, 57);
			button2.TabIndex = 19;
			button2.Text = "Trở lại ";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label4.Location = new Point(253, 368);
			label4.Name = "label4";
			label4.Size = new Size(126, 20);
			label4.TabIndex = 18;
			label4.Text = "Hình thức hỗ trợ ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label3.Location = new Point(253, 265);
			label3.Name = "label3";
			label3.Size = new Size(125, 20);
			label3.TabIndex = 17;
			label3.Text = "Thông tin hỗ trợ ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label2.Location = new Point(253, 167);
			label2.Name = "label2";
			label2.Size = new Size(132, 20);
			label2.TabIndex = 16;
			label2.Text = "Thông tin yêu cầu";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			label1.Location = new Point(253, 72);
			label1.Name = "label1";
			label1.Size = new Size(76, 20);
			label1.TabIndex = 15;
			label1.Text = "Mã Hồ Sơ";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(253, 392);
			textBox4.Margin = new Padding(3, 4, 3, 4);
			textBox4.Multiline = true;
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(395, 45);
			textBox4.TabIndex = 14;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(253, 289);
			textBox3.Margin = new Padding(3, 4, 3, 4);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(395, 45);
			textBox3.TabIndex = 13;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(253, 191);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(395, 45);
			textBox2.TabIndex = 12;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Highlight;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(253, 470);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(137, 57);
			button1.TabIndex = 10;
			button1.Text = "Cập Nhật";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.ButtonHighlight;
			label5.Location = new Point(267, 109);
			label5.Name = "label5";
			label5.Size = new Size(50, 20);
			label5.TabIndex = 21;
			label5.Text = "label5";
			label5.Click += label5_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(253, 96);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(395, 45);
			textBox1.TabIndex = 22;
			// 
			// SuaHoTro
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(914, 600);
			Controls.Add(label5);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			MinimumSize = new Size(932, 647);
			Name = "SuaHoTro";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sửa hỗ trợ";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
		private TextBox textBox1;
	}
}