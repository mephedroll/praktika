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
    public partial class PCCompanyClarification : Form
    {
        public PCCompanyClarification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-DUT2LRI\\\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False\"";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Product (producer, model, type) VALUES (@Name, @Price, @Type)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Price", textBox2.Text);
                    command.Parameters.AddWithValue("@Type", textBox3.Text);
                    command.ExecuteNonQuery();
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=DESKTOP-DUT2LRI\\\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False\"";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells["Id"].Value != null) // Перевірка наявності даних
            //        {
            //            string query = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id";
            //            using (SqlCommand command = new SqlCommand(query, connection))
            //            {
            //                command.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);
            //                command.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
            //                command.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
            //                command.ExecuteNonQuery();
            //            }
            //        }
            //    }
            //}
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
