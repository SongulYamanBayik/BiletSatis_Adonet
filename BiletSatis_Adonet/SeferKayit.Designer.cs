
using System;

namespace BiletSatis_Adonet
{
    partial class SeferKayit
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
            this.cmbGuzergah = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtKalkisSaat = new System.Windows.Forms.TextBox();
            this.txtVarisSaat = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgSeferler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.FormattingEnabled = true;
            this.cmbGuzergah.Location = new System.Drawing.Point(118, 81);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Size = new System.Drawing.Size(108, 21);
            this.cmbGuzergah.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Güzergah Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Otobüs:";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Location = new System.Drawing.Point(118, 120);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(108, 21);
            this.cmbOtobus.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtKalkisSaat
            // 
            this.txtKalkisSaat.Location = new System.Drawing.Point(118, 203);
            this.txtKalkisSaat.Name = "txtKalkisSaat";
            this.txtKalkisSaat.Size = new System.Drawing.Size(108, 20);
            this.txtKalkisSaat.TabIndex = 5;
            // 
            // txtVarisSaat
            // 
            this.txtVarisSaat.Location = new System.Drawing.Point(118, 288);
            this.txtVarisSaat.Name = "txtVarisSaat";
            this.txtVarisSaat.Size = new System.Drawing.Size(108, 20);
            this.txtVarisSaat.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 245);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(118, 330);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(108, 20);
            this.txtUcret.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kalkış Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kalkış Saat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Varış Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Varış Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ücret:";
            // 
            // dtgSeferler
            // 
            this.dtgSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSeferler.Location = new System.Drawing.Point(407, 12);
            this.dtgSeferler.Name = "dtgSeferler";
            this.dtgSeferler.Size = new System.Drawing.Size(381, 426);
            this.dtgSeferler.TabIndex = 14;
            this.dtgSeferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSeferler_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(278, 98);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(278, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(278, 217);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(278, 274);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 19;
            // 
            // SeferKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtgSeferler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtVarisSaat);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtKalkisSaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGuzergah);
            this.Name = "SeferKayit";
            this.Text = "SeferKayit";
            this.Load += new System.EventHandler(this.SeferKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGuzergah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtKalkisSaat;
        private System.Windows.Forms.TextBox txtVarisSaat;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgSeferler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
    }
}