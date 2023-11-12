namespace koneksi_database_winform
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
            matkul = new DataGridViewTextBoxColumn();
            semester = new DataGridViewTextBoxColumn();
            prodi = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Hapus = new DataGridViewButtonColumn();
            addData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { matkul, semester, prodi, Edit, Hapus });
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1399, 544);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // matkul
            // 
            matkul.HeaderText = "Mata Kuliah";
            matkul.MinimumWidth = 10;
            matkul.Name = "matkul";
            // 
            // semester
            // 
            semester.HeaderText = "Semester";
            semester.MinimumWidth = 10;
            semester.Name = "semester";
            semester.ReadOnly = true;
            // 
            // prodi
            // 
            prodi.HeaderText = "Program Studi";
            prodi.MinimumWidth = 10;
            prodi.Name = "prodi";
            prodi.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 10;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Hapus
            // 
            Hapus.HeaderText = "Hapus";
            Hapus.MinimumWidth = 10;
            Hapus.Name = "Hapus";
            Hapus.ReadOnly = true;
            Hapus.Resizable = DataGridViewTriState.True;
            Hapus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // addData
            // 
            addData.Location = new Point(569, 607);
            addData.Margin = new Padding(4);
            addData.Name = "addData";
            addData.Size = new Size(252, 60);
            addData.TabIndex = 2;
            addData.Text = "Tambah Data";
            addData.UseVisualStyleBackColor = true;
            addData.Click += addData_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 682);
            Controls.Add(addData);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button addData;
        private DataGridViewTextBoxColumn matkul;
        private DataGridViewTextBoxColumn semester;
        private DataGridViewTextBoxColumn prodi;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}