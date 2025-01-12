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
using System.IO;

namespace Okul_Otomasyon
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        DbOkulEntities db= new DbOkulEntities();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgretmenler", bgl.baglanti());
            da1.Fill(dt);   
            gridControl1.DataSource = dt;

        }
        //Entity framework ile öğrenci listeleme
        void ogrListele()
        {
            gridControl2.DataSource = db.AyarlarOgrenciler();
        }
        void temizle()
        {
            txtOgrtID.Text = "";
            txtOgrID.Text = "";

            txtBrans.Text = "";
            TxtSınıf.Text = "";

            txtOgrSıfre.Text = "";
            txtOgrtSifre.Text = "";

            mskOgrtTC.Text = "";
            mskOgrTC.Text = "";

            pictureEdit1.Text = "";
            pictureEdit2.Text = "";

            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz.";
            lookUpEdit2.Properties.NullText = "Öğrenci Seçiniz.";

        }
        void ogretmenlisetesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(OGRTAD+' '+OGRTSOYAD) as 'OGRTADSOYAD', OGRTBRANS from TBL_OGRETMENLER", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "OGRTID";
            lookUpEdit1.Properties.DisplayMember = "OGRTADSOYAD";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz.";
            lookUpEdit1.Properties.DataSource = dt2;
        }
        //Entity framework ile LookUpEdit'e veri getirme listeleme
        void ogrenciListesi()
        {
            var deger = from item in db.TBL_OGRENCILER
                        select new
                        {
                            OGRID = item.OGRID,
                            OGRADSOYAD = item.OGRAD + " " + item.OGRSOYAD,
                            OGRSINIF = item.OGRSINIF,
                        };
            lookUpEdit2.Properties.ValueMember = "OGRID";
            lookUpEdit2.Properties.DisplayMember = "OGRADSOYAD";
            lookUpEdit2.Properties.NullText = "Öğrenci Seçiniz.";
            lookUpEdit2.Properties.DataSource = deger.ToList();
        }


        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlisetesi();
            ogrListele();
            ogrenciListesi();
            temizle();

        }

        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtOgrtSifre.Text = "";

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtOgrtID.Text = dr["AYARLARID"].ToString();
                lookUpEdit1.Text = dr["OGRTADSOYAD"].ToString();
                txtBrans.Text = dr["OGRTBRANS"].ToString();
                mskOgrtTC.Text = dr["OGRTTC"].ToString();
                txtOgrtSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }                                                                                               
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRETMENLER Where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.ItemIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {

                txtOgrtID.Text = dr3["OGRTID"].ToString();
                txtBrans.Text = dr3["OGRTBRANS"].ToString();
                mskOgrtTC.Text = dr3["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr3["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
            bgl.baglanti().Close();
        }

        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Insert into TBL_AYARLAR (AYARLARID,OGRTSIFRE) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtOgrtID.Text);
            komut2.Parameters.AddWithValue("@p2",txtOgrtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Oluştururdu.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnOgrtGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update TBL_AYARLAR set OGRTSIFRE=@p1 where AYARLARID=@p2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtOgrtSifre.Text);
            komut3.Parameters.AddWithValue("@p2", txtOgrtID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        } 


        private void btnOgrtTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }
       
        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtOgrID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID").ToString();
            lookUpEdit2.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRADSOYAD").ToString();
            TxtSınıf.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSINIF").ToString();
            mskOgrTC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRTC").ToString();
            txtOgrSıfre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSIFRE").ToString();
            string uzanti = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRFOTO").ToString();
            yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + uzanti;
            lookUpEdit2.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRADSOYAD").ToString();
            pictureEdit2.Image = Image.FromFile(yeniyol);
        }

        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            using (DbOkulEntities db =new DbOkulEntities())
            {
                txtOgrSıfre.Text = "";
                TBL_OGRENCILER sorgu = db.TBL_OGRENCILER.Find(lookUpEdit2.ItemIndex + 1);
                txtOgrID.Text = sorgu.OGRID.ToString();
                TxtSınıf.Text= sorgu.OGRSINIF;
                mskOgrTC.Text = sorgu.OGRTC;
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + sorgu.OGRFOTO;
                pictureEdit2.Image = Image.FromFile(yeniyol);


            }
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRAYARLAR komut = new TBL_OGRAYARLAR();
            komut.AYARLAROGRID= Convert.ToInt32(txtOgrID.Text);
            komut.OGRSIFRE = txtOgrSıfre.Text;
            db.TBL_OGRAYARLAR.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Şifre Oluştururdu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenciListesi();
            temizle();

        }
        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID"));
            var item =db.TBL_OGRAYARLAR.FirstOrDefault(x=>x.AYARLAROGRID==id);
            item.OGRSIFRE = txtOgrSıfre.Text;
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            ogrenciListesi();
            temizle();

        }
        private void btnOgrTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }
    }
}
