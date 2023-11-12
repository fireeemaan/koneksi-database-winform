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
    public partial class EditScreen : Form
    {
        NpgsqlConnection conn;
        MainScreen mainscreen;
        int currentindex = 0;
        public EditScreen(NpgsqlConnection conn, MainScreen mainscreen)
        {
            InitializeComponent();
            this.conn = conn;
            this.mainscreen = mainscreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matkul = textBox1.Text.ToString();
            int semester = int.Parse(textBox2.Text);
            string prodi =comboBox1.Text;
            NpgsqlCommand cmd = new NpgsqlCommand($"update matkul set nama_matkul = '{matkul}', semester = {semester}, prodi = '{prodi}' where nama_matkul = '{matkul}';",conn);
            cmd.ExecuteNonQuery();
            mainscreen.dataGridView1.Rows[currentindex].Cells[0].Value = matkul;
            mainscreen.dataGridView1.Rows[currentindex].Cells[1].Value = semester;
            mainscreen.dataGridView1.Rows[currentindex].Cells[2].Value = prodi;
            this.Hide();
        }
        public void setCurrentIndex(int index, string matkul, string semester, string prodi)
        {
            textBox1.Text = matkul.ToString();
            textBox2.Text = semester.ToString();
            comboBox1.Text = prodi.ToString();
            currentindex = index;
        }
    }
}
