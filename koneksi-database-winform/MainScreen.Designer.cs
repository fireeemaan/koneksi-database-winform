﻿namespace koneksi_database_winform
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cbxTable = new ComboBox();
            addData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(753, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbxTable
            // 
            cbxTable.FormattingEnabled = true;
            cbxTable.Items.AddRange(new object[] { "konversi", "tim_prestasi", "mata_kuliah", "prestasi", "mahasiswa_prestasi", "mahasiswa" });
            cbxTable.Location = new Point(8, 2);
            cbxTable.Margin = new Padding(2);
            cbxTable.Name = "cbxTable";
            cbxTable.Size = new Size(129, 23);
            cbxTable.TabIndex = 1;
            cbxTable.SelectedIndexChanged += cbxTable_SelectedIndexChanged;
            // 
            // addData
            // 
            addData.Location = new Point(307, 284);
            addData.Margin = new Padding(2);
            addData.Name = "addData";
            addData.Size = new Size(136, 28);
            addData.TabIndex = 2;
            addData.Text = "Tambah Data";
            addData.UseVisualStyleBackColor = true;
            addData.Click += addData_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 320);
            Controls.Add(addData);
            Controls.Add(cbxTable);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "MainScreen";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private ComboBox cbxTable;
        private Button addData;
    }
}