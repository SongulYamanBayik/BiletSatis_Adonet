
namespace BiletSatis_Adonet
{
    partial class frmPersonel
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
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.lblpersonelID = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.lblPersonelTc = new System.Windows.Forms.Label();
            this.txtPersonelTC = new System.Windows.Forms.TextBox();
            this.lblPersonlSoyad = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.lblPersonelCinsiyet = new System.Windows.Forms.Label();
            this.txtPersonelCinsiyet = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblGorevId = new System.Windows.Forms.Label();
            this.lblSehirID = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtgPersonel = new System.Windows.Forms.DataGridView();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(133, 32);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(160, 20);
            this.txtPersonelID.TabIndex = 0;
            // 
            // lblpersonelID
            // 
            this.lblpersonelID.AutoSize = true;
            this.lblpersonelID.Location = new System.Drawing.Point(50, 35);
            this.lblpersonelID.Name = "lblpersonelID";
            this.lblpersonelID.Size = new System.Drawing.Size(63, 13);
            this.lblpersonelID.TabIndex = 1;
            this.lblpersonelID.Text = "Personel Id:";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonelAd.Location = new System.Drawing.Point(44, 81);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(69, 13);
            this.lblPersonelAd.TabIndex = 3;
            this.lblPersonelAd.Text = "Personel Adı:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(133, 78);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(160, 20);
            this.txtPersonelAd.TabIndex = 2;
            // 
            // lblPersonelTc
            // 
            this.lblPersonelTc.AutoSize = true;
            this.lblPersonelTc.Location = new System.Drawing.Point(45, 169);
            this.lblPersonelTc.Name = "lblPersonelTc";
            this.lblPersonelTc.Size = new System.Drawing.Size(68, 13);
            this.lblPersonelTc.TabIndex = 5;
            this.lblPersonelTc.Text = "Personel TC:";
            // 
            // txtPersonelTC
            // 
            this.txtPersonelTC.Location = new System.Drawing.Point(133, 166);
            this.txtPersonelTC.Name = "txtPersonelTC";
            this.txtPersonelTC.Size = new System.Drawing.Size(160, 20);
            this.txtPersonelTC.TabIndex = 4;
            // 
            // lblPersonlSoyad
            // 
            this.lblPersonlSoyad.AutoSize = true;
            this.lblPersonlSoyad.Location = new System.Drawing.Point(27, 127);
            this.lblPersonlSoyad.Name = "lblPersonlSoyad";
            this.lblPersonlSoyad.Size = new System.Drawing.Size(86, 13);
            this.lblPersonlSoyad.TabIndex = 7;
            this.lblPersonlSoyad.Text = "Personel Soyadı:";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(133, 124);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(160, 20);
            this.txtPersonelSoyad.TabIndex = 6;
            // 
            // lblPersonelCinsiyet
            // 
            this.lblPersonelCinsiyet.AutoSize = true;
            this.lblPersonelCinsiyet.Location = new System.Drawing.Point(67, 212);
            this.lblPersonelCinsiyet.Name = "lblPersonelCinsiyet";
            this.lblPersonelCinsiyet.Size = new System.Drawing.Size(46, 13);
            this.lblPersonelCinsiyet.TabIndex = 9;
            this.lblPersonelCinsiyet.Text = "Cinsiyet:";
            // 
            // txtPersonelCinsiyet
            // 
            this.txtPersonelCinsiyet.Location = new System.Drawing.Point(133, 209);
            this.txtPersonelCinsiyet.Name = "txtPersonelCinsiyet";
            this.txtPersonelCinsiyet.Size = new System.Drawing.Size(160, 20);
            this.txtPersonelCinsiyet.TabIndex = 8;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(40, 253);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblDogumTarihi.TabIndex = 11;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(67, 294);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(133, 291);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(160, 20);
            this.txtTelefon.TabIndex = 12;
            // 
            // lblGorevId
            // 
            this.lblGorevId.AutoSize = true;
            this.lblGorevId.Location = new System.Drawing.Point(62, 335);
            this.lblGorevId.Name = "lblGorevId";
            this.lblGorevId.Size = new System.Drawing.Size(51, 13);
            this.lblGorevId.TabIndex = 15;
            this.lblGorevId.Text = "Görev Id:";
            // 
            // lblSehirID
            // 
            this.lblSehirID.AutoSize = true;
            this.lblSehirID.Location = new System.Drawing.Point(67, 377);
            this.lblSehirID.Name = "lblSehirID";
            this.lblSehirID.Size = new System.Drawing.Size(46, 13);
            this.lblSehirID.TabIndex = 17;
            this.lblSehirID.Text = "Şehir Id:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(342, 106);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(111, 30);
            this.btnListele.TabIndex = 18;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(342, 169);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 30);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(342, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 30);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(342, 286);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 30);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dtgPersonel
            // 
            this.dtgPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonel.Location = new System.Drawing.Point(479, 32);
            this.dtgPersonel.Name = "dtgPersonel";
            this.dtgPersonel.Size = new System.Drawing.Size(309, 362);
            this.dtgPersonel.TabIndex = 23;
            // 
            // cmbGorev
            // 
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(133, 332);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(160, 21);
            this.cmbGorev.TabIndex = 24;
            this.cmbGorev.SelectedIndexChanged += new System.EventHandler(this.cmbGorev_SelectedIndexChanged);
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(133, 368);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(160, 21);
            this.cmbSehir.TabIndex = 25;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.dtgPersonel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblSehirID);
            this.Controls.Add(this.lblGorevId);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblPersonelCinsiyet);
            this.Controls.Add(this.txtPersonelCinsiyet);
            this.Controls.Add(this.lblPersonlSoyad);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.lblPersonelTc);
            this.Controls.Add(this.txtPersonelTC);
            this.Controls.Add(this.lblPersonelAd);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.lblpersonelID);
            this.Controls.Add(this.txtPersonelID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPersonel";
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label lblpersonelID;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label lblPersonelTc;
        private System.Windows.Forms.TextBox txtPersonelTC;
        private System.Windows.Forms.Label lblPersonlSoyad;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.Label lblPersonelCinsiyet;
        private System.Windows.Forms.TextBox txtPersonelCinsiyet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblGorevId;
        private System.Windows.Forms.Label lblSehirID;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtgPersonel;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.ComboBox cmbSehir;
    }
}

