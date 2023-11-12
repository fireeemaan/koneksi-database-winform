using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koneksi_database_winform
{
    public partial class EditScreen : Form
    {
        DBHelper dbHelper = new DBHelper();
        public EditScreen()
        {
            InitializeComponent();

        }
        public EditScreen(string tableName, DataRow dataRow, int index)
        {
            InitializeComponent();
            editTimPrestasi.Hide();
            editMatakuliah.Hide();




            if (tableName == "mata_kuliah")
            {

                editMatakuliah.Show();
                tbxIDMK.Text = (string)dataRow["ID"];
                tbxNamaMK.Text = (string)dataRow["Nama"];
                tbxSemesterMK.Text = dataRow["Semester"].ToString();
                cbxProdi.Text = (string)dataRow["Prodi"];


            }
            else if (tableName == "tim_prestasi")
            {
                editTimPrestasi.Show();
            }
            else
            {

            }



        }

        private void btnSimpanMK_Click(object sender, EventArgs e)
        {
            var IDMK = tbxIDMK.Text;
            var NamaMK = tbxNamaMK.Text;
            int SemesterMK = Int32.Parse(tbxSemesterMK.Text);
            var Prodi = cbxProdi.Text;

            dbHelper.updateRows(NamaMK, SemesterMK, IDMK, Prodi);

            DialogResult message = MessageBox.Show("Data Berhasil Diubah", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
