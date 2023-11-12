namespace koneksi_database_winform
{
    partial class AddScreen
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
            tbxInsertID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxInsertNama = new TextBox();
            label3 = new Label();
            tbxInsertSemester = new TextBox();
            label4 = new Label();
            addButon = new Button();
            cbxInsertProdi = new ComboBox();
            SuspendLayout();
            // 
            // tbxInsertID
            // 
            tbxInsertID.Location = new Point(116, 40);
            tbxInsertID.Name = "tbxInsertID";
            tbxInsertID.Size = new Size(100, 23);
            tbxInsertID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 72);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // tbxInsertNama
            // 
            tbxInsertNama.Location = new Point(116, 69);
            tbxInsertNama.Name = "tbxInsertNama";
            tbxInsertNama.Size = new Size(100, 23);
            tbxInsertNama.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 101);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Semester";
            // 
            // tbxInsertSemester
            // 
            tbxInsertSemester.Location = new Point(116, 98);
            tbxInsertSemester.Name = "tbxInsertSemester";
            tbxInsertSemester.Size = new Size(100, 23);
            tbxInsertSemester.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 130);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Prodi";
            // 
            // addButon
            // 
            addButon.Location = new Point(91, 167);
            addButon.Name = "addButon";
            addButon.Size = new Size(75, 23);
            addButon.TabIndex = 8;
            addButon.Text = "Tambah";
            addButon.UseVisualStyleBackColor = true;
            addButon.Click += addButon_Click;
            // 
            // cbxInsertProdi
            // 
            cbxInsertProdi.FormattingEnabled = true;
            cbxInsertProdi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            cbxInsertProdi.Location = new Point(116, 127);
            cbxInsertProdi.Name = "cbxInsertProdi";
            cbxInsertProdi.Size = new Size(100, 23);
            cbxInsertProdi.TabIndex = 9;
            // 
            // AddScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 255);
            Controls.Add(cbxInsertProdi);
            Controls.Add(addButon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxInsertSemester);
            Controls.Add(label2);
            Controls.Add(tbxInsertNama);
            Controls.Add(label1);
            Controls.Add(tbxInsertID);
            Name = "AddScreen";
            Text = "AddScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxInsertID;
        private Label label1;
        private Label label2;
        private TextBox tbxInsertNama;
        private Label label3;
        private TextBox tbxInsertSemester;
        private Label label4;
        private Button addButon;
        private ComboBox cbxInsertProdi;
    }
}