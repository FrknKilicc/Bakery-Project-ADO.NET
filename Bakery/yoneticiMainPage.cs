using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class yoneticiMainPage : Form
    {
        public yoneticiMainPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                string query = "select orders.SiparisID,UrunlerAdi,UrunKodu,orderDetails.BirimFiyat,MusteriAdi, MusteriTelNo from Orders inner join orderDetails on orders.SiparisID=orderDetails.SiparisID left join Products on orderDetails.UrunlerID=Products.ProducID inner join Musteri on Musteri.MusteriID=Orders.MusteriID";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                //
                string query = "select MusteriAdi ,count(*) as Sipariş_Adedi,SUM(orderDetails.BirimFiyat)as Toplam_Sipariş_Tutarı from Musteri inner join Orders on Musteri.MusteriID=Orders.MusteriID inner join orderDetails on orderDetails.SiparisID = Orders.SiparisID group by Musteri.MusteriAdi";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void yoneticiMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
