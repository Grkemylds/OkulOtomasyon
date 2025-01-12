using System;
using System.Linq;
using System.Windows.Forms;

namespace Okul_Otomasyon
{
    public partial class frmVeliler : Form
    {
        public frmVeliler()
        {
            InitializeComponent();
        }

        DbOkulEntities db = new DbOkulEntities();

        void listele()
        {
            gridControl1.DataSource = db.TBL_VELİLER.ToList();
            gridView1.Columns[6].Visible = false;
        }
        void temizle()
        {
            txtID.Text = "";
            txtAnneAd.Text = "";
            txtBabaAd.Text = "";
            mskTelefon1.Text = "";
            mskTelefon2.Text = "";
            txtMail.Text = "";
        }
        private void frmVeliler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            TBL_VELİLER veli = new TBL_VELİLER();
            veli.VELIANNE = txtAnneAd.Text;
            veli.VELIBABA = txtBabaAd.Text;
            veli.VELITEL1 = mskTelefon1.Text;
            veli.VELITEL2 = mskTelefon2.Text;
            veli.VELİMAİL = txtMail.Text;
            db.TBL_VELİLER.Add(veli);
            db.SaveChanges();
            listele();
            temizle();

        }


        private void gridView1_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            txtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            txtAnneAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            txtBabaAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            mskTelefon1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            mskTelefon2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            txtMail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELİMAİL").ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.TBL_VELİLER.Find(id);
            //item.VELIANNE = txtAnneAd.Text;
            //item.VELIBABA = txtBabaAd.Text;
            //item.VELITEL1 = mskTelefon1.Text;
            //item.VELITEL2 = mskTelefon2.Text;
            //item.VELİMAİL = txtMail.Text;
            //db.SaveChanges();
            //listele();
            //temizle();
            using(DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.TBL_VELİLER.FirstOrDefault(x => x.VELIID == id);
                item.VELIANNE = txtAnneAd.Text;
                item.VELIBABA = txtBabaAd.Text;
                item.VELITEL1 = mskTelefon1.Text;
                item.VELITEL2 = mskTelefon2.Text;
                item.VELİMAİL = txtMail.Text;
                db.SaveChanges();
                listele();
                temizle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.TBL_VELİLER.Find(id);
            //db.TBL_VELİLER.Remove(item);
            //db.SaveChanges();
            //listele();
            //temizle();
            using (DbOkulEntities db = new DbOkulEntities())
            {
                var item = db.TBL_VELİLER.First(x => x.VELIID == id);
                db.TBL_VELİLER.Remove(item);
                db.SaveChanges();
                listele();
                temizle();
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
