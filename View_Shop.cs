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
using System.Data.Common;

namespace Shop_Details
{
    public partial class Form_View_Shop : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt;
        SqlDataAdapter adap;

        public Form_View_Shop()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#.NET\Shop_Details\Shop_Details.mdf;Integrated Security=True;Connect Timeout=30";
            cmd.Connection = con;
            con.Open();

            adap = new SqlDataAdapter(@"SELECT * FROM tbl_shop_details", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adap);
            dt = new DataTable();
            adap.Fill(dt);
            dgv_view_records.DataSource = dt;
        }

        private void btn_view_records_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int x = adap.Update(dt);
            if (x > 0)
                MessageBox.Show("Student Detail(s) Updated");
            else
                MessageBox.Show("Student Details(s) not Updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_view_records.SelectedRows.Count > 0)
            {
                int selectedID = Int32.Parse(dgv_view_records.SelectedRows[0].Cells[0].Value.ToString());

                foreach (DataGridViewRow row in dgv_view_records.SelectedRows)
                {
                    dt.Rows.RemoveAt(row.Index);
                }

                cmd.CommandText = "DELETE FROM tbl_shop_details WHERE Id = @id";
                cmd.Parameters.Clear(); // Clear previous parameters
                cmd.Parameters.AddWithValue("@id", selectedID);

                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Shop Details Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Shop Details not Deleted Successfully");
                }

                SqlCommandBuilder builder = new SqlCommandBuilder(adap);
                adap.Update(dt);

                dgv_view_records.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }
}
