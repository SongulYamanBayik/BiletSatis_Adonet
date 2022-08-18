
namespace BiletSatis_Adonet
{
    partial class Navigation
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnGuzergah = new System.Windows.Forms.Button();
            this.btnSefer = new System.Windows.Forms.Button();
            this.btnOtobuss = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatilan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnPersonel.Location = new System.Drawing.Point(38, 44);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(127, 97);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel Kayıt";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnGuzergah
            // 
            this.btnGuzergah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(153)))), ((int)(((byte)(5)))));
            this.btnGuzergah.Location = new System.Drawing.Point(171, 44);
            this.btnGuzergah.Name = "btnGuzergah";
            this.btnGuzergah.Size = new System.Drawing.Size(127, 97);
            this.btnGuzergah.TabIndex = 1;
            this.btnGuzergah.Text = "Güzergah Kayıt";
            this.btnGuzergah.UseVisualStyleBackColor = false;
            this.btnGuzergah.Click += new System.EventHandler(this.btnGuzergah_Click);
            // 
            // btnSefer
            // 
            this.btnSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(177)))), ((int)(((byte)(54)))));
            this.btnSefer.Location = new System.Drawing.Point(38, 147);
            this.btnSefer.Name = "btnSefer";
            this.btnSefer.Size = new System.Drawing.Size(127, 94);
            this.btnSefer.TabIndex = 2;
            this.btnSefer.Text = "Sefer Oluştur";
            this.btnSefer.UseVisualStyleBackColor = false;
            this.btnSefer.Click += new System.EventHandler(this.btnSefer_Click);
            // 
            // btnOtobuss
            // 
            this.btnOtobuss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(17)))), ((int)(((byte)(112)))));
            this.btnOtobuss.Location = new System.Drawing.Point(171, 147);
            this.btnOtobuss.Name = "btnOtobuss";
            this.btnOtobuss.Size = new System.Drawing.Size(127, 94);
            this.btnOtobuss.TabIndex = 3;
            this.btnOtobuss.Text = "Otobüs Kayıt";
            this.btnOtobuss.UseVisualStyleBackColor = false;
            this.btnOtobuss.Click += new System.EventHandler(this.btnOtobuss_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(151)))), ((int)(((byte)(139)))));
            this.btnCikis.Location = new System.Drawing.Point(171, 247);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(127, 94);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatilan
            // 
            this.btnSatilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.btnSatilan.Location = new System.Drawing.Point(38, 247);
            this.btnSatilan.Name = "btnSatilan";
            this.btnSatilan.Size = new System.Drawing.Size(127, 94);
            this.btnSatilan.TabIndex = 4;
            this.btnSatilan.Text = "Satılan Biletler";
            this.btnSatilan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSatilan);
            this.Controls.Add(this.btnOtobuss);
            this.Controls.Add(this.btnSefer);
            this.Controls.Add(this.btnGuzergah);
            this.Controls.Add(this.btnPersonel);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnGuzergah;
        private System.Windows.Forms.Button btnSefer;
        private System.Windows.Forms.Button btnOtobuss;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSatilan;
        private System.Windows.Forms.Label label1;
    }
}