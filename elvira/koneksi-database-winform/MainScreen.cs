using Npgsql;
using System;
using System.Runtime.InteropServices;

namespace koneksi_database_winform
{
    public partial class MainScreen : Form
    {
        NpgsqlConnection conn;
        AddScreen addscreen;
        EditScreen editscreen;
        public MainScreen(NpgsqlConnection conn)
        {
            InitializeComponent();
            AddScreen addscreen = new AddScreen(conn, this);
            EditScreen editscreen = new EditScreen(conn, this);
            this.conn = conn;
            this.addscreen = addscreen;
            this.editscreen = editscreen;
            NpgsqlCommand cmd = new NpgsqlCommand("select * from matkul", conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1], reader[2], reader[3]);
            }
            reader.Close();
        }


        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addData_Click(object sender, EventArgs e)
        {
            addscreen.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 3)
            {
                string? matkul = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string? semester = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string? prodi = dataGridView1.Rows[index].Cells[2].Value.ToString();
                editscreen.setCurrentIndex(index, matkul, semester, prodi);
                editscreen.ShowDialog();
            } else if (e.ColumnIndex == 4)
            {
                string? matkul = dataGridView1.Rows[index].Cells[0].Value.ToString();
                NpgsqlCommand cmd = new NpgsqlCommand($"delete from matkul where nama_matkul = '{matkul}'",conn);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(index);
            }
        }

    }
}