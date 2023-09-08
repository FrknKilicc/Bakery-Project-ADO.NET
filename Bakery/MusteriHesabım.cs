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
    public partial class MusteriHesabım : Form
    {
        public MusteriHesabım()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");
        
        private void MusteriHesabım_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT MusteriID, MusteriAdi, MusteriSifre, MusteriTelNo FROM Musteri WHERE MusteriAdi = @Username AND MusteriSifre = @Password";
           
           
            
            
            SqlCommand cmd = new SqlCommand(query, con);
            Form1 das = new Form1();

            cmd.Parameters.AddWithValue("@Username", Form1.loginname);
            cmd.Parameters.AddWithValue("@Password", Form1.pw);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string customerName = reader["MusteriAdi"].ToString();
                string customerPW = reader["MusteriSifre"].ToString();
                string Phone = reader["MusteriTelNo"].ToString();

                textBox1.Text = customerName;
                textBox2.Text = customerPW;
                textBox3.Text = Phone;



                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;

                con.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }

        }
    }
}
