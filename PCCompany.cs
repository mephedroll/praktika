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
    public partial class PCCompany : Form
    {
        string connectionString = "Data Source=DESKTOP-DUT2LRI\\\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False\"";
        int Key = 1;
        Dictionary<int, string> CurrentTable = new Dictionary<int, string>()
        {
            [1] = "Product",
            [2] = "PC",
            [3] = "Laptop",
            [4] = "Printer"
        };

        public PCCompany()
        {
            InitializeComponent();


        }

        private void PCCompany_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            Form Clarification;
            Clarification = new PCCompanyClarification();
            LoadData();
        }
        private void update_Button_Click(object sender, EventArgs e)
        {
            //Form Clarification;
            //Clarification = new PCCompanyClarification();
            //LoadData();
            //string connectionString = "Data Source=DESKTOP-DUT2LRI\\\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False\"";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Id"].Value != null)
                    {
                        string query = $"UPDATE {CurrentTable[Key]} SET producer = @Producer, model = @Model, type = @Type WHERE Id = @Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Producer", row.Cells["producer"].Value);
                            command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                            command.Parameters.AddWithValue("@Type", row.Cells["type"].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            LoadData();
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            //Form Clarification;
            //Clarification = new PCCompanyClarification();
            //LoadData();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["model"].Value != null)
                        {
                            string query = "DELETE FROM Products WHERE model = @Model";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                LoadData();
            }
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
    }
}
