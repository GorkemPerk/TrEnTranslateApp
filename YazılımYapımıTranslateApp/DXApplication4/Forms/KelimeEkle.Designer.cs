namespace DXApplication4
{
    partial class KelimeEkle
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
            this.txt_TrKelime = new DevExpress.XtraEditors.TextEdit();
            this.txt_IngKelime = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Turkce = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Ingilizce = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Kelimeler = new System.Windows.Forms.DataGridView();
            this.btn_KelimeEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TrKelime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IngKelime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Kelimeler)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TrKelime
            // 
            this.txt_TrKelime.Location = new System.Drawing.Point(42, 61);
            this.txt_TrKelime.Name = "txt_TrKelime";
            this.txt_TrKelime.Size = new System.Drawing.Size(163, 20);
            this.txt_TrKelime.TabIndex = 0;
            // 
            // txt_IngKelime
            // 
            this.txt_IngKelime.Location = new System.Drawing.Point(269, 61);
            this.txt_IngKelime.Name = "txt_IngKelime";
            this.txt_IngKelime.Size = new System.Drawing.Size(163, 20);
            this.txt_IngKelime.TabIndex = 1;
            // 
            // lbl_Turkce
            // 
            this.lbl_Turkce.Location = new System.Drawing.Point(42, 30);
            this.lbl_Turkce.Name = "lbl_Turkce";
            this.lbl_Turkce.Size = new System.Drawing.Size(65, 13);
            this.lbl_Turkce.TabIndex = 3;
            this.lbl_Turkce.Text = "Türkçe Kelime";
            // 
            // lbl_Ingilizce
            // 
            this.lbl_Ingilizce.Location = new System.Drawing.Point(278, 30);
            this.lbl_Ingilizce.Name = "lbl_Ingilizce";
            this.lbl_Ingilizce.Size = new System.Drawing.Size(71, 13);
            this.lbl_Ingilizce.TabIndex = 4;
            this.lbl_Ingilizce.Text = "İngilizce Kelime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // dt_Kelimeler
            // 
            this.dt_Kelimeler.AllowUserToAddRows = false;
            this.dt_Kelimeler.AllowUserToDeleteRows = false;
            this.dt_Kelimeler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_Kelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Kelimeler.Location = new System.Drawing.Point(42, 137);
            this.dt_Kelimeler.Name = "dt_Kelimeler";
            this.dt_Kelimeler.ReadOnly = true;
            this.dt_Kelimeler.Size = new System.Drawing.Size(201, 157);
            this.dt_Kelimeler.TabIndex = 9;
            // 
            // btn_KelimeEkle
            // 
            this.btn_KelimeEkle.Location = new System.Drawing.Point(278, 188);
            this.btn_KelimeEkle.Name = "btn_KelimeEkle";
            this.btn_KelimeEkle.Size = new System.Drawing.Size(137, 47);
            this.btn_KelimeEkle.TabIndex = 10;
            this.btn_KelimeEkle.Text = "Kelime Ekle";
            this.btn_KelimeEkle.Click += new System.EventHandler(this.btn_KelimeEkle_Click);
            // 
            // KelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 364);
            this.Controls.Add(this.btn_KelimeEkle);
            this.Controls.Add(this.dt_Kelimeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Ingilizce);
            this.Controls.Add(this.lbl_Turkce);
            this.Controls.Add(this.txt_IngKelime);
            this.Controls.Add(this.txt_TrKelime);
            this.Name = "KelimeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KelimeEkle";
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TrKelime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IngKelime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Kelimeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TrKelime;
        private DevExpress.XtraEditors.TextEdit txt_IngKelime;
        private DevExpress.XtraEditors.LabelControl lbl_Turkce;
        private DevExpress.XtraEditors.LabelControl lbl_Ingilizce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_Kelimeler;
        private DevExpress.XtraEditors.SimpleButton btn_KelimeEkle;
    }
}