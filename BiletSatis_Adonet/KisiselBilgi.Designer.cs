
namespace BiletSatis_Adonet
{
    partial class KisiselBilgi
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(125, 36);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(124, 20);
            this.txtAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(125, 72);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(124, 20);
            this.txtSoyadi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet:";
            // 
            // txtTCNo
            // 
            this.txtTCNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTCNo.Location = new System.Drawing.Point(125, 146);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(124, 20);
            this.txtTCNo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC No:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(125, 184);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(124, 20);
            this.TxtTelefon.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(147, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(125, 113);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 13;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Koltuk No: ";
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(125, 6);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.ReadOnly = true;
            this.txtKoltukNo.Size = new System.Drawing.Size(124, 20);
            this.txtKoltukNo.TabIndex = 15;
            // 
            // KisiselBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 337);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Name = "KisiselBilgi";
            this.Text = "KisiselBilgi";
            this.Load += new System.EventHandler(this.KisiselBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtKoltukNo;
    }
}