using OyunKutusuV1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunKutusuV1
{
    public partial class frmSayiTahmin : Form
    {
        int tahminEdilecekSayi = 0;
        int sure = 0;
        int denemeSayisi = 0;
        public frmSayiTahmin()
        {
            InitializeComponent();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            tahminEdilecekSayi = new Random().Next(1, 100);
            timer1.Enabled = true;
            sure = 0;
            denemeSayisi = 0;
        }

        private void frmSayiTahmin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Doldur();
        }

        private void Doldur()
        {
            OyunKutusuContext db = new OyunKutusuContext();
            var liste = db.Skor
                .Where(x=> x.kullaniciID == Program.kullanici.kullaniciID)
                .OrderByDescending(x=> x.tarih)
                .Select(x=> new { 
                                x.puan,
                                x.tarih
                 })
                .Take(5)
                .ToList();
            dataSonBesOyunum.DataSource = liste;

            var liste2 = db.Skor
                .OrderByDescending(x => x.puan)
                .Select(x => new {
                    oyuncu = x.Kullanici.ad + " " + x.Kullanici.soyad,
                    x.tarih,
                    x.puan
                })
                .Take(5)
                .ToList();
            dataSonBesHerkes.DataSource = liste2;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure + 1;
            lblSure.Text = sure.ToString();
        }

        private void btmTahmin_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            if(sayi==tahminEdilecekSayi)
            {
                //doğru
                timer1.Enabled = false;
                //Puan Hesapla
                double puan = PuanHesapla(sure, denemeSayisi);
                // veritabanına yaz
                OyunKutusuContext db = new OyunKutusuContext();
                Skor s = new Skor();
                s.oyunID = 1;
                s.kullaniciID = Program.kullanici.kullaniciID;
                s.puan = puan;
                s.tarih = DateTime.Now;
                s.sure = sure;
                db.Skor.Add(s);
                db.SaveChanges();
                lblAciklama.Text = "Tebrikler " + puan + " puan kazandın";

                
            }
            else
            {
                denemeSayisi++;
                if (sayi > tahminEdilecekSayi)
                    lblAciklama.Text = "Daha küçük bir sayı";
                else
                    lblAciklama.Text = "Daha büyük bir sayı";

            }
        }
    
    
        private double PuanHesapla(int sure, int denemeSayisi)
        {
            double puan = 0;
            puan = 100 / denemeSayisi;
            if (sure < 15)
                puan = puan * 3;
            else if (sure < 30)
                puan = puan * 2;
            else if (sure < 60)
                puan = puan * 1;
            else
                puan = puan * 0.5;
            return puan;
        }
    }
}
