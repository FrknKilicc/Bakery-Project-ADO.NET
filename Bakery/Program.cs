using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //Yönetici girişi ve Müşteri Girişi

            //Yönetici girişi sonrası :

            //Müşteri Girişi: 

            //Sadece ürünleri listeleyecek, Sipariş verebilecek ,ürün görselleri olacak ,sipariş listesi görebilecek 


        }
    }
}
