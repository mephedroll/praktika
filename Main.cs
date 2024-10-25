using System.Data;
using System.Net;

namespace Praktika
{
    public partial class Main : Form
    {
        Autorization autorization;
        PCCompany pccompany;
        Airport airport;
        SecondaryRowMaterials secondaryRowMaterials;
        Ships ships;

        public Main()
        {
            InitializeComponent();
            autorization = new Autorization(this);


        }

        private void PCCompany_button_Click(object sender, EventArgs e)
        {
            pccompany = new PCCompany();
        }

        private void Airport_button_Click(object sender, EventArgs e)
        {
            airport = new Airport();
        }

        private void SecondaryRow_button_Click(object sender, EventArgs e)
        {
            secondaryRowMaterials = new SecondaryRowMaterials();
        }

        private void Ships_button_Click(object sender, EventArgs e)
        {
            ships = new Ships();
        }
    }
}
  
