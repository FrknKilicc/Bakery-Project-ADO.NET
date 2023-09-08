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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");

       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void YoneticiGirisRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (YoneticiGirisRadio.Checked)
            {
               

                KaıytOlRadio.Checked = false;
                MusteriGirisRadio.Checked = false;
                kadiMusteri.Visible = false;
                sifreMusteri.Visible = false;

                PanelGiris.Visible = true;
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                KadiYonetici.Visible = true;
                sifreYonetici.Visible = true;


            }

        }

        private void MusteriGirisRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MusteriGirisRadio.Checked)
            {
              


                KaıytOlRadio.Checked = false;
                YoneticiGirisRadio.Checked = false;

                KadiYonetici.Visible = false;
                sifreYonetici.Visible = false;

                PanelGiris.Visible = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
                kadiMusteri.Visible = true;
                sifreMusteri.Visible = true;
            }
        }

        private void KaıytOlRadio_CheckedChanged(object sender, EventArgs e)
        {

            if (KaıytOlRadio.Checked == true)
            {
                panel2.Visible = true;

               

            }


        }

        private void YonKytButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (YonKytButton2.Checked == true)
            {
                KayitOl.Visible = true;

                mkKYT.Visible = false;
                msKYT.Visible = false;
                mtKYT.Visible = false;

                ykkyt.Visible = true;
                yskyt.Visible = true;
                ytkyt.Visible = true;


            }

            else
            {

                KayitOl.Visible = false;
            }
        }

        private void MsKytButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (MsKytButton1.Checked == true)
            {
                KayitOl.Visible = true;
                ykkyt.Visible = false;
                yskyt.Visible = false;
                ytkyt.Visible = false;


                mkKYT.Visible = true;
                msKYT.Visible = true;
                mtKYT.Visible = true;

            }
            else
            {

                KayitOl.Visible = false;
            }
        }

        private void KayitOl_Click(object sender, EventArgs e)
        {

            if (MsKytButton1.Checked == true)
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Musteri (MusteriAdi,MusteriSifre,MusteriTelNo) values (@MusteriAdi,@MusteriSifre,@MusteriTelNo)",con);
                command.Parameters.AddWithValue("@MusteriAdi", mkKYT.Text);
                command.Parameters.AddWithValue("@MusteriSifre", msKYT.Text); 
                command.Parameters.AddWithValue("@MusteriTelNo", mtKYT.Text);

                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarılı, Hoşgeldiniz, " + mkKYT.Text);
                panel2.Visible = false;

            }
            else if (YonKytButton2.Checked == true)
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Yonetici (YoneticiAdi,YoneticiSifre,YoneticiTelNo) values (@YoneticiAdi,@YoneticiSifre,@YoneticiTelNo)",con);
                command.Parameters.AddWithValue("@YoneticiAdi", ykkyt.Text);
                command.Parameters.AddWithValue("@YoneticiSifre", yskyt.Text);
                command.Parameters.AddWithValue("@YoneticiTelNo", ytkyt.Text);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sayın Yönetici, Kaydınız Başarılı, Hoşgeldiniz ");
                panel2.Visible = false;
            }


        }


        public static string loginname="";
        public static string pw;

        public void GirisYap_Click(object sender, EventArgs e)
        {
            if (YoneticiGirisRadio.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select*from Yonetici where yoneticiAdi=@yoneticiAdi and yoneticiSifre=@yoneticiSifre", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@yoneticiAdi", KadiYonetici.Text);
                cmd.Parameters.AddWithValue("@yoneticiSifre", sifreYonetici.Text);
                KadiYonetici.Text = loginname;
                sifreMusteri.Text = pw;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    con.Close(); 

                    MessageBox.Show("Giriş Başarılı, Hoşgeldiniz Sayın Yönetici Yönlendiriliyorsunuz");
                    yoneticiMainPage yonetici = new yoneticiMainPage();
                    Form1 oldform = new Form1();
                    oldform.Hide();
                    yonetici.Show();

                }
                else
                {
                    con.Close();

                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");

                }



            }  
          

            else if (MusteriGirisRadio.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select*from Musteri where musteriAdi=@musteriAdi and musteriSifre=@musteriSifre", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@musteriAdi", kadiMusteri.Text);
                cmd.Parameters.AddWithValue("@musteriSifre", sifreMusteri.Text);
              loginname = kadiMusteri.Text;
                pw=sifreMusteri.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    con.Close();

                    MessageBox.Show("Giriş Başarılı, Hoşgeldiniz Sayın " + kadiMusteri.Text + " Yönlendiriliyorsunuz");
                    MusteriMainPage musteri = new MusteriMainPage();
                    musteri.Show();
                    Form1 oldform = new Form1();
                    oldform.Visible=false;


                }
                else
                {
                    con.Close();

                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }



            }
        }
    }
}

