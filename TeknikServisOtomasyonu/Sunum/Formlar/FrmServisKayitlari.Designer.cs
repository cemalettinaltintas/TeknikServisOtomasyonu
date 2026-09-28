using System;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    partial class FrmServisKayitlari
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpServisBilgi = new GroupBox();
            txtYapilanIslem = new TextBox();
            label1 = new Label();
            cmbYeniDurum = new ComboBox();
            lblCihaz = new Label();
            cmbCihazlar = new ComboBox();
            lblPersonel = new Label();
            cmbPersoneller = new ComboBox();
            lblArizaAciklama = new Label();
            txtArizaAciklama = new TextBox();
            label2 = new Label();
            lblUcret = new Label();
            txtUcret = new TextBox();
            btnDurumGuncelle = new Button();
            btnServisKaydet = new Button();
            dgvServisKayitlari = new DataGridView();
            grpServisBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServisKayitlari).BeginInit();
            SuspendLayout();
            // 
            // grpServisBilgi
            // 
            grpServisBilgi.Controls.Add(txtYapilanIslem);
            grpServisBilgi.Controls.Add(label1);
            grpServisBilgi.Controls.Add(cmbYeniDurum);
            grpServisBilgi.Controls.Add(lblCihaz);
            grpServisBilgi.Controls.Add(cmbCihazlar);
            grpServisBilgi.Controls.Add(lblPersonel);
            grpServisBilgi.Controls.Add(cmbPersoneller);
            grpServisBilgi.Controls.Add(lblArizaAciklama);
            grpServisBilgi.Controls.Add(txtArizaAciklama);
            grpServisBilgi.Controls.Add(label2);
            grpServisBilgi.Controls.Add(lblUcret);
            grpServisBilgi.Controls.Add(txtUcret);
            grpServisBilgi.Controls.Add(btnDurumGuncelle);
            grpServisBilgi.Controls.Add(btnServisKaydet);
            grpServisBilgi.Location = new Point(12, 12);
            grpServisBilgi.Name = "grpServisBilgi";
            grpServisBilgi.Size = new Size(320, 546);
            grpServisBilgi.TabIndex = 0;
            grpServisBilgi.TabStop = false;
            grpServisBilgi.Text = "Yeni Servis / Arıza Kaydı";
            // 
            // txtYapilanIslem
            // 
            txtYapilanIslem.Location = new Point(20, 322);
            txtYapilanIslem.Multiline = true;
            txtYapilanIslem.Name = "txtYapilanIslem";
            txtYapilanIslem.Size = new Size(280, 70);
            txtYapilanIslem.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 403);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 7;
            label1.Text = "Yeni Durum:";
            // 
            // cmbYeniDurum
            // 
            cmbYeniDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYeniDurum.FormattingEnabled = true;
            cmbYeniDurum.Items.AddRange(new object[] { "Hazır", "Onarımda", "Kayıt Alındı", "Beklemede" });
            cmbYeniDurum.Location = new Point(20, 421);
            cmbYeniDurum.Name = "cmbYeniDurum";
            cmbYeniDurum.Size = new Size(280, 23);
            cmbYeniDurum.TabIndex = 6;
            // 
            // lblCihaz
            // 
            lblCihaz.AutoSize = true;
            lblCihaz.Location = new Point(20, 30);
            lblCihaz.Name = "lblCihaz";
            lblCihaz.Size = new Size(77, 15);
            lblCihaz.TabIndex = 0;
            lblCihaz.Text = "Cihaz Seçimi:";
            // 
            // cmbCihazlar
            // 
            cmbCihazlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCihazlar.FormattingEnabled = true;
            cmbCihazlar.Location = new Point(20, 50);
            cmbCihazlar.Name = "cmbCihazlar";
            cmbCihazlar.Size = new Size(280, 23);
            cmbCihazlar.TabIndex = 1;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Location = new Point(20, 85);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(103, 15);
            lblPersonel.TabIndex = 2;
            lblPersonel.Text = "İlgilenen Personel:";
            // 
            // cmbPersoneller
            // 
            cmbPersoneller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersoneller.FormattingEnabled = true;
            cmbPersoneller.Location = new Point(20, 105);
            cmbPersoneller.Name = "cmbPersoneller";
            cmbPersoneller.Size = new Size(280, 23);
            cmbPersoneller.TabIndex = 2;
            // 
            // lblArizaAciklama
            // 
            lblArizaAciklama.AutoSize = true;
            lblArizaAciklama.Location = new Point(20, 140);
            lblArizaAciklama.Name = "lblArizaAciklama";
            lblArizaAciklama.Size = new Size(96, 15);
            lblArizaAciklama.TabIndex = 3;
            lblArizaAciklama.Text = "Arıza Açıklaması:";
            // 
            // txtArizaAciklama
            // 
            txtArizaAciklama.Location = new Point(20, 160);
            txtArizaAciklama.Multiline = true;
            txtArizaAciklama.Name = "txtArizaAciklama";
            txtArizaAciklama.Size = new Size(280, 70);
            txtArizaAciklama.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 304);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Yapılan İşlem:";
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Location = new Point(20, 245);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(83, 15);
            lblUcret.TabIndex = 4;
            lblUcret.Text = "Tahmini Ücret:";
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(20, 265);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(280, 23);
            txtUcret.TabIndex = 4;
            txtUcret.Text = "0.00";
            // 
            // btnDurumGuncelle
            // 
            btnDurumGuncelle.Location = new Point(20, 496);
            btnDurumGuncelle.Name = "btnDurumGuncelle";
            btnDurumGuncelle.Size = new Size(280, 40);
            btnDurumGuncelle.TabIndex = 5;
            btnDurumGuncelle.Text = "Durum Güncelle";
            btnDurumGuncelle.UseVisualStyleBackColor = true;
            btnDurumGuncelle.Click += btnDurumGuncelle_Click;
            // 
            // btnServisKaydet
            // 
            btnServisKaydet.Location = new Point(20, 450);
            btnServisKaydet.Name = "btnServisKaydet";
            btnServisKaydet.Size = new Size(280, 40);
            btnServisKaydet.TabIndex = 5;
            btnServisKaydet.Text = "Servis Kaydı Aç";
            btnServisKaydet.UseVisualStyleBackColor = true;
            btnServisKaydet.Click += btnServisKaydet_Click;
            // 
            // dgvServisKayitlari
            // 
            dgvServisKayitlari.AllowUserToAddRows = false;
            dgvServisKayitlari.AllowUserToDeleteRows = false;
            dgvServisKayitlari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServisKayitlari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServisKayitlari.Location = new Point(345, 20);
            dgvServisKayitlari.MultiSelect = false;
            dgvServisKayitlari.Name = "dgvServisKayitlari";
            dgvServisKayitlari.ReadOnly = true;
            dgvServisKayitlari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisKayitlari.Size = new Size(520, 538);
            dgvServisKayitlari.TabIndex = 6;
            dgvServisKayitlari.CellClick += dgvServisKayitlari_CellClick;
            // 
            // FrmServisKayitlari
            // 
            ClientSize = new Size(880, 570);
            Controls.Add(dgvServisKayitlari);
            Controls.Add(grpServisBilgi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmServisKayitlari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teknik Servis İşlem Takip";
            Load += FrmServisKayitlari_Load;
            grpServisBilgi.ResumeLayout(false);
            grpServisBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServisKayitlari).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServisBilgi;
        private System.Windows.Forms.Label lblCihaz;
        private System.Windows.Forms.ComboBox cmbCihazlar;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Label lblArizaAciklama;
        private System.Windows.Forms.TextBox txtArizaAciklama;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button btnServisKaydet;
        private System.Windows.Forms.DataGridView dgvServisKayitlari;
        private ComboBox cmbYeniDurum;
        private Button btnDurumGuncelle;
        private Label label1;
        private TextBox txtYapilanIslem;
        private Label label2;
    }
}