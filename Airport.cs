using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Airport : Form
    {
        string connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True;Encrypt=False";
        int Key = 1;
        Dictionary<int, string> CurrentTable = new Dictionary<int, string>()
        {
            [1] = "Company",
            [2] = "Flights",
            [3] = "Passenger",
            [4] = "Tickets"
        };
        public Airport()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {CurrentTable[Key]}", connection);

                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message);
                }
            }
        }

        private void Airport_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Key = 1;
            LoadData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Key = 2;
            LoadData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Key = 3;
            LoadData();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Key = 4;
            LoadData();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            switch (Key)
            {
                case 1:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow)
                                    continue;

                                string query = $"INSERT INTO {CurrentTable[Key]} (id, name) VALUES (@Id, @Name)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                                    command.Parameters.AddWithValue("@Name", row.Cells["name"].Value);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        LoadData();
                    }
                break;
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["id"].Value != null && row.Cells["id"].Value != row.Cells["id"].Value)
                        {
                            string query = $"UPDATE {CurrentTable[Key]} SET id = @Id, name = @Name";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                                command.Parameters.AddWithValue("@Name", row.Cells["name"].Value);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                LoadData();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.Cells["id"].Value != null)
                    {
                        string query = $"DELETE FROM {CurrentTable[Key]} WHERE id = @Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            LoadData();
        }
    }
}
