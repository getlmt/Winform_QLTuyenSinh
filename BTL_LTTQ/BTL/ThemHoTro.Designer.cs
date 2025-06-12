namespace BTL
{
    partial class ThemHoTro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoTro));
			button1 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Highlight;
			resources.ApplyResources(button1, "button1");
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Name = "button1";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			resources.ApplyResources(textBox1, "textBox1");
			textBox1.Name = "textBox1";
			// 
			// textBox2
			// 
			resources.ApplyResources(textBox2, "textBox2");
			textBox2.Name = "textBox2";
			// 
			// textBox3
			// 
			resources.ApplyResources(textBox3, "textBox3");
			textBox3.Name = "textBox3";
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox4
			// 
			resources.ApplyResources(textBox4, "textBox4");
			textBox4.Name = "textBox4";
			textBox4.TextChanged += textBox4_TextChanged;
			textBox4.VisibleChanged += HienThiId;
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(label4, "label4");
			label4.Name = "label4";
			// 
			// button2
			// 
			button2.BackColor = SystemColors.Highlight;
			resources.ApplyResources(button2, "button2");
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Name = "button2";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// ThemHoTro
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "ThemHoTro";
			Load += ThemHoTro_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
    }
}