using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_3._0
{
    public class MarketGorevlisi : Kisi
    {
        public int GorevliKimligi { get; set; }
        public int Sifre { get; set; }
        
        public MarketGorevlisi(decimal TCKimlikNo, string Ad, string Soyad, int GorevliKimliği, int Sifre)
        {
            this.GorevliKimligi = GorevliKimliği;
            this.Sifre = Sifre;
            this.Soyad = Soyad;
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
        }

        public override string KisiListele()
        {
            return base.KisiListele() + " Görevli Kimliği: " + GorevliKimligi + " Şifre: " + Sifre + Environment.NewLine + Environment.NewLine; 
        }
    }
}
