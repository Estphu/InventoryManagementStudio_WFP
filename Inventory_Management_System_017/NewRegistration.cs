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
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            String qr = "insert into tblUSer(UserName,FullName,Pass,Mobile,City,Country,RoleID) values (@UserName,@FullName,@Pass,@Mobile,@City,@Country,@RoleID)";
            SqlCommand cmd = new SqlCommand(qr, conn);
            cmd.Parameters.AddWithValue("@UserName",rUserName_txt.Text);
            cmd.Parameters.AddWithValue("@FullName", rFullName_txt.Text);
            cmd.Parameters.AddWithValue("@Pass", rPassword_txt.Text);
            cmd.Parameters.AddWithValue("@Mobile", rMobileNo_txt.Text);
            cmd.Parameters.AddWithValue("@City", rCity_txt.Text);
            cmd.Parameters.AddWithValue("@Country", rCountry_txt.Text);
            cmd.Parameters.AddWithValue("@RoleID", Convert.ToInt32(4));
            int i = 0;
            conn.Open();
            i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i>=0)
            {
                MessageBox.Show("New User Added Sucessfully");
                populatedGridView();
                clr();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
        private void populatedGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("set nocount on; select t1.FullName as [Full Name], t1.UserName as [User Name], t1.Pass as Password, t1.Mobile, t1.City, t1.Country, t2.RoleName from tblUser as t1 with(nolock) inner join tblRole as t2 with(nolock) on t2.RoleID = t1.RoleID", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                dataGridView.DataSource = dt;
            }
            else
            {
                dataGridView.DataSource = null;
            }
            conn.Close();
        }

        private void NewRegistration_Load(object sender, EventArgs e)
        {
            populatedGridView();
        }

        private void clr()
        {
            rFullName_txt.Clear();
            rUserName_txt.Clear();
            rPassword_txt.Clear();
            rMobileNo_txt.Clear();
            rCity_txt.Clear();
            rCountry_txt.Clear();
            rFullName_txt.Focus();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rFullName_txt.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            rUserName_txt.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            rPassword_txt.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            rMobileNo_txt.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            rCity_txt.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            rCountry_txt.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            String role = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            rUserName_txt.ReadOnly = true;
            add_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(rUserName_txt.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from tblUser where UserName=@UserName", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@UserName", rUserName_txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                populatedGridView();
                clr();
                rUserName_txt.ReadOnly = false;
                add_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Username not valid!");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (rUserName_txt.Text != string.Empty && rFullName_txt.Text != string.Empty && rPassword_txt.Text != string.Empty && rMobileNo_txt.Text != string.Empty && rCity_txt.Text != string.Empty && rCountry_txt.Text != string.Empty)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update tblUser set FullName=@FN,Pass=@P,Mobile=@M,City=@City,Country=@Country where UserName=@UN", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@UN", rUserName_txt.Text);
                cmd.Parameters.AddWithValue("@FN", rFullName_txt.Text);
                cmd.Parameters.AddWithValue("@P", rPassword_txt.Text);
                cmd.Parameters.AddWithValue("@M", rMobileNo_txt.Text);
                cmd.Parameters.AddWithValue("@City", rCity_txt.Text);
                cmd.Parameters.AddWithValue("@Country", rCountry_txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                populatedGridView();
                clr();
                rUserName_txt.ReadOnly = false;
                add_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Username not valid!");
            }
        }
    }
}
