using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT_3._0
{
    public partial class frmMarketIslemleri : Form
    {
        UrunKatalogu UrunKatalogu = new UrunKatalogu();
        SatisIslemleri SatisIslemleri = new SatisIslemleri();
        double toplamtutar = 0;
        public frmMarketIslemleri()
        {
            InitializeComponent();
            UrunKatalogu.Urunler = new List<Urun>();

            Urun urun = new Urun();
            urun.Adi = "Kola";
            urun.Fiyat = 4;
            urun.Marka = "Pepsi";
            urun.SeriNo = 1453;
            urun.UrunKodu = 1071;
            UrunKatalogu.UrunEkle(urun);

            SatisIslemleri.SatilanUrunler = new List<Urun>();
        
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            Urun u = new Urun();

            u = UrunKatalogu.UrunKontrol(Convert.ToInt32(txtSeriNo.Text));
            
                if (txtSeriNo.Text == u.SeriNo.ToString())
                {
                    MessageBox.Show("Bu Seri No'da bi Ürün Zaten Var");
                }
            
            else 
            {
                urun.Adi = txtAdi.Text;
                urun.Fiyat = Convert.ToDouble(txtFiyat.Text);
                urun.Marka = txtMarka.Text;
                urun.SeriNo = Convert.ToInt32(txtSeriNo.Text);
                urun.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);

                UrunKatalogu.UrunEkle(urun);
                txtAdi.Text = "";
                txtFiyat.Text = "";
                txtMarka.Text = "";
                txtSeriNo.Text = "";
                txtUrunKodu.Text = "";
            }
        }

        private void btnUrunleriListele_Click(object sender, EventArgs e)
        {
            txtUrunListeleSeriNo.Text = UrunKatalogu.UrunListele();
        }
        
        private void btnUrunSeriNoGiris_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            
            u=UrunKatalogu.UrunKontrol(Convert.ToInt32(txtUrunSeriNoGiris.Text));

            if (txtUrunSeriNoGiris.Text == u.SeriNo.ToString())
            {
                if (SatisIslemleri.UrunKontrol(Convert.ToInt32(txtUrunSeriNoGiris.Text)) == 0)
                {
                    txtUrunSeriNo.Text += u.SeriNo.ToString() + Environment.NewLine;
                    txtUrunAdi.Text += u.Adi + Environment.NewLine;
                    txtTutar.Text += u.Fiyat.ToString() + Environment.NewLine;
                    u.SatısTarihi = DateTime.Now;
                    toplamtutar += u.Fiyat;
                    txtToplamTutar.Text = toplamtutar.ToString();

                    SatisIslemleri.SatilanUrun(u);

                    UrunKatalogu.UrunCikarma(u);
                    txtUrunSeriNoGiris.Text = "0";
                }
                else
                {
                    MessageBox.Show("Bu Ürün zaten Satıldı!!");
                }
            }
            else if (txtUrunSeriNoGiris.Text == "0")
                MessageBox.Show("Lütfen Seri No Girin!!!");
            else
                MessageBox.Show("Girilen Ürün Bulunamadı!!!");
        }

        private void btnSatilanUrunleriListele_Click(object sender, EventArgs e)
        {

            txtSatilanUrunleriListele.Text = SatisIslemleri.SatilanUrunListeleme();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Musteri m1 = new Musteri(12345678912, "Mertcan", "Baş", 1234,"10/10/2010");
            Musteri m = new Musteri(12345678912, "Ahmet", "Erkan", 100,"11/11/2011");
            txtMusteriListele.Text = m1.KisiListele();
            txtMusteriListele.Text += m.KisiListele();
        }   

        private void btnKasaGorevlileriniListele_Click(object sender, EventArgs e)
        {

            MarketGorevlisi m = new MarketGorevlisi(12345678912, "Merve", "Köle", 26122016, 26122016);
            MarketGorevlisi m1 = new MarketGorevlisi(12345678912, "Leyla", "Yılmaz", 10102015, 10102016);

            txtKasaGorevlileriniListeleme.Text = m.KisiListele();
            txtKasaGorevlileriniListeleme.Text += m1.KisiListele();
        }
    }
}
