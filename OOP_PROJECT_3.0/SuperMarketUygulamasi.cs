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
    public partial class frmSuperMarketUygulaması : Form
    {
        public frmSuperMarketUygulaması()
        {
            InitializeComponent();
        }

        MarketGorevlisi m = new MarketGorevlisi(12345678912, "Ahmet", "ERKAN", 26122016, 26122016);

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKimlikNo.Text) == m.GorevliKimligi && Convert.ToInt32(txtSifre.Text) == m.Sifre)
            {
                MessageBox.Show("İşlem Başarılı !!!"+Environment.NewLine+"Hoşgeldiniz " + m.Ad);
                frmMarketIslemleri frm = new frmMarketIslemleri();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış Tekrar Deneyiniz !!!");
                txtKimlikNo.Text = "";
                txtSifre.Text = "";
            }
        }
    }
}
