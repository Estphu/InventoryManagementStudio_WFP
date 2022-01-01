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
    public partial class Warehouses : Form
    {
        public Warehouses()
        {
            InitializeComponent();

        }

        private void btnKarachiWH_Click(object sender, EventArgs e)
        {
            this.Hide();
            KarachiWarehouse kw = new KarachiWarehouse();
            kw.Closed += (s, args) => this.Hide();
            kw.Show();
        }

        private void btnLahoreWH_Click(object sender, EventArgs e)
        {
            this.Hide();
            LahoreWareHouse lw = new LahoreWareHouse();
            lw.Closed += (s, args) => this.Hide();
            lw.Show();
        }

        private void btnQuettaWH_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuettaWarehouse qw = new QuettaWarehouse();
            qw.Closed += (s, args) => this.Hide();
            qw.Show();
        }

        private void btnIslamabadWH_Click(object sender, EventArgs e)
        {
            this.Hide();
            IslamabadWarehouse lw = new IslamabadWarehouse();
            lw.Closed += (s, args) => this.Hide();
            lw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Closed += (s, args) => this.Hide();
            d.Show();
        }
    }
}
