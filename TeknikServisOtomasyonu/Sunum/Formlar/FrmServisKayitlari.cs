using System;
using System.Data;
using System.Windows.Forms;
using TeknikServisOtomasyonu.IsMantigi;
using TeknikServisOtomasyonu.Varliklar;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    public partial class FrmServisKayitlari : Form
    {
        private ServisKayitManager servisManager = new ServisKayitManager();
        private CihazManager cihazManager = new CihazManager();
        private PersonelManager personelManager = new PersonelManager();

        public FrmServisKayitlari()
        {
            InitializeComponent();
        }

        private void FrmServisKayitlari_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
            ListeyiYenile();
        }

        private void ComboboxlariDoldur()
        {
            // Cihazları Doldur
            DataTable dtCihazlar = cihazManager.CihazListesi();
            if (dtCihazlar != null)
            {
                cmbCihazlar.DataSource = dtCihazlar;
                cmbCihazlar.DisplayMember = "MarkaModel"; // İhtiyaca göre "SeriNo" veya başka bir alan yapılabilir
                cmbCihazlar.ValueMember = "CihazID";
                cmbCihazlar.SelectedIndex = -1;
            }

            // Personelleri Doldur
            DataTable dtPersonel = personelManager.PersonelListesi();
            if (dtPersonel != null)
            {
                cmbPersoneller.DataSource = dtPersonel;
                cmbPersoneller.DisplayMember = "AdSoyad";
                cmbPersoneller.ValueMember = "PersonelID";
                cmbPersoneller.SelectedIndex = -1;
            }
        }

        private void ListeyiYenile()
        {
            dgvServisKayitlari.DataSource = servisManager.ServisKayitListesi();
        }

        private void btnServisKaydet_Click(object sender, EventArgs e)
        {
            if (cmbCihazlar.SelectedValue == null || cmbPersoneller.SelectedValue == null)
            {
                MessageBox.Show("Lütfen cihaz ve sorumlu personel seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal ucret = 0;
            decimal.TryParse(txtUcret.Text.Trim(), out ucret);

            ServisKayit yeniKayit = new ServisKayit
            {
                CihazID = Convert.ToInt32(cmbCihazlar.SelectedValue),
                PersonelID = Convert.ToInt32(cmbPersoneller.SelectedValue),
                ArizaTanimi = txtArizaAciklama.Text.Trim(),
                Ucret = ucret,
                Durum = "Kayıt Açıldı"
            };

            string mesaj;
            bool basarili = servisManager.ServisKaydiAc(yeniKayit, out mesaj);

            if (basarili)
            {
                MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormTemizle();
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTemizle()
        {
            cmbCihazlar.SelectedIndex = -1;
            cmbPersoneller.SelectedIndex = -1;
            txtArizaAciklama.Clear();
            txtUcret.Text = "0.00";
            cmbCihazlar.Focus();
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvServisKayitlari.SelectedRows.Count > 0)
            {
                // 1. Nesne oluştur ve formdaki elemanlardan verileri doldur
                ServisKayit s = new ServisKayit();
                s.KayitID = Convert.ToInt32(dgvServisKayitlari.SelectedRows[0].Cells["KayitID"].Value);

                // ComboBox veya Lookup alanlarından ID'leri aldığınızı varsayıyoruz
                s.CihazID = Convert.ToInt32(cmbCihazlar.SelectedValue);
                s.PersonelID = Convert.ToInt32(cmbPersoneller.SelectedValue);

                s.ArizaTanimi = txtArizaAciklama.Text.Trim();

                s.YapilanIslem = txtYapilanIslem.Text.Trim();
                s.Ucret = Convert.ToDecimal(txtUcret.Text); // veya numericUpDownUcret.Value
                s.Durum = cmbYeniDurum.SelectedItem?.ToString();

                // 2. Manager sınıfı üzerinden güncelle
                string mesaj;
                bool sonuc = servisManager.ServisDurumGuncelle(s.KayitID, s.YapilanIslem, s.Ucret, s.Durum, out mesaj);

                MessageBox.Show(mesaj);

                if (sonuc)
                {
                    ListeyiYenile(); // Listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir servis kaydı seçin!");
            }
        }

        private void dgvServisKayitlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Başlık satırına tıklanırsa çık
            cmbCihazlar.SelectedValue = dgvServisKayitlari.SelectedRows[0].Cells["KayitID"].Value;


            // Personel bilgileri için
            var teknisyenName = dgvServisKayitlari.SelectedRows[0].Cells["Teknisyen"].Value?.ToString();
            if (!string.IsNullOrEmpty(teknisyenName))
            {
                cmbPersoneller.SelectedIndex = cmbPersoneller.FindStringExact(teknisyenName);
            }
            else
            {
                cmbPersoneller.SelectedIndex = -1;
            }

            // Metin ve sayısal alanlar
            txtArizaAciklama.Text = dgvServisKayitlari.SelectedRows[0].Cells["ArizaTanimi"].Value.ToString();
            txtUcret.Text = dgvServisKayitlari.SelectedRows[0].Cells["Ucret"].Value.ToString();

            txtYapilanIslem.Text = dgvServisKayitlari.SelectedRows[0].Cells["YapilanIslem"].Value?.ToString() ?? string.Empty;

            // Durum ComboBox'ı veya TextBox'ı
            if (dgvServisKayitlari.SelectedRows[0].Cells["Durum"].Value != null)
            {
                cmbYeniDurum.SelectedItem = dgvServisKayitlari.SelectedRows[0].Cells["Durum"].Value.ToString();
            }
        }
    }
}