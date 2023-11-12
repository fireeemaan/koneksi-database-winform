using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace koneksi_database_winform
{
    public partial class AddScreen : Form
    {
        MainScreen mainscreen;
        NpgsqlConnection conn;
        public AddScreen(NpgsqlConnection conn, MainScreen mainscreen)
        {
            InitializeComponent();
            this.conn = conn;
            this.mainscreen = mainscreen;
        }

        private void btnSimpanMK_Click(object sender, EventArgs e)
        {
            string nama_matkul = tbxNamaMK.Text;
            int semester = int.Parse(tbxSemesterMK.Text);
            string prodi = cbxProdi.Text;
            NpgsqlCommand cmd = new NpgsqlCommand($"insert into matkul (nama_matkul,semester,prodi) values ('{nama_matkul}','{semester}','{prodi}');", conn);
            cmd.ExecuteNonQuery();
            mainscreen.dataGridView1.Rows.Add(nama_matkul, semester, prodi);
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
