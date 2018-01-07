using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_3._0
{
    public class UrunKatalogu
    {
        public List<Urun> Urunler { get; set; }
        private Urun urun { get; set; }

        public void UrunEkle(Urun u)
        {
            Urunler.Add(u);
        }
        public string UrunListele()
        {
            string temp = "";

            foreach (Urun urun in Urunler)
            {
                temp += "Ürün Adı: " + urun.Adi + "       Ürün Markası: " + urun.Marka + 
                    "       Ürünün Fiyatı: " + urun.Fiyat +
                    "       Ürünün Seri Nosu: "+ urun.SeriNo + 
                    "      Ürünün Kodu: " + urun.UrunKodu +
                    Environment.NewLine + Environment.NewLine;
            }

            return temp;
         }

        public void UrunCikarma(Urun u)
        {
            Urunler.Remove(u);
        }
        
        public Urun UrunKontrol(int serino)
        {
            
            foreach (Urun u in Urunler)
	    {
            if (u.SeriNo == serino)
            {
                this.urun = u;
                break;
            }
        
	    }
            if (urun == null)
            {
                urun.SeriNo = 0;
            }
            return urun;
        }
        public UrunKatalogu()
        {
            urun = new Urun();
        }

        
    }
}
