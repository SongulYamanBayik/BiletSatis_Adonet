
namespace BiletSatis_Adonet
{
    partial class Cinsiyet
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
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(66, 30);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 0;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedValueChanged);
            this.cmbCinsiyet.SelectedValueChanged += new System.EventHandler(this.cmbCinsiyet_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cinsiyet";
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(90, 66);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(75, 23);
            this.btnDevam.TabIndex = 2;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // Cinsiyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 114);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCinsiyet);
            this.Name = "Cinsiyet";
            this.Text = "Cinsiyet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevam;
    }
}