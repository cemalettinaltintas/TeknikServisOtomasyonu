using System;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Sunum.Formlar
{
    partial class FrmCihazlar
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
            this.grpCihazBilgi = new System.Windows.Forms.GroupBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.lblCihazTuru = new System.Windows.Forms.Label();
            this.cmbCihazTurleri = new System.Windows.Forms.ComboBox();
            this.lblMarkaModel = new System.Windows.Forms.Label();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.btnCihazEkle = new System.Windows.Forms.Button();
            this.dgvCihazlar = new System.Windows.Forms.DataGridView();
            this.grpCihazBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCihazlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCihazBilgi
            // 
            this.grpCihazBilgi.Controls.Add(this.lblMusteri);
            this.grpCihazBilgi.Controls.Add(this.cmbMusteriler);
            this.grpCihazBilgi.Controls.Add(this.lblCihazTuru);
            this.grpCihazBilgi.Controls.Add(this.cmbCihazTurleri);
            this.grpCihazBilgi.Controls.Add(this.lblMarkaModel);
            this.grpCihazBilgi.Controls.Add(this.txtMarkaModel);
            this.grpCihazBilgi.Controls.Add(this.lblSeriNo);
            this.grpCihazBilgi.Controls.Add(this.txtSeriNo);
            this.grpCihazBilgi.Controls.Add(this.btnCihazEkle);
            this.grpCihazBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpCihazBilgi.Name = "grpCihazBilgi";
            this.grpCihazBilgi.Size = new System.Drawing.Size(320, 390);
            this.grpCihazBilgi.TabIndex = 0;
            this.grpCihazBilgi.TabStop = false;
            this.grpCihazBilgi.Text = "Yeni Cihaz Kaydı";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(20, 35);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(50, 15);
            this.lblMusteri.Text = "Müşteri:";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(20, 55);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(280, 23);
            this.cmbMusteriler.TabIndex = 1;
            // 
            // lblCihazTuru
            // 
            this.lblCihazTuru.AutoSize = true;
            this.lblCihazTuru.Location = new System.Drawing.Point(20, 95);
            this.lblCihazTuru.Name = "lblCihazTuru";
            this.lblCihazTuru.Size = new System.Drawing.Size(65, 15);
            this.lblCihazTuru.Text = "Cihaz Türü:";
            // 
            // cmbCihazTurleri
            // 
            this.cmbCihazTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCihazTurleri.FormattingEnabled = true;
            this.cmbCihazTurleri.Location = new System.Drawing.Point(20, 115);
            this.cmbCihazTurleri.Name = "cmbCihazTurleri";
            this.cmbCihazTurleri.Size = new System.Drawing.Size(280, 23);
            this.cmbCihazTurleri.TabIndex = 2;
            // 
            // lblMarkaModel
            // 
            this.lblMarkaModel.AutoSize = true;
            this.lblMarkaModel.Location = new System.Drawing.Point(20, 155);
            this.lblMarkaModel.Name = "lblMarkaModel";
            this.lblMarkaModel.Size = new System.Drawing.Size(82, 15);
            this.lblMarkaModel.Text = "Marka/Model:";
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(20, 175);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(280, 23);
            this.txtMarkaModel.TabIndex = 3;
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.Location = new System.Drawing.Point(20, 215);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(48, 15);
            this.lblSeriNo.Text = "Seri No:";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(20, 235);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(280, 23);
            this.txtSeriNo.TabIndex = 4;
            // 
            // btnCihazEkle
            // 
            this.btnCihazEkle.Location = new System.Drawing.Point(20, 280);
            this.btnCihazEkle.Name = "btnCihazEkle";
            this.btnCihazEkle.Size = new System.Drawing.Size(280, 40);
            this.btnCihazEkle.TabIndex = 5;
            this.btnCihazEkle.Text = "Cihazı Ekle";
            this.btnCihazEkle.UseVisualStyleBackColor = true;
            this.btnCihazEkle.Click += new System.EventHandler(this.btnCihazEkle_Click);
            // 
            // dgvCihazlar
            // 
            this.dgvCihazlar.AllowUserToAddRows = false;
            this.dgvCihazlar.AllowUserToDeleteRows = false;
            this.dgvCihazlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCihazlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCihazlar.Location = new System.Drawing.Point(345, 20);
            this.dgvCihazlar.MultiSelect = false;
            this.dgvCihazlar.Name = "dgvCihazlar";
            this.dgvCihazlar.ReadOnly = true;
            this.dgvCihazlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCihazlar.Size = new System.Drawing.Size(520, 382);
            this.dgvCihazlar.TabIndex = 6;
            // 
            // FrmCihazlar
            // 
            this.ClientSize = new System.Drawing.Size(880, 415);
            this.Controls.Add(this.dgvCihazlar);
            this.Controls.Add(this.grpCihazBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCihazlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz Yönetimi";
            this.Load += new System.EventHandler(this.FrmCihazlar_Load);
            this.grpCihazBilgi.ResumeLayout(false);
            this.grpCihazBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCihazlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCihazBilgi;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Label lblCihazTuru;
        private System.Windows.Forms.ComboBox cmbCihazTurleri;
        private System.Windows.Forms.Label lblMarkaModel;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Button btnCihazEkle;
        private System.Windows.Forms.DataGridView dgvCihazlar;
    }
}