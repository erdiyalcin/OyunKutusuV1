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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            frmSayiTahmin frm = new frmSayiTahmin();
            frm.Show();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            //dataListeyi doldur
            OyunKutusuContext db = new OyunKutusuContext();
            var liste = db.Skor
                .OrderByDescending(x => x.tarih)
                .Select(x => new {
                    oyuncu = x.Kullanici.ad + " " + x.Kullanici.soyad,
                    x.tarih,
                    x.puan
                })
                .Take(20)
                .ToList();
            dataListe.DataSource = liste;
        }
    }
}
