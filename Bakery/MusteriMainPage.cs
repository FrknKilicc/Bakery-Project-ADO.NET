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
    public partial class MusteriMainPage : Form
    {


        public MusteriMainPage()
        {
            InitializeComponent();
        }
        private MusteriMainPage activeForm = null;

        public void OpenChildForm(MusteriMainPage childForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");

        private void UrunlerButton_MouseLeave(object sender, EventArgs e)
        {
            UrunlerButton.BackColor = Color.FromArgb(40, 40, 45);
        }

        private void UrunlerButton_MouseEnter(object sender, EventArgs e)
        {
            UrunlerButton.BackColor = Color.MediumPurple;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriHesabım mhes = new MusteriHesabım();
            mhes.Show();
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(240, 230, 140);
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(40, 40, 45);
        }

        private void Siparişler_MouseEnter(object sender, EventArgs e)
        {
            Siparişler.BackColor = Color.FromArgb(240, 230, 140);
        }

        private void Siparişler_MouseLeave(object sender, EventArgs e)
        {
            Siparişler.BackColor = Color.FromArgb(40,40,45); 
        }

        private void HesabımMusteri_MouseEnter(object sender, EventArgs e)
        {
            HesabımMusteri.BackColor = Color.FromArgb(240, 230, 140);
        }

        private void HesabımMusteri_MouseLeave(object sender, EventArgs e)
        {
            HesabımMusteri.BackColor = Color.FromArgb(40, 40, 45);
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Urunler_Click(object sender, EventArgs e)
        {
            MusteriMainPage2 usdd = new MusteriMainPage2();
            usdd.Show();

           




        }



        private void MusteriMainPage_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Siparişler_Click(object sender, EventArgs e)
        {
            Siparisler sip = new Siparisler();

            sip.Show();


        }
    }
}
