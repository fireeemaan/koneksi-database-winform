using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;


namespace koneksi_database_winform
{
    internal class DBHelper
    {


        private NpgsqlConnection connection;

        public DBHelper()
        {
            var connString = "Host=localhost;Port=5432;Database=PBO_Project_TEST;Username=postgres;Password=";
            connection = new NpgsqlConnection(connString);
        }

        public string[] GetTableNames()
        {
            List<string> tableList = new List<string>();

            connection.Open();

            //string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public'";
            string query = "SELECT tablename FROM pg_tables WHERE schemaname = 'public'";


            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tableName = reader["tablename"].ToString();
                        tableList.Add(tableName);
                    }
                }
            }

            connection.Close();
            return tableList.ToArray();
        }

        public void insertRows(string nama, int semester, string id, string prodi)
        {
            try
            {
                connection.Open();
                string query = @"INSERT INTO public.mata_kuliah(nama, semester, id, prodi) VALUES (@Nama, @Semester, @ID, @Prodi)";

                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Semester", semester);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Prodi", prodi);

                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected);

                //query = string.Format(query, nama, semester, id, prodi);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : " + ex.Message);
            }
            connection.Close();
        }

        public void deleteRows(string idToDelete)
        {
            try
            {
                var id = idToDelete;
                connection.Open();
                string query = @"DELETE FROM public.mata_kuliah WHERE id = @ID";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ID", id);


                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : " + ex.Message);
            }
            finally
            {
                DialogResult message = MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK);
            }

            connection.Close();
           
        }

        public void updateRows(string nama, int semester, string id, string prodi)
        { 

            

            //string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public'";


            try
            {
                connection.Open();
                string query = @"UPDATE public.mata_kuliah SET Nama = @Nama, Semester = @Semester, id = @ID, Prodi = @Prodi WHERE id = @ID";
                

                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Semester", semester);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Prodi", prodi);
                
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected);




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : " + ex.Message);
            }
            



            connection.Close();
            
        }

            public DataRow GetRowByIndex(DataTable table, int rowIdx)
        {
            if (table != null && table.Rows.Count > 0)
            {
                if (rowIdx >= 0 && rowIdx < table.Rows.Count)
                {
                    return table.Rows[rowIdx];
                }
            }
            return null;
        }

        public DataTable GetTables(string tableName)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT * FROM " + tableName;

                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                using NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);

                dataAdapter.Fill(dataTable);

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR! : " +  ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return dataTable;
        }


    }
}
