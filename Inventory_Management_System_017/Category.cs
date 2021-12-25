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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Closed += (s, args) => this.Hide();
            d.Show();
        }

        private void populatedGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("set nocount on; select ID, CategoryName from tblCategory", conn);
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
            pCategoryName_txt.Clear();
            pCategoryName_txt.Focus();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            clr();
            label4.Text = "";
            populatedGridView();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (pCategoryName_txt.Text != String.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                String qr = "insert into tblCategory(CategoryName) values (@CategoryName)";
                SqlCommand cmd = new SqlCommand(qr, conn);
                cmd.Parameters.AddWithValue("@CategoryName", pCategoryName_txt.Text);
                int i = 0;
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 0)
                {
                    MessageBox.Show("New Category Added Sucessfully");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (label4.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from tblCategory where ID=@ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(label4.Text.Trim()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Category name not valid!");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (label4.Text != string.Empty && pCategoryName_txt.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update tblCategory set CategoryName=@CN where ID=@ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", label4.Text);
                cmd.Parameters.AddWithValue("@CN", pCategoryName_txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                populatedGridView();
                clr();
                add_btn.Enabled = true;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Category name not valid!");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            pCategoryName_txt.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            add_btn.Enabled = false;
        }
    }
}
