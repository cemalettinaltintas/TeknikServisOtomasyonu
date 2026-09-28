using System;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.ShowDialog();
        }

        private void btnCihazlar_Click(object sender, EventArgs e)
        {
            FrmCihazlar frm = new FrmCihazlar();
            frm.ShowDialog();
        }

        private void btnServisKayitlari_Click(object sender, EventArgs e)
        {
            FrmServisKayitlari frm = new FrmServisKayitlari();
            frm.ShowDialog();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }
    }
}