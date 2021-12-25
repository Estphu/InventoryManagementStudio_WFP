using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_017
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewRegistration nr = new NewRegistration();
            nr.Closed += (s, args) => this.Hide();
            nr.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = new Customer();
            c.Closed += (s, args) => this.Hide();
            c.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category c = new Category();
            c.Closed += (s, args) => this.Hide();
            c.Show();
        }
    }
}
