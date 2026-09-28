using System.Windows.Forms;
using System.Drawing;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    partial class FrmPersonel
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpPersonelBilgi;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label lblUzmanlik;
        private TextBox txtUzmanlik;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dgvPersoneller;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpPersonelBilgi = new GroupBox();
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            lblUzmanlik = new Label();
            txtUzmanlik = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvPersoneller = new DataGridView();
            txtPersonelID = new TextBox();
            grpPersonelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            SuspendLayout();
            // 
            // grpPersonelBilgi
            // 
            grpPersonelBilgi.Controls.Add(lblAdSoyad);
            grpPersonelBilgi.Controls.Add(txtAdSoyad);
            grpPersonelBilgi.Controls.Add(lblUzmanlik);
            grpPersonelBilgi.Controls.Add(txtUzmanlik);
            grpPersonelBilgi.Controls.Add(btnEkle);
            grpPersonelBilgi.Controls.Add(btnGuncelle);
            grpPersonelBilgi.Controls.Add(btnSil);
            grpPersonelBilgi.Controls.Add(btnTemizle);
            grpPersonelBilgi.Location = new Point(12, 12);
            grpPersonelBilgi.Name = "grpPersonelBilgi";
            grpPersonelBilgi.Size = new Size(320, 200);
            grpPersonelBilgi.TabIndex = 0;
            grpPersonelBilgi.TabStop = false;
            grpPersonelBilgi.Text = "Personel Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(12, 28);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(60, 15);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 48);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(290, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblUzmanlik
            // 
            lblUzmanlik.AutoSize = true;
            lblUzmanlik.Location = new Point(12, 78);
            lblUzmanlik.Name = "lblUzmanlik";
            lblUzmanlik.Size = new Size(89, 15);
            lblUzmanlik.TabIndex = 2;
            lblUzmanlik.Text = "Uzmanlık Alanı:";
            // 
            // txtUzmanlik
            // 
            txtUzmanlik.Location = new Point(12, 98);
            txtUzmanlik.Name = "txtUzmanlik";
            txtUzmanlik.Size = new Size(290, 23);
            txtUzmanlik.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 130);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(68, 30);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.Click += BtnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(86, 130);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(80, 30);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += BtnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(172, 130);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(62, 30);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.Click += BtnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(240, 130);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(62, 30);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += BtnTemizle_Click;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.Location = new Point(340, 12);
            dgvPersoneller.MultiSelect = false;
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(520, 360);
            dgvPersoneller.TabIndex = 1;
            dgvPersoneller.CellClick += DgvPersoneller_CellClick;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(24, 251);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(100, 23);
            txtPersonelID.TabIndex = 2;
            txtPersonelID.Visible = false;
            // 
            // FrmPersonel
            // 
            ClientSize = new Size(880, 400);
            Controls.Add(txtPersonelID);
            Controls.Add(grpPersonelBilgi);
            Controls.Add(dgvPersoneller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPersonel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Yönetimi";
            Load += FrmPersonel_Load;
            grpPersonelBilgi.ResumeLayout(false);
            grpPersonelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtPersonelID;
    }
}