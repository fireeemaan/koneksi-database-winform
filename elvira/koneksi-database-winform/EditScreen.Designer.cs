namespace koneksi_database_winform
{
    partial class EditScreen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 76);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Nama MK";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 1;
            label2.Text = "Semester";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 159);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 2;
            label3.Text = "Program Studi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 39);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(244, 32);
            label4.TabIndex = 6;
            label4.Text = "Edit Data Mata Kuliah";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            comboBox1.Location = new Point(251, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 40);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(181, 266);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 324);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
    }
}