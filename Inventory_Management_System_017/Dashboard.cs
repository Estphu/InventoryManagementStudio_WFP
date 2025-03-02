﻿using System;
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
            menuStrip1.Renderer = new MyRenderer();
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


        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Goldenrod; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkTurquoise; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Goldenrod; }
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product p = new Product();
            p.Closed += (s, args) => this.Hide();
            p.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void WarehousesInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warehouses w = new Warehouses();
            w.Closed += (s, args) => this.Hide();
            w.Show();
        }
    }
}
