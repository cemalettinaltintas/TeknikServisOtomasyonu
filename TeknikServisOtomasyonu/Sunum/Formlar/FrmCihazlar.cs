using System;
using System.Data;
using System.Windows.Forms;
using TeknikServisOtomasyonu.IsMantigi;
using TeknikServisOtomasyonu.Varliklar;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    public partial class FrmCihazlar : Form
    {
        private CihazManager cihazManager = new CihazManager();
        private MusteriManager musteriManager = new MusteriManager();

        public FrmCihazlar()
        {
            InitializeComponent();
        }

        private void FrmCihazlar_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            ListeyiYenile();
        }

        private void ComboDoldur()
        {
            // Müşterileri Doldur
            DataTable dtMusteriler = musteriManager.MusteriListesi();
            if (dtMusteriler != null)
            {
                cmbMusteriler.DataSource = dtMusteriler;
                cmbMusteriler.DisplayMember = "AdSoyad";
                cmbMusteriler.ValueMember = "MusteriID";
                cmbMusteriler.SelectedIndex = -1;
            }

            // Cihaz Türlerini Doldur
            DataTable dtTurler = cihazManager.CihazTurListesi();
            if (dtTurler != null)
            {
                cmbCihazTurleri.DataSource = dtTurler;
                cmbCihazTurleri.DisplayMember = "TurAdi";
                cmbCihazTurleri.ValueMember = "TurID";
                cmbCihazTurleri.SelectedIndex = -1;
            }
        }

        private void ListeyiYenile()
        {
            dgvCihazlar.DataSource = cihazManager.CihazListesi();
        }

        private void btnCihazEkle_Click(object sender, EventArgs e)
        {
            Cihaz yeniCihaz = new Cihaz
            {
                MusteriID = cmbMusteriler.SelectedValue != null ? Convert.ToInt32(cmbMusteriler.SelectedValue) : 0,
                TurID = cmbCihazTurleri.SelectedValue != null ? Convert.ToInt32(cmbCihazTurleri.SelectedValue) : 0,
                MarkaModel = txtMarkaModel.Text.Trim(),
                SeriNo = txtSeriNo.Text.Trim()
            };

            string mesaj;
            bool basarili = cihazManager.CihazKaydet(yeniCihaz, out mesaj);

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
            cmbMusteriler.SelectedIndex = -1;
            cmbCihazTurleri.SelectedIndex = -1;
            txtMarkaModel.Clear();
            txtSeriNo.Clear();
            cmbMusteriler.Focus();
        }
    }
}