﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace koneksi_database_winform
{
    internal class DBHelper
    {


        private NpgsqlConnection connection;

        public DBHelper()
        {
            var connString = "Host=localhost;Port=5432;Database=PBO_Project_TEST;Username=postgres;Password=tahutahu1";
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

        public void updateRows(string nama, int semester, string id, string prodi)
        { 

            connection.Open();

            //string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public'";


            try
            {
                connection.Open();
                string query = @"UPDATE mata_kuliah SET Nama = @Nama, Semester = @Semester, id = @ID, Prodi = @Prodi";

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
