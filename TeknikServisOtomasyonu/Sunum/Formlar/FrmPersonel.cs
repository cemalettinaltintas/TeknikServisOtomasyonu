// File: TeknikServisOtomasyonu\Sunum\Formlar\FrmPersonel.cs
using System;
using System.Data;
using System.Windows.Forms;
using TeknikServisOtomasyonu.Varliklar;
// Assume you have a manager class at TeknikServisOtomasyonu.Business
using TeknikServisOtomasyonu.IsMantigi;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    public partial class FrmPersonel : Form
    {
        private PersonelManager personelManager = new PersonelManager();

        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            FormTemizle();
        }

        private void ListeyiYenile()
        {
            var dt = personelManager.PersonelListesi(); // DataTable bekleniyor: PersonelID, AdSoyad, UzmanlikAlani
            dgvPersoneller.DataSource = dt;
            // Gizli id sütunu varsa gizle
            if (dgvPersoneller.Columns.Contains("PersonelID"))
                dgvPersoneller.Columns["PersonelID"].Visible = false;
        }

        private void FormTemizle()
        {
            txtPersonelID.Text = string.Empty;
            txtAdSoyad.Clear();
            txtUzmanlik.Clear();
            txtAdSoyad.Focus();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Personel adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = new Personel
            {
                AdSoyad = txtAdSoyad.Text.Trim(),
                UzmanlikAlani = txtUzmanlik.Text.Trim()
            };

            string mesaj;
            bool basarili = personelManager.PersonelKaydet(p, out mesaj);
            MessageBox.Show(mesaj);
            if (basarili) { ListeyiYenile(); FormTemizle(); }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonelID.Text))
            {
                MessageBox.Show("Güncelleme için önce listeden bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = new Personel
            {
                PersonelID = Convert.ToInt32(txtPersonelID.Text),
                AdSoyad = txtAdSoyad.Text.Trim(),
                UzmanlikAlani = txtUzmanlik.Text.Trim()
            };

            string mesaj;
            bool basarili = personelManager.PersonelGuncelle(p, out mesaj);
            MessageBox.Show(mesaj);
            if (basarili) { ListeyiYenile(); FormTemizle(); }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonelID.Text))
            {
                MessageBox.Show("Silmek için önce listeden bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;



            ListeyiYenile(); FormTemizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void DgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPersoneller.SelectedRows.Count > 0 ? dgvPersoneller.SelectedRows[0] : dgvPersoneller.Rows[e.RowIndex];
            // Beklenen kolunlar: PersonelID, AdSoyad, UzmanlikAlani
            if (row.Cells["PersonelID"].Value != null)
                txtPersonelID.Text = row.Cells["PersonelID"].Value.ToString();
            else
                txtPersonelID.Text = string.Empty;

            txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString() ?? string.Empty;
            txtUzmanlik.Text = row.Cells["UzmanlikAlani"].Value?.ToString() ?? string.Empty;
        }
    }
}