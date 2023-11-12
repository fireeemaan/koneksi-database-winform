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
    public partial class AddScreen : Form
    {
        DBHelper dBHelper = new DBHelper();
        public AddScreen()
        {
            InitializeComponent();
        }

        private void addButon_Click(object sender, EventArgs e)
        {
            var IDMK = tbxInsertID.Text;
            var Nama = tbxInsertNama.Text;
            var Semester = Int32.Parse(tbxInsertSemester.Text);
            var Prodi = cbxInsertProdi.Text;

            dBHelper.insertRows(Nama, Semester, IDMK, Prodi);

            DialogResult message = MessageBox.Show("Data Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
