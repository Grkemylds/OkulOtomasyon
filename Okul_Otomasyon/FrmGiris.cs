using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Okul_Otomasyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        DbOkulEntities db=new DbOkulEntities();

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTtc=@p1 and OGRTSIFRE =@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya şifre");
                mskTC.Text = "";
                txtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTtc=@p1 and OGRTSIFRE =@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmOgretmenAnamodul frm2 = new frmOgretmenAnamodul();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya şifre");
                mskTC.Text = "";
                txtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBL_OGRAYARLAR
                        join d2 in db.TBL_OGRENCILER
                        on d1.AYARLAROGRID equals d2.OGRID
                        where d2.OGRTC == mskTC.Text &&
                              d1.OGRSIFRE == txtSifre.Text
                        select d2;

            if (sorgu.Any())
            {
                FrmOgrenciAnaModül frm3 = new FrmOgrenciAnaModül();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı veya Şifre");
                mskTC.Text = "";
                txtSifre.Text = "";
            }
        }
    }
}
