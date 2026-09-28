using System;
using System.Windows.Forms;
using TeknikServisOtomasyonu.IsMantigi;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.Varliklar.TeknikServisOtomasyonu.Varliklar;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    public partial class FrmMusteriler : Form
    {
        private MusteriManager musteriManager = new MusteriManager();

        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvMusteriler.DataSource = musteriManager.MusteriListesi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri
            {
                AdSoyad = txtAdSoyad.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Eposta = txtEposta.Text.Trim()
            };

            string mesaj;
            bool basarili = musteriManager.MusteriKaydet(yeniMusteri, out mesaj);

            if (basarili)
            {
                MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormTemizle();
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormTemizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtAdSoyad.Focus();
        }
    }
}