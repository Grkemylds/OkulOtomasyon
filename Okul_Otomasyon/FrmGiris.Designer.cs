namespace Okul_Otomasyon
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 71);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(671, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ATATÜRK ORTAOKULU GİRİŞ PANELİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kullanıcı:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(113, 21);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(100, 20);
            this.mskTC.TabIndex = 2;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(240, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 25);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(302, 22);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(121, 20);
            this.txtSifre.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.txtSifre);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.mskTC);
            this.panel2.Location = new System.Drawing.Point(12, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 69);
            this.panel2.TabIndex = 5;
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYonetici.BackgroundImage")));
            this.btnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetici.Location = new System.Drawing.Point(40, 464);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(107, 85);
            this.btnYonetici.TabIndex = 6;
            this.btnYonetici.Text = " ";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackgroundImage = global::Okul_Otomasyon.Properties.Resources.images;
            this.btnOgretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgretmen.Location = new System.Drawing.Point(171, 464);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(107, 85);
            this.btnOgretmen.TabIndex = 7;
            this.btnOgretmen.Text = " ";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackgroundImage = global::Okul_Otomasyon.Properties.Resources.images__1_;
            this.btnOgrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenci.Location = new System.Drawing.Point(298, 464);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(107, 85);
            this.btnOgrenci.TabIndex = 8;
            this.btnOgrenci.Text = " ";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnOgrenci;
    }
}