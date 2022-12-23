using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcs
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Search search = new Search();
            search.Show();
        }
    }
}
