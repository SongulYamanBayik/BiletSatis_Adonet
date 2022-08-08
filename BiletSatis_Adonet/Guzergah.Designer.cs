
namespace BiletSatis_Adonet
{
    partial class Guzergah
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
            this.txtGuzergah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBitisSehir = new System.Windows.Forms.ComboBox();
            this.cmbBaslangicSehir = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güzergah Adı:";
            // 
            // txtGuzergah
            // 
            this.txtGuzergah.Location = new System.Drawing.Point(120, 23);
            this.txtGuzergah.Name = "txtGuzergah";
            this.txtGuzergah.Size = new System.Drawing.Size(124, 20);
            this.txtGuzergah.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Şehri:";
            // 
            // cmbBitisSehir
            // 
            this.cmbBitisSehir.FormattingEnabled = true;
            this.cmbBitisSehir.Location = new System.Drawing.Point(120, 99);
            this.cmbBitisSehir.Name = "cmbBitisSehir";
            this.cmbBitisSehir.Size = new System.Drawing.Size(124, 21);
            this.cmbBitisSehir.TabIndex = 3;
            // 
            // cmbBaslangicSehir
            // 
            this.cmbBaslangicSehir.FormattingEnabled = true;
            this.cmbBaslangicSehir.Location = new System.Drawing.Point(120, 61);
            this.cmbBaslangicSehir.Name = "cmbBaslangicSehir";
            this.cmbBaslangicSehir.Size = new System.Drawing.Size(124, 21);
            this.cmbBaslangicSehir.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bitiş Şehri:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yeni Ara Durak ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(303, 378);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(134, 32);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Guzergah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBaslangicSehir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBitisSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuzergah);
            this.Controls.Add(this.label1);
            this.Name = "Guzergah";
            this.Text = "Guzergah";
            this.Load += new System.EventHandler(this.Guzergah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuzergah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBitisSehir;
        private System.Windows.Forms.ComboBox cmbBaslangicSehir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEkle;
    }
}