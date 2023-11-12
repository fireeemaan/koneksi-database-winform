using System.Runtime.InteropServices;

namespace koneksi_database_winform
{
    public partial class MainScreen : Form
    {
        DBHelper dBHelper = new DBHelper();
        public MainScreen()
        {
            InitializeComponent();
            dataGridView1.Hide();
            addData.Hide();

            // Menambahkan Button

            // Button Ubah Data
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, editButton);

            // Button Hapus Data
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(1, deleteButton);


        }


        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            addData.Show();
            dataGridView1.Show();
            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dBHelper.GetTables(cbxTable.Text);
        }


        private void addData_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                
            }
        }
    }
}