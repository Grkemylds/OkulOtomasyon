namespace Okul_Otomasyon
{
    partial class frmOgretmenler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pcrResim = new System.Windows.Forms.PictureBox();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnResim = new DevExpress.XtraEditors.SimpleButton();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1046, 558);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1042, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(300, 558);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.boresume_32x32;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(298, 514);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pcrResim);
            this.groupControl1.Controls.Add(this.cmbBrans);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.mskTelefon);
            this.groupControl1.Controls.Add(this.mskTc);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(295, 601);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // pcrResim
            // 
            this.pcrResim.Location = new System.Drawing.Point(177, 37);
            this.pcrResim.Name = "pcrResim";
            this.pcrResim.Size = new System.Drawing.Size(100, 92);
            this.pcrResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrResim.TabIndex = 2;
            this.pcrResim.TabStop = false;
            this.pcrResim.Click += new System.EventHandler(this.pcrResim_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(105, 358);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.Properties.Appearance.Options.UseFont = true;
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Size = new System.Drawing.Size(172, 24);
            this.cmbBrans.TabIndex = 11;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(105, 328);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbilce.Properties.Appearance.Options.UseFont = true;
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(172, 24);
            this.cmbilce.TabIndex = 11;
            this.cmbilce.SelectedIndexChanged += new System.EventHandler(this.cmbilce_SelectedIndexChanged);
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(105, 298);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.Properties.Appearance.Options.UseFont = true;
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(172, 24);
            this.cmbil.TabIndex = 11;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(105, 266);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(172, 26);
            this.mskTelefon.TabIndex = 10;
            this.mskTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefon_MaskInputRejected);
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(105, 234);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(172, 26);
            this.mskTc.TabIndex = 10;
            this.mskTc.ValidatingType = typeof(int);
            this.mskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTc_MaskInputRejected);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(105, 204);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(172, 24);
            this.txtSoyad.TabIndex = 9;
            this.txtSoyad.EditValueChanged += new System.EventHandler(this.txtSoyad_EditValueChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 174);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(172, 24);
            this.txtAd.TabIndex = 9;
            this.txtAd.EditValueChanged += new System.EventHandler(this.txtAd_EditValueChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(105, 144);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(172, 24);
            this.txtID.TabIndex = 9;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(65, 364);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 18);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Branş:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(71, 331);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 18);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "İlçe:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(83, 293);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 18);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "İl:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Telefon:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(65, 233);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 18);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "T.C.:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 204);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Soyad:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 150);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.geopoint_32x32;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(298, 514);
            this.xtraTabPage2.Text = "Öğretmen Bilgi-2";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTemizle);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Controls.Add(this.btnResim);
            this.groupControl2.Controls.Add(this.rchAdres);
            this.groupControl2.Controls.Add(this.txtMail);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Location = new System.Drawing.Point(2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(297, 600);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // btnResim
            // 
            this.btnResim.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.picturebox_32x32;
            this.btnResim.Location = new System.Drawing.Point(102, 191);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(144, 32);
            this.btnResim.TabIndex = 13;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(74, 89);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(172, 96);
            this.rchAdres.TabIndex = 12;
            this.rchAdres.Text = "";
            this.rchAdres.TextChanged += new System.EventHandler(this.rchAdres_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(26, 89);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 18);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Adres:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.refresh2_32x32;
            this.btnTemizle.Location = new System.Drawing.Point(102, 343);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(144, 32);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.clear_32x32;
            this.btnSil.Location = new System.Drawing.Point(102, 267);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 32);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.saveall_32x32;
            this.btnKaydet.Location = new System.Drawing.Point(102, 229);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 32);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(74, 43);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(172, 24);
            this.txtMail.TabIndex = 11;
            this.txtMail.EditValueChanged += new System.EventHandler(this.txtMail_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(39, 49);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 18);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Mail:";
            this.labelControl10.Click += new System.EventHandler(this.labelControl10_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = global::Okul_Otomasyon.Properties.Resources.updatetableofcontents_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(102, 305);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 32);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmOgretmenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgretmenler";
            this.Load += new System.EventHandler(this.frmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.RichTextBox rchAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnResim;
        private System.Windows.Forms.PictureBox pcrResim;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}