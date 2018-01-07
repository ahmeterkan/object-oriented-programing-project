using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_3._0
{
    public class Musteri : Kisi
    {
        public int MusteriNo { get; set; }
        public string KayıtTarihi { get; set; }

        public Musteri(decimal TCKimlikNo, string Ad, string Soyad, int MusteriNo, string KayıtTarihi)
        {
            this.KayıtTarihi = KayıtTarihi;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.TCKimlikNo = TCKimlikNo;
            this.MusteriNo = MusteriNo;

        }

        public override string KisiListele()
        {
            return base.KisiListele() + " Müşteri No: " + MusteriNo + " Müşteri Kayıt Tarihi: " + KayıtTarihi + Environment.NewLine + Environment.NewLine;
        }
        
    }
}
