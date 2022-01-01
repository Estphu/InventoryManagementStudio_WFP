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

namespace Inventory_Management_System_017
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text != String.Empty && txtProductName.Text != String.Empty && txtProductAmount.Text != String.Empty && selectedWarehouse.SelectedItem != null)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                String qr = "insert into tblProduct(ProductCode,ProductName,ProductAmount,ProductStatus,SelectedWarehouse) values (@ProductCode,@ProductName,@ProductAmount,@ProductStatus,@SelectedWarehouse)";
                SqlCommand cmd = new SqlCommand(qr, conn);
                cmd.Parameters.AddWithValue("@ProductCode", Convert.ToInt32(txtProductCode.Text));
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@ProductAmount", Convert.ToInt32(txtProductAmount.Text));
                if (chkActive.Checked) 
                {
                    cmd.Parameters.AddWithValue("@ProductStatus", "Active");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ProductStatus", "Inactive");
                }
                cmd.Parameters.AddWithValue("@SelectedWarehouse", selectedWarehouse.SelectedValue.ToString());
                int i = 0;
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 0)
                {
                    MessageBox.Show("New Product Added Sucessfully");
                    populatedGridView();
                    clr();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
        }
        private void populatedGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("set nocount on; select ID, ProductCode, ProductName, ProductAmount, ProductStatus, SelectedWarehouse from tblProduct", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                productGridView.DataSource = dt;
            }
            else
            {
                productGridView.DataSource = null;
            }
            conn.Close();
        }
        private void clr()
        {

            txtProductCode.Focus();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtProductAmount.Clear();
            chkActive.Checked = false;
            autoID.Text = "";

        }


        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryProject00DataSet.tblWarehouse' table. You can move, or remove it, as needed.
            this.tblWarehouseTableAdapter.Fill(this.inventoryProject00DataSet.tblWarehouse);
            clr();
            populatedGridView();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Closed += (s, args) => this.Hide();
            d.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != string.Empty && txtProductCode.Text != string.Empty && txtProductAmount.Text != string.Empty && selectedWarehouse.SelectedValue != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update tblProduct set ProductCode=@PC,ProductName=@PN,ProductAmount=@PA,SelectedWarehouse=@SW,ProductStatus=@PS where ProductCode=@PC", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@PC", Convert.ToInt32(txtProductCode.Text));
                cmd.Parameters.AddWithValue("@PN", txtProductName.Text);
                cmd.Parameters.AddWithValue("@PA", Convert.ToInt32(txtProductAmount.Text));
                cmd.Parameters.AddWithValue("@SW", selectedWarehouse.SelectedValue.ToString());
                if (chkActive.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@PS", "Active");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PS", "Inactive");
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Product name not valid!");
            }
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductCode.Text = productGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtProductName.Text = productGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtProductAmount.Text = productGridView.SelectedRows[0].Cells[3].Value.ToString();
            if ( productGridView.SelectedRows[0].Cells[4].Value.ToString() == "Active" )
            {
                chkActive.Checked = true;
            }
            else
            {
                chkActive.Checked = false;
            }
            selectedWarehouse.SelectedValue = productGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtProductCode.ReadOnly = true; 
            add_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != string.Empty && txtProductCode.Text != string.Empty && txtProductAmount.Text != string.Empty && selectedWarehouse.SelectedValue != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from tblProduct where ProductCode=@ProductCode", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ProductCode", Convert.ToInt32(txtProductCode.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Product not valid!");
            }
        }
    }
}
