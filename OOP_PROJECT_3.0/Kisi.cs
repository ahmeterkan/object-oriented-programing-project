using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_3._0
{
    public abstract class Kisi
    {
        protected decimal TCKimlikNo { get; set; }
        public string Ad { get; set; }
        protected string Soyad { get; set; }

        public virtual string KisiListele()
        {
            string temp = "";
            temp = " TC Kimlik No: " + TCKimlikNo + " Ad: " + Ad + " Soyad: " + Soyad;
            return temp;
        }
    }
}
