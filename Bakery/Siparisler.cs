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

    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("server = FURKAN\\FURKANKILIC;Database=borcelle_bakery;Integrated Security=true;");

        private void Listele_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select prd.UrunlerAdi as [Ürün Adı], prd.UrunKodu, ord.BirimFiyat  from orderDetails ord left join Products prd on ord.UrunlerID = prd.ProducID", con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);
            dataGridView1.DataSource = filldata;
            con.Close();
        }
    }
}
