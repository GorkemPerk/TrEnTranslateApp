namespace DXApplication4
{
    partial class Ceviri
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
            this.txt_Kelime = new DevExpress.XtraEditors.TextEdit();
            this.btn_TrIngCeviri = new DevExpress.XtraEditors.SimpleButton();
            this.dt_Ceviri = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_IngTrCeviri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kelime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Ceviri)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Kelime
            // 
            this.txt_Kelime.Location = new System.Drawing.Point(81, 66);
            this.txt_Kelime.Name = "txt_Kelime";
            this.txt_Kelime.Size = new System.Drawing.Size(192, 20);
            this.txt_Kelime.TabIndex = 0;
            // 
            // btn_TrIngCeviri
            // 
            this.btn_TrIngCeviri.Location = new System.Drawing.Point(81, 101);
            this.btn_TrIngCeviri.Name = "btn_TrIngCeviri";
            this.btn_TrIngCeviri.Size = new System.Drawing.Size(371, 65);
            this.btn_TrIngCeviri.TabIndex = 2;
            this.btn_TrIngCeviri.Text = "Türkçe\'den İngilizceye Ceviri";
            this.btn_TrIngCeviri.Click += new System.EventHandler(this.btn_TrIngCeviri_Click);
            // 
            // dt_Ceviri
            // 
            this.dt_Ceviri.AllowUserToAddRows = false;
            this.dt_Ceviri.AllowUserToDeleteRows = false;
            this.dt_Ceviri.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dt_Ceviri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Ceviri.ColumnHeadersVisible = false;
            this.dt_Ceviri.GridColor = System.Drawing.SystemColors.Highlight;
            this.dt_Ceviri.Location = new System.Drawing.Point(279, 66);
            this.dt_Ceviri.Name = "dt_Ceviri";
            this.dt_Ceviri.ReadOnly = true;
            this.dt_Ceviri.Size = new System.Drawing.Size(173, 20);
            this.dt_Ceviri.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeEkleToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kelimeEkleToolStripMenuItem
            // 
            this.kelimeEkleToolStripMenuItem.Name = "kelimeEkleToolStripMenuItem";
            this.kelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.kelimeEkleToolStripMenuItem.Text = "Kelime Ekle";
            this.kelimeEkleToolStripMenuItem.Click += new System.EventHandler(this.kelimeEkleToolStripMenuItem_Click);
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem.Text = "Quiz";
            this.quizToolStripMenuItem.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // btn_IngTrCeviri
            // 
            this.btn_IngTrCeviri.Location = new System.Drawing.Point(81, 193);
            this.btn_IngTrCeviri.Name = "btn_IngTrCeviri";
            this.btn_IngTrCeviri.Size = new System.Drawing.Size(371, 65);
            this.btn_IngTrCeviri.TabIndex = 5;
            this.btn_IngTrCeviri.Text = "İngilizce\'den Türkçe\'ye Çeviri";
            this.btn_IngTrCeviri.Click += new System.EventHandler(this.btn_IngTrCeviri_Click);
            // 
            // Ceviri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 381);
            this.Controls.Add(this.btn_IngTrCeviri);
            this.Controls.Add(this.btn_TrIngCeviri);
            this.Controls.Add(this.txt_Kelime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dt_Ceviri);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ceviri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceviri";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kelime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Ceviri)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Kelime;
        private DevExpress.XtraEditors.SimpleButton btn_TrIngCeviri;
        private System.Windows.Forms.DataGridView dt_Ceviri;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btn_IngTrCeviri;
    }
}

