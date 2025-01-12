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
using DevExpress.XtraPrinting;

namespace Okul_Otomasyon
{
    public partial class frmOgretmenler : Form
    {
        public frmOgretmenler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl =new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_OGRETMENLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_BRANSLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTc.Text = "";
            mskTelefon.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            cmbBrans.Text = ""; 
            txtMail.Text = "";
            rchAdres.Text = "";
            pcrResim.ImageLocation = "";
        }
        private void frmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransgetir();
        }


        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = "";

            SqlCommand komut = new SqlCommand("select * from TBL_ILCELER where il_id=@ap1", bgl.baglanti());
            komut.Parameters.AddWithValue("@ap1", cmbil.SelectedIndex + 1);
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMENLER (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMIAL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO) values(@ap1,@ap2,@ap3,@ap4,@ap5,@ap6,@ap7,@ap8,@ap9,@AP10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ap1", txtAd.Text);
            komut.Parameters.AddWithValue("@ap2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@ap3", mskTc.Text);
            komut.Parameters.AddWithValue("@ap4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@ap5", txtMail.Text);
            komut.Parameters.AddWithValue("@ap6", cmbil.Text);
            komut.Parameters.AddWithValue("@ap7", cmbilce.Text);
            komut.Parameters.AddWithValue("@ap8", rchAdres.Text);
            komut.Parameters.AddWithValue("@ap9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@ap10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OGRTID"].ToString();
                txtAd.Text = dr["OGRTAD"].ToString();
                txtSoyad.Text = dr["OGRTSOYAD"].ToString();
                mskTc.Text = dr["OGRTTC"].ToString();
                mskTelefon.Text = dr["OGRTTEL"].ToString();
                cmbil.Text = dr["OGRTIL"].ToString();
                cmbilce.Text = dr["OGRTILCE"].ToString();
                cmbBrans.Text = dr["OGRTBRANS"].ToString();
                txtMail.Text = dr["OGRTMIAL"].ToString();
                rchAdres.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pcrResim.ImageLocation = yeniyol;

            }
        }
        public string yeniyol;

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası  |*.jpg;png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu= dosya.FileName;
            yeniyol = "C:\\Users\\gorke\\Desktop\\C#Otomasyon\\Okul_Otomasyon - 3\\Okul_Otomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pcrResim.ImageLocation = yeniyol;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_OGRETMENLER set OGRTAD=@ap1 ,OGRTSOYAD=@ap2,OGRTTC=@ap3,OGRTTEL=@ap4,OGRTMIAL=@ap5,OGRTIL=@ap6,OGRTILCE=@ap7,OGRTADRES=@ap8,OGRTBRANS=@ap9,OGRTFOTO=@ap10 where OGRTID=@ap11", bgl.baglanti());
            komut.Parameters.AddWithValue("@ap1", txtAd.Text);
            komut.Parameters.AddWithValue("@ap2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@ap3", mskTc.Text);
            komut.Parameters.AddWithValue("@ap4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@ap5", txtMail.Text);
            komut.Parameters.AddWithValue("@ap6", cmbil.Text);
            komut.Parameters.AddWithValue("@ap7", cmbilce.Text);
            komut.Parameters.AddWithValue("@ap8", rchAdres.Text);
            komut.Parameters.AddWithValue("@ap9", cmbBrans.Text);
            komut.Parameters.AddWithValue("@ap10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@ap11", txtID.Text);
           komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRETMENLER where OGRTID=@ap1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@ap1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcrResim_Click(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rchAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
