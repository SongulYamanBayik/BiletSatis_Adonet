
namespace BiletSatis_Adonet
{
    partial class OtobusKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbAktif = new System.Windows.Forms.RadioButton();
            this.rdbPasif = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtgOtobus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOtobus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(108, 86);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(126, 20);
            this.txtPlaka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plaka:";
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Location = new System.Drawing.Point(108, 128);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(126, 20);
            this.txtKoltuk.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durum:";
            // 
            // rdbAktif
            // 
            this.rdbAktif.AutoSize = true;
            this.rdbAktif.Location = new System.Drawing.Point(108, 171);
            this.rdbAktif.Name = "rdbAktif";
            this.rdbAktif.Size = new System.Drawing.Size(46, 17);
            this.rdbAktif.TabIndex = 7;
            this.rdbAktif.TabStop = true;
            this.rdbAktif.Text = "Aktif";
            this.rdbAktif.UseVisualStyleBackColor = true;
            // 
            // rdbPasif
            // 
            this.rdbPasif.AutoSize = true;
            this.rdbPasif.Location = new System.Drawing.Point(186, 171);
            this.rdbPasif.Name = "rdbPasif";
            this.rdbPasif.Size = new System.Drawing.Size(48, 17);
            this.rdbPasif.TabIndex = 8;
            this.rdbPasif.TabStop = true;
            this.rdbPasif.Text = "Pasif";
            this.rdbPasif.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(304, 34);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(304, 79);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(304, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(304, 163);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtgOtobus
            // 
            this.dtgOtobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOtobus.Location = new System.Drawing.Point(3, 236);
            this.dtgOtobus.Name = "dtgOtobus";
            this.dtgOtobus.Size = new System.Drawing.Size(422, 202);
            this.dtgOtobus.TabIndex = 13;
            // 
            // OtobusKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.dtgOtobus);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.rdbPasif);
            this.Controls.Add(this.rdbAktif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKoltuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "OtobusKayit";
            this.Text = "OtobusKayit";
            ((System.ComponentModel.ISupportInitialize)(this.dtgOtobus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoltuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbAktif;
        private System.Windows.Forms.RadioButton rdbPasif;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dtgOtobus;
    }
}