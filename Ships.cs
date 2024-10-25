using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Ships : Form
    {
        string connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=Ships;Integrated Security=True;Encrypt=False";
        int Key = 1;
        Dictionary<int, string> CurrentTable = new Dictionary<int, string>()
        {
            [1] = "Classes",
            [2] = "Ships",
            [3] = "Battles",
            [4] = "Outcomes"
        };
        public Ships()
        {
            InitializeComponent();
        }

        private void Ships_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
