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

        }

        private void PCCompany_button_Click(object sender, EventArgs e)
        {
            pccompany = new PCCompany();
            Hide();
            pccompany.ShowDialog();
            Show();
        }

        private void Airport_button_Click(object sender, EventArgs e)
        {
            airport = new Airport();
            Hide();
            airport.ShowDialog();
            Show();
        }

        private void SecondaryRow_button_Click(object sender, EventArgs e)
        {
            secondaryRowMaterials = new SecondaryRowMaterials();
            Hide();
            secondaryRowMaterials.ShowDialog();
            Show();
        }

        private void Ships_button_Click(object sender, EventArgs e)
        {
            ships = new Ships();
            Hide();
            ships.ShowDialog();
            Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
  
