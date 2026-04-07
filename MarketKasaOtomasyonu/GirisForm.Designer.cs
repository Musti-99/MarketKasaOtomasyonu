namespace MarketKasaOtomasyonu
{
    partial class GirisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnGiris;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            SuspendLayout();
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(30, 35);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(74, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanici Adi";
            txtKullaniciAdi.Location = new Point(140, 32);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(210, 23);
            txtKullaniciAdi.TabIndex = 1;
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(30, 75);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Sifre";
            txtSifre.Location = new Point(140, 72);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(210, 23);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            btnGiris.Location = new Point(140, 113);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(210, 32);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 181);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market POS - Giris";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
