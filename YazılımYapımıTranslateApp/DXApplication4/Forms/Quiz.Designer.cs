namespace DXApplication4
{
    partial class Quiz
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
            this.txt_trKelime = new DevExpress.XtraEditors.LabelControl();
            this.dt_TrKelime = new System.Windows.Forms.DataGridView();
            this.btn_QuizYap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_IngKelime = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TrKelime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IngKelime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_trKelime
            // 
            this.txt_trKelime.Location = new System.Drawing.Point(21, 35);
            this.txt_trKelime.Name = "txt_trKelime";
            this.txt_trKelime.Size = new System.Drawing.Size(65, 13);
            this.txt_trKelime.TabIndex = 2;
            this.txt_trKelime.Text = "Türkçe Kelime";
            // 
            // dt_TrKelime
            // 
            this.dt_TrKelime.AllowUserToAddRows = false;
            this.dt_TrKelime.AllowUserToDeleteRows = false;
            this.dt_TrKelime.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dt_TrKelime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_TrKelime.GridColor = System.Drawing.SystemColors.Highlight;
            this.dt_TrKelime.Location = new System.Drawing.Point(21, 54);
            this.dt_TrKelime.Name = "dt_TrKelime";
            this.dt_TrKelime.ReadOnly = true;
            this.dt_TrKelime.Size = new System.Drawing.Size(120, 25);
            this.dt_TrKelime.TabIndex = 3;
            // 
            // btn_QuizYap
            // 
            this.btn_QuizYap.Location = new System.Drawing.Point(21, 109);
            this.btn_QuizYap.Name = "btn_QuizYap";
            this.btn_QuizYap.Size = new System.Drawing.Size(311, 23);
            this.btn_QuizYap.TabIndex = 4;
            this.btn_QuizYap.Text = "Quiz Yap";
            this.btn_QuizYap.Click += new System.EventHandler(this.btn_QuizYap_Click);
            // 
            // txt_IngKelime
            // 
            this.txt_IngKelime.Location = new System.Drawing.Point(185, 54);
            this.txt_IngKelime.Name = "txt_IngKelime";
            this.txt_IngKelime.Properties.AutoHeight = false;
            this.txt_IngKelime.Size = new System.Drawing.Size(147, 25);
            this.txt_IngKelime.TabIndex = 5;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 308);
            this.Controls.Add(this.txt_IngKelime);
            this.Controls.Add(this.btn_QuizYap);
            this.Controls.Add(this.dt_TrKelime);
            this.Controls.Add(this.txt_trKelime);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_TrKelime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IngKelime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl txt_trKelime;
        private System.Windows.Forms.DataGridView dt_TrKelime;
        private DevExpress.XtraEditors.SimpleButton btn_QuizYap;
        private DevExpress.XtraEditors.TextEdit txt_IngKelime;
    }
}