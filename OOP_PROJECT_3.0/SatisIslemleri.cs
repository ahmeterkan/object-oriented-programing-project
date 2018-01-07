using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_3._0
{
    public class SatisIslemleri
    {
        public List<Urun> SatilanUrunler { get; set; }
        public double ToplamTutar { get; set; }

        public void SatilanUrun(Urun urun)
        {
            SatilanUrunler.Add(urun);
 
        }

        public string SatilanUrunListeleme()
        {
            string temp = "";

            foreach (Urun u in SatilanUrunler)
            {
                temp += "Ürün Adı: " + u.Adi + "       Ürün Markası: " + u.Marka +
                    "       Ürünün Fiyatı: " + u.Fiyat +
                    "       Ürünün Seri Nosu: " + u.SeriNo +
                    "       Ürünün Kodu: " + u.UrunKodu +
                    "       Satış Tarihi: "+u.SatısTarihi+
                    Environment.NewLine + Environment.NewLine;
            }

            return temp;
        }
        public int UrunKontrol(int serino)
        {
            int kontrol=0;
            foreach (Urun u in SatilanUrunler)
            {
                
                if (u.SeriNo == serino)
                {
                     kontrol= u.SeriNo;
                    break;
                }

            }

            return kontrol;
        }

    }
}
