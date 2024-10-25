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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktika
{
    public partial class PCCompany : Form
    {
        string connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False";
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

                                string query = $"INSERT INTO {CurrentTable[Key]} (producer, model, type) VALUES (@Producer, @Model, @Type)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Producer", row.Cells["producer"].Value);
                                    command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                                    command.Parameters.AddWithValue("@Type", row.Cells["type"].Value);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        LoadData();
                    }
                    break;
                case 2:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow)
                                    continue;

                                string query = $"INSERT INTO {CurrentTable[Key]} (id, model, speed, ram, hd, cd, price) VALUES (@Id, @Model, @Speed, @Ram, @Hd, @Cd, @Price)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                                    command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                                    command.Parameters.AddWithValue("@Speed", row.Cells["speed"].Value);
                                    command.Parameters.AddWithValue("@Ram", row.Cells["ram"].Value);
                                    command.Parameters.AddWithValue("@Hd", row.Cells["hd"].Value);
                                    command.Parameters.AddWithValue("@Cd", row.Cells["cd"].Value);
                                    command.Parameters.AddWithValue("@Price", row.Cells["price"].Value);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        LoadData();
                    }
                break;
                case 3:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow)
                                    continue;

                                string query = $"INSERT INTO {CurrentTable[Key]} (id, model, speed, ram, hd, cd, price, screenSize) VALUES (@Id, @Model, @Speed, @Ram, @Hd, @Cd, @Price, @ScreenSize)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                                    command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                                    command.Parameters.AddWithValue("@Speed", row.Cells["speed"].Value);
                                    command.Parameters.AddWithValue("@Ram", row.Cells["ram"].Value);
                                    command.Parameters.AddWithValue("@Hd", row.Cells["hd"].Value);
                                    command.Parameters.AddWithValue("@Cd", row.Cells["cd"].Value);
                                    command.Parameters.AddWithValue("@Price", row.Cells["price"].Value);
                                    command.Parameters.AddWithValue("@ScreenSize", row.Cells["screenSize"].Value);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        LoadData();
                    }
                break;
                case 4:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow)
                                    continue;

                                string query = $"INSERT INTO {CurrentTable[Key]} (id, model, color, type, price) VALUES (@Id, @Model, @Color, @Type, @Price)";
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Id", row.Cells["id"].Value);
                                    command.Parameters.AddWithValue("@Model", row.Cells["model"].Value);
                                    command.Parameters.AddWithValue("@Color", row.Cells["color"].Value);
                                    command.Parameters.AddWithValue("@Type", row.Cells["type"].Value);
                                    command.Parameters.AddWithValue("@Price", row.Cells["price"].Value);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        LoadData();
                    }
                    break;
            }

    }
        private void update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["model"].Value != null && row.Cells["model"].Value != row.Cells["model"].Value)
                        {
                            string query = $"UPDATE {CurrentTable[Key]} SET producer = @Producer, model = @Model, type = @Type";
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
        }
        private void delete_Button_Click(object sender, EventArgs e)
        {
            switch (Key)
            {
                case 1:
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            if (row.Cells["model"].Value != null)
                            {
                                string query = $"DELETE FROM {CurrentTable[Key]} WHERE model = @Model";
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
                break;
                case 2:
                    if (dataGridView1.SelectedRows.Count > 0)
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
                 break;
                case 3:
                    if (dataGridView1.SelectedRows.Count > 0)
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
                break;
                case 4:
                    if (dataGridView1.SelectedRows.Count > 0)
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
                 break;
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
