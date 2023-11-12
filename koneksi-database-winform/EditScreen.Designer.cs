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
            tbxIDMK = new TextBox();
            editMatakuliah = new GroupBox();
            btnSimpanMK = new Button();
            cbxProdi = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tbxSemesterMK = new TextBox();
            lblPrestasiID = new Label();
            tbxNamaMK = new TextBox();
            lblIDMK = new Label();
            editTimPrestasi = new GroupBox();
            btnSimpanTimPrestasi = new Button();
            cbxProdiTimPrestasi = new ComboBox();
            label3 = new Label();
            lblNama = new Label();
            tbxNamaTimPrestasi = new TextBox();
            lblNIM = new Label();
            tbxNIP = new TextBox();
            label6 = new Label();
            tbxIDTimPrestasi = new TextBox();
            editMatakuliah.SuspendLayout();
            editTimPrestasi.SuspendLayout();
            SuspendLayout();
            // 
            // tbxIDMK
            // 
            tbxIDMK.Location = new Point(116, 25);
            tbxIDMK.Margin = new Padding(2);
            tbxIDMK.Name = "tbxIDMK";
            tbxIDMK.Size = new Size(126, 23);
            tbxIDMK.TabIndex = 0;
            // 
            // editMatakuliah
            // 
            editMatakuliah.Controls.Add(btnSimpanMK);
            editMatakuliah.Controls.Add(cbxProdi);
            editMatakuliah.Controls.Add(label2);
            editMatakuliah.Controls.Add(label1);
            editMatakuliah.Controls.Add(tbxSemesterMK);
            editMatakuliah.Controls.Add(lblPrestasiID);
            editMatakuliah.Controls.Add(tbxNamaMK);
            editMatakuliah.Controls.Add(lblIDMK);
            editMatakuliah.Controls.Add(tbxIDMK);
            editMatakuliah.Location = new Point(8, 7);
            editMatakuliah.Margin = new Padding(2);
            editMatakuliah.Name = "editMatakuliah";
            editMatakuliah.Padding = new Padding(2);
            editMatakuliah.Size = new Size(278, 256);
            editMatakuliah.TabIndex = 1;
            editMatakuliah.TabStop = false;
            editMatakuliah.Text = "Edit Data Mata Kuliah";
            // 
            // btnSimpanMK
            // 
            btnSimpanMK.Location = new Point(85, 145);
            btnSimpanMK.Margin = new Padding(2);
            btnSimpanMK.Name = "btnSimpanMK";
            btnSimpanMK.Size = new Size(78, 20);
            btnSimpanMK.TabIndex = 9;
            btnSimpanMK.Text = "Simpan";
            btnSimpanMK.UseVisualStyleBackColor = true;
            btnSimpanMK.Click += btnSimpanMK_Click;
            // 
            // cbxProdi
            // 
            cbxProdi.FormattingEnabled = true;
            cbxProdi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            cbxProdi.Location = new Point(116, 111);
            cbxProdi.Margin = new Padding(2);
            cbxProdi.Name = "cbxProdi";
            cbxProdi.Size = new Size(126, 23);
            cbxProdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Prodi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Semester";
            // 
            // tbxSemesterMK
            // 
            tbxSemesterMK.Location = new Point(116, 84);
            tbxSemesterMK.Margin = new Padding(2);
            tbxSemesterMK.Name = "tbxSemesterMK";
            tbxSemesterMK.Size = new Size(126, 23);
            tbxSemesterMK.TabIndex = 4;
            // 
            // lblPrestasiID
            // 
            lblPrestasiID.AutoSize = true;
            lblPrestasiID.Location = new Point(19, 55);
            lblPrestasiID.Margin = new Padding(2, 0, 2, 0);
            lblPrestasiID.Name = "lblPrestasiID";
            lblPrestasiID.Size = new Size(60, 15);
            lblPrestasiID.TabIndex = 3;
            lblPrestasiID.Text = "Nama MK";
            // 
            // tbxNamaMK
            // 
            tbxNamaMK.Location = new Point(116, 55);
            tbxNamaMK.Margin = new Padding(2);
            tbxNamaMK.Name = "tbxNamaMK";
            tbxNamaMK.Size = new Size(126, 23);
            tbxNamaMK.TabIndex = 2;
            // 
            // lblIDMK
            // 
            lblIDMK.AutoSize = true;
            lblIDMK.Location = new Point(19, 25);
            lblIDMK.Margin = new Padding(2, 0, 2, 0);
            lblIDMK.Name = "lblIDMK";
            lblIDMK.Size = new Size(18, 15);
            lblIDMK.TabIndex = 1;
            lblIDMK.Text = "ID";
            // 
            // editTimPrestasi
            // 
            editTimPrestasi.Controls.Add(btnSimpanTimPrestasi);
            editTimPrestasi.Controls.Add(cbxProdiTimPrestasi);
            editTimPrestasi.Controls.Add(label3);
            editTimPrestasi.Controls.Add(lblNama);
            editTimPrestasi.Controls.Add(tbxNamaTimPrestasi);
            editTimPrestasi.Controls.Add(lblNIM);
            editTimPrestasi.Controls.Add(tbxNIP);
            editTimPrestasi.Controls.Add(label6);
            editTimPrestasi.Controls.Add(tbxIDTimPrestasi);
            editTimPrestasi.Location = new Point(8, 7);
            editTimPrestasi.Margin = new Padding(2);
            editTimPrestasi.Name = "editTimPrestasi";
            editTimPrestasi.Padding = new Padding(2);
            editTimPrestasi.Size = new Size(278, 256);
            editTimPrestasi.TabIndex = 8;
            editTimPrestasi.TabStop = false;
            editTimPrestasi.Text = "Edit Data Tim Prestasi";
            // 
            // btnSimpanTimPrestasi
            // 
            btnSimpanTimPrestasi.Location = new Point(85, 132);
            btnSimpanTimPrestasi.Margin = new Padding(2);
            btnSimpanTimPrestasi.Name = "btnSimpanTimPrestasi";
            btnSimpanTimPrestasi.Size = new Size(78, 20);
            btnSimpanTimPrestasi.TabIndex = 9;
            btnSimpanTimPrestasi.Text = "Simpan";
            btnSimpanTimPrestasi.UseVisualStyleBackColor = true;
            // 
            // cbxProdiTimPrestasi
            // 
            cbxProdiTimPrestasi.FormattingEnabled = true;
            cbxProdiTimPrestasi.Items.AddRange(new object[] { "Sistem Informasi", "Teknologi Informasi", "Informatika" });
            cbxProdiTimPrestasi.Location = new Point(116, 92);
            cbxProdiTimPrestasi.Margin = new Padding(2);
            cbxProdiTimPrestasi.Name = "cbxProdiTimPrestasi";
            cbxProdiTimPrestasi.Size = new Size(126, 23);
            cbxProdiTimPrestasi.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Prodi";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(19, 70);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(39, 15);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama";
            // 
            // tbxNamaTimPrestasi
            // 
            tbxNamaTimPrestasi.Location = new Point(116, 70);
            tbxNamaTimPrestasi.Margin = new Padding(2);
            tbxNamaTimPrestasi.Name = "tbxNamaTimPrestasi";
            tbxNamaTimPrestasi.Size = new Size(126, 23);
            tbxNamaTimPrestasi.TabIndex = 4;
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.Location = new Point(19, 47);
            lblNIM.Margin = new Padding(2, 0, 2, 0);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(26, 15);
            lblNIM.TabIndex = 3;
            lblNIM.Text = "NIP";
            // 
            // tbxNIP
            // 
            tbxNIP.Location = new Point(116, 47);
            tbxNIP.Margin = new Padding(2);
            tbxNIP.Name = "tbxNIP";
            tbxNIP.Size = new Size(126, 23);
            tbxNIP.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 1;
            label6.Text = "ID ";
            // 
            // tbxIDTimPrestasi
            // 
            tbxIDTimPrestasi.Location = new Point(116, 25);
            tbxIDTimPrestasi.Margin = new Padding(2);
            tbxIDTimPrestasi.Name = "tbxIDTimPrestasi";
            tbxIDTimPrestasi.Size = new Size(126, 23);
            tbxIDTimPrestasi.TabIndex = 0;
            // 
            // EditScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 270);
            Controls.Add(editMatakuliah);
            Controls.Add(editTimPrestasi);
            Margin = new Padding(2);
            Name = "EditScreen";
            Text = "EditScreen";
            editMatakuliah.ResumeLayout(false);
            editMatakuliah.PerformLayout();
            editTimPrestasi.ResumeLayout(false);
            editTimPrestasi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxIDMK;
        private GroupBox editMatakuliah;
        private Label lblIDMK;
        private Label label1;
        private TextBox tbxSemesterMK;
        private Label lblPrestasiID;
        private TextBox tbxNamaMK;
        private GroupBox editTimPrestasi;
        private Label label3;
        private Label lblNama;
        private TextBox tbxNamaTimPrestasi;
        private Label lblNIM;
        private TextBox tbxNIP;
        private Label label6;
        private TextBox tbxIDTimPrestasi;
        private ComboBox cbxProdi;
        private Label label2;
        private Button btnSimpanMK;
        private ComboBox cbxProdiTimPrestasi;
        private Button btnSimpanTimPrestasi;
    }
}