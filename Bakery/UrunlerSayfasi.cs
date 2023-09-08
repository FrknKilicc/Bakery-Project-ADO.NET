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

namespace Bakery
{
    public partial class MusteriMainPage2 : Form
    {
        public MusteriMainPage2()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");


        public void groupBox1_Enter(object sender, EventArgs e)
        {



        }

        public decimal selectedProductPrice = 0;
        public void UrunlerPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                SqlCommand command = new SqlCommand("select*from Products where ProducID=1002", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string prodID = reader["ProducID"].ToString();
                    label9.Tag = prodID;
                    string productName = reader["UrunlerAdi"].ToString();
                    label10.Text = productName;
                    string productCode = reader["UrunKodu"].ToString();
                    label9.Text = productCode;


                    selectedProductPrice = Convert.ToDecimal(reader["BirimFiyat"]);
                    label8.Text = selectedProductPrice.ToString("C");



                }
            }
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                SqlCommand command = new SqlCommand("select*from Products where ProducID=1001", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string prodID = reader["ProducID"].ToString();
                    label1.Tag = prodID;
                    string productName = reader["UrunlerAdi"].ToString();
                    label1.Text = productName;
                    string productCode = reader["UrunKodu"].ToString();
                    label2.Text = productCode;


                    selectedProductPrice = Convert.ToDecimal(reader["BirimFiyat"]);
                    label3.Text = selectedProductPrice.ToString("C");



                }
            }
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                SqlCommand command = new SqlCommand("select*from Products where ProducID=1003", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string prodID = reader["ProducID"].ToString();
                    label15.Tag = prodID;
                    string productName = reader["UrunlerAdi"].ToString();
                    label15.Text = productName;
                    string productCode = reader["UrunKodu"].ToString();
                    label14.Text = productCode;


                    selectedProductPrice = Convert.ToDecimal(reader["BirimFiyat"]);
                    label13.Text = selectedProductPrice.ToString("C");



                }
            }
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                SqlCommand command = new SqlCommand("select*from Products where ProducID=1004", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string prodID = reader["ProducID"].ToString();
                    label25.Tag = prodID;
                    string productName = reader["UrunlerAdi"].ToString();
                    label25.Text = productName;
                    string productCode = reader["UrunKodu"].ToString();
                    label24.Text = productCode;


                    selectedProductPrice = Convert.ToDecimal(reader["BirimFiyat"]);
                    label23.Text = selectedProductPrice.ToString("C");



                }
            }
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                SqlCommand command = new SqlCommand("select*from Products where ProducID=1005", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string prodID = reader["ProducID"].ToString();
                    label20.Tag = prodID;
                    string productName = reader["UrunlerAdi"].ToString();
                    label20.Text = productName;
                    string productCode = reader["UrunKodu"].ToString();
                    label19.Text = productCode;


                    selectedProductPrice = Convert.ToDecimal(reader["BirimFiyat"]);
                    label18.Text = selectedProductPrice.ToString("C");



                }
            }






        }


        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


            int selectedQuantity = (int)numericUpDown1.Value;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;"))
            {
                con.Open();

                SqlCommand command = new SqlCommand("insert into orderDetails (UrunlerID,BirimFiyat) values (@UrunlerID,@BirimFiyat)", con);
                command.Parameters.AddWithValue("@UrunlerID", label1.Tag);

                command.Parameters.AddWithValue("@BirimFiyat", selectedProductPrice);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sipariş başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Sipariş eklenirken bir hata oluştu.");

                }

            }
;
          

        }

        public void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
