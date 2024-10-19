using System.Data;
using System.Net;

namespace Praktika
{
    public partial class Main : Form
    {
        Autorization autorization;

        public Main()
        {
            InitializeComponent();
            autorization = new Autorization(this);
        }




    }
}
  
