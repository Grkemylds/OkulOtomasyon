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
    public partial class frmOgrenciler : Form
    {
        public frmOgrenciler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            //5. Sınıf
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1=new SqlDataAdapter("Execute OgrenciVeli5", bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl5.DataSource = dt1;

            // 6.Sınıf
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli6", bgl.baglanti());
            da2.Fill(dt2);
            GrdCtrl6.DataSource = dt2;

            // 7.Sınıf
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli7", bgl.baglanti());
            da3.Fill(dt3);
            GrdCtrl7.DataSource = dt3;

            // 8.Sınıf
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli8", bgl.baglanti());
            da4.Fill(dt4);
            GrdCtrl8.DataSource = dt4;
        }

        void veliListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select VELIID,(VELIANNE+' | '+VELIBABA) as VELIANNEBABA from TBL_VELİLER",bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELIID";
            lookUpEdit1.Properties.DisplayMember = "VELIANNEBABA";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void sehirekle()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskOgrenciNO.Text = "";
            mskTc.Text = "";
            RdbtnErkek.Checked = false;
            RdbtnKadın.Checked = false;
            comboBoxEdit1.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            dateEdit1.Text = "";
            rchAdres.Text = "";
            pictureEdit1.Text = "";
        }

        private void frmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();
            veliListesi();
        }
        
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from TBL_ILCELER where il_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[2]);
            }
            bgl.baglanti().Close();
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string Cinsiyet;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_OGRENCILER (OGRAD,OGRSOYAD,OGRNO,OGRSINIF,OGRDOGTAR,OGRCINSIYET,OGRTC,OGRIL, OGRILCE, OGRADRES, OGRFOTO,OGRVELIID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskOgrenciNO.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxEdit1.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (RdbtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", Cinsiyet = "E");

            }
            else
            {
                komut.Parameters.AddWithValue("@p6", Cinsiyet = "K");

            }
            komut.Parameters.AddWithValue("@p7", mskTc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAd.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTc.Text = dr["OGRTC"].ToString();
                mskOgrenciNO.Text = dr["OGRNO"].ToString();
                comboBoxEdit1.Text= dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString()=="E")
                {
                    RdbtnErkek.Checked = true;
                }
                else
                {
                    RdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

      

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAd.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTc.Text = dr["OGRTC"].ToString();
                mskOgrenciNO.Text = dr["OGRNO"].ToString();
                comboBoxEdit1.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdbtnErkek.Checked = true;
                }
                else
                {
                    RdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAd.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTc.Text = dr["OGRTC"].ToString();
                mskOgrenciNO.Text = dr["OGRNO"].ToString();
                comboBoxEdit1.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdbtnErkek.Checked = true;
                }
                else
                {
                    RdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRID"].ToString();
                txtAd.Text = dr["OGRAD"].ToString();
                txtSoyad.Text = dr["OGRSOYAD"].ToString();
                mskTc.Text = dr["OGRTC"].ToString();
                mskOgrenciNO.Text = dr["OGRNO"].ToString();
                comboBoxEdit1.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdbtnErkek.Checked = true;
                }
                else
                {
                    RdbtnKadın.Checked = true;
                }
                cmbil.Text = dr["OGRIL"].ToString();
                cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                rchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }
        private void GrdCtrl6_Click(object sender, EventArgs e)
        {

        }

        public string yeniyol;

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg; *.png;*.nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image = Image.FromFile(yeniyol);

        }

        private void RdbtnErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_OGRENCILER set OGRAD=@p1 ,OGRSOYAD=@p2,OGRNO=@p3,OGRSINIF=@p4,OGRDOGTAR=@p5,OGRCINSIYET=@p6,OGRTC=@p7,OGRIL=@p8,OGRILCE=@p9,OGRADRES=@p10,OGRFOTO=@p11,OGRVELIID=@p13 where OGRID=@p12 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskOgrenciNO.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxEdit1.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (RdbtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", Cinsiyet = "E");

            }
            else
            {
                komut.Parameters.AddWithValue("@p6", Cinsiyet = "K");

            }
            komut.Parameters.AddWithValue("@p7", mskTc.Text);
            komut.Parameters.AddWithValue("@p8", cmbil.Text);
            komut.Parameters.AddWithValue("@p9", cmbilce.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", txtID.Text);
            komut.Parameters.AddWithValue("@p13", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRENCILER where OGRID= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr!=null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }
    }
}
