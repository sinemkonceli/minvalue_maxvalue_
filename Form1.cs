using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int sayac;
        int sayi;
        int toplam;
        int buyuk=int.MinValue;
        int kucuk = int.MaxValue;
        double ort;

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            sayac++;
            int sayi = Convert.ToInt32(txtSayi.Text);
            lstSayi.Items.Add(sayac + " .Sayi: " + sayi);
            toplam += sayi;
            lblToplam.Text = toplam.ToString();
            ort = toplam / lstSayi.Items.Count;
            lblOrt.Text = ort.ToString();
            if (buyuk < sayi)
            {
                buyuk = sayi;
            }
            if (kucuk > sayi)
            {
                kucuk = sayi;
            }           
            txtSayi.Clear();
            lblEnKucuk.Text = kucuk.ToString();
            lblEnBuyuk.Text = buyuk.ToString();        
        }
    }
}
