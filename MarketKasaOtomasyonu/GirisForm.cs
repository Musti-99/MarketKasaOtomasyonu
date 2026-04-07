using System.Data.SqlClient;

namespace MarketKasaOtomasyonu
{
    public partial class GirisForm : Form
    {
        private readonly Veritabani veritabani = new Veritabani();

        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanici adi ve sifre giriniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = veritabani.BaglantiGetir())
            {
                baglanti.Open();

                string sorgu = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi AND Sifre=@sifre";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    int kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        AnaMenuForm anaMenuForm = new AnaMenuForm();
                        Hide();
                        anaMenuForm.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanici adi veya sifre hatali.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSifre.Clear();
                        txtSifre.Focus();
                    }
                }
            }
        }
    }
}
