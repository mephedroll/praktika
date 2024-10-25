using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class SecondaryRowMaterials : Form
    {
        string connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=SecondaryRowMaterialsCompany;Integrated Security=True;Encrypt=False";
        int Key = 1;
        Dictionary<int, string> CurrentTable = new Dictionary<int, string>()
        {
            [1] = "Income_o",
            [2] = "Income",
            [3] = "Outcome_o",
            [4] = "Outcome"
        };
        public SecondaryRowMaterials()
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

        private void SecondaryRowMaterials_Load(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
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
    }
}
