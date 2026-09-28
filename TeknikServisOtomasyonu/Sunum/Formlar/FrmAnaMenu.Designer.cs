using System;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    partial class FrmAnaMenu
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
            btnMusteriler = new Button();
            btnCihazlar = new Button();
            btnServisKayitlari = new Button();
            lblBaslik = new Label();
            btnPersoneller = new Button();
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(50, 90);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(300, 45);
            btnMusteriler.TabIndex = 1;
            btnMusteriler.Text = "Müşteri Yönetimi";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // btnCihazlar
            // 
            btnCihazlar.Location = new Point(50, 166);
            btnCihazlar.Name = "btnCihazlar";
            btnCihazlar.Size = new Size(300, 45);
            btnCihazlar.TabIndex = 2;
            btnCihazlar.Text = "Cihaz Yönetimi";
            btnCihazlar.UseVisualStyleBackColor = true;
            btnCihazlar.Click += btnCihazlar_Click;
            // 
            // btnServisKayitlari
            // 
            btnServisKayitlari.Location = new Point(50, 318);
            btnServisKayitlari.Name = "btnServisKayitlari";
            btnServisKayitlari.Size = new Size(300, 45);
            btnServisKayitlari.TabIndex = 3;
            btnServisKayitlari.Text = "Arıza / Servis İşlem Takibi";
            btnServisKayitlari.UseVisualStyleBackColor = true;
            btnServisKayitlari.Click += btnServisKayitlari_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.Location = new Point(30, 25);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(340, 40);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Teknik Servis Otomasyonu";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPersoneller
            // 
            btnPersoneller.Location = new Point(50, 242);
            btnPersoneller.Name = "btnPersoneller";
            btnPersoneller.Size = new Size(300, 45);
            btnPersoneller.TabIndex = 4;
            btnPersoneller.Text = "Personel Yönetimi";
            btnPersoneller.UseVisualStyleBackColor = true;
            btnPersoneller.Click += btnPersoneller_Click;
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 418);
            Controls.Add(btnPersoneller);
            Controls.Add(lblBaslik);
            Controls.Add(btnMusteriler);
            Controls.Add(btnCihazlar);
            Controls.Add(btnServisKayitlari);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnCihazlar;
        private System.Windows.Forms.Button btnServisKayitlari;
        private Button btnPersoneller;
    }
}