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
    public partial class Form_Shop_Details : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Form_Shop_Details()
        {
            InitializeComponent();
        }

        private void btn_add_shop_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#.NET\Shop_Details\Shop_Details.mdf;Integrated Security=True;Connect Timeout=30";
            cmd.Connection = con;
            con.Open();

            string city = cmb_shop_city.SelectedItem.ToString();
            string shopname = txt_shop_name.Text;
            string shopcategory = cmb_shop_category.SelectedItem.ToString();
            string shopaddress = txt_address.Text;
            string shopphone = txt_phone.Text;
            string web = string.Empty;
            if (rdb_yes.Checked) web = rdb_yes.Text; else if(rdb_no.Checked) web = rdb_no.Text;

            cmd.CommandText = "INSERT INTO tbl_shop_details(city, shop_name, shop_category, address, phone_number, has_website) VALUES(@city, @name, @cate, @address, @phone, @web)";
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@name", shopname);
            cmd.Parameters.AddWithValue("@cate", shopcategory);
            cmd.Parameters.AddWithValue("@address", shopaddress);
            cmd.Parameters.AddWithValue("@phone", shopphone);
            cmd.Parameters.AddWithValue("@web", web);

            int x = cmd.ExecuteNonQuery();

            if (x>0)
            {
                MessageBox.Show("Shop Added Successfully");
                cmb_shop_city.SelectedItem = null;
                txt_shop_name.Text = string.Empty;
                cmb_shop_category.SelectedItem = null;
                txt_address.Text = string.Empty;    
                txt_phone.Text = string.Empty;
                rdb_no.Checked = false;
                rdb_yes.Checked = false;
            }
            else
            {
                MessageBox.Show("Shop not Added Successfully");            }
        }

        private void btn_view_records_Click(object sender, EventArgs e)
        {
            Form_View_Shop obj = new Form_View_Shop();
            obj.ShowDialog();
        }
    }
}
