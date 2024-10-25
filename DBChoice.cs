using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Praktika
{

    public partial class DBChoice : Form
    {
        string connectionString = "";

        private SqlConnection sqlConnection = null;


        private SqlDataAdapter sqlDataAdapter = null;  

       //Autorization autorization;
        public DBChoice()
        {
            InitializeComponent();
            //autorization = new Autorization(this);
        }

        private void pccompany_Button_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=PCCompany;Integrated Security=True;Encrypt=False";
        }

        private void secondaryMaterial_Button_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=SecondaryRowMaterialsCompany;Integrated Security=True;Encrypt=False";
        }

        private void Ships_Button_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=Ships;Integrated Security=True;Encrypt=False";
        }

        private void airport_Button_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-DUT2LRI\\SQLEXPRESS;Initial Catalog=Airport;Integrated Security=True;Encrypt=False";
        }
    }
}
