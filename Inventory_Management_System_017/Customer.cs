using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Management_System_017
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(cCustomerName_txt.Text != String.Empty && cAddress_txt.Text != String.Empty && cMobileNo_txt.Text != String.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                String qr = "insert into tblCustomer(CustomerName,Address,Mobile) values (@CustomerName,@Address,@Mobile)";
                SqlCommand cmd = new SqlCommand(qr, conn);
                cmd.Parameters.AddWithValue("@CustomerName", cCustomerName_txt.Text);
                cmd.Parameters.AddWithValue("@Address", cAddress_txt.Text);
                cmd.Parameters.AddWithValue("@Mobile", cMobileNo_txt.Text);
                int i = 0;
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 0)
                {
                    MessageBox.Show("New Customer Added Sucessfully");
                    populatedGridView();
                    clr();
                }
                else
                {
                    MessageBox.Show("Failed");
                    clr();
                }
            }
        }
        //select CustomerName, Address, Mobile from tblCustomer
        private void populatedGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ID, CustomerName, Address, Mobile from tblCustomer", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }
            else
            {
                dataGridView.DataSource = null;
            }
            conn.Close();
        }

        private void clr()
        {
            cCustomerName_txt.Clear();
            cAddress_txt.Clear();
            cMobileNo_txt.Clear();
            label2.Text = "";
            cCustomerName_txt.Focus();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            cCustomerName_txt.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            cAddress_txt.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            cMobileNo_txt.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            add_btn.Enabled = false;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            clr();
            populatedGridView();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (label2.Text != string.Empty && cCustomerName_txt.Text != string.Empty && cAddress_txt.Text != string.Empty && cMobileNo_txt.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update tblCustomer set CustomerName=@CN,Address=@A,Mobile=@M where ID=@ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", label2.Text);
                cmd.Parameters.AddWithValue("@CN", cCustomerName_txt.Text);
                cmd.Parameters.AddWithValue("@A", cAddress_txt.Text);
                cmd.Parameters.AddWithValue("@M", cMobileNo_txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Customer name not valid!");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (label2.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from tblCustomer where ID=@ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(label2.Text.Trim()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Customer name not valid!");
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Closed += (s, args) => this.Hide();
            d.Show();
        }
    }
}
