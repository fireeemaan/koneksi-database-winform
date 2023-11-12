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
            editTimPrestasi.Hide();
            editMatakuliah.Hide();
        }
        public EditScreen(string tableName, int index)
        {
            InitializeComponent();
            editTimPrestasi.Hide();
            editMatakuliah.Hide();


            if (tableName == "mata_kuliah")
            {
                editMatakuliah.Show();
                //tbxIDMK = 
            }
            else if (tableName == "tim_prestasi")
            {
                editTimPrestasi.Show();
            }
            else
            {
                MessageBox.Show("Fitur Belum Tersedia!");
                this.Close();
            }


        }
    }
}
