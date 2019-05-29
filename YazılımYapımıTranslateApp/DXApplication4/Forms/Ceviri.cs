using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication4
{
    public partial class Ceviri : DevExpress.XtraEditors.XtraForm
    {
        Translate translate = new Translate();
        public Ceviri()
        {
            InitializeComponent();
        }
  

        private void btn_TrIngCeviri_Click(object sender, EventArgs e)
        {
            string cumle = "exec TrEnTranslate '" + txt_Kelime.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            dt_Ceviri.DataSource= translate.listele(adapter, cumle);
            dt_Ceviri.RowHeadersVisible = false; //Gizlenmesini sağlar
        }

        private void kelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KelimeEkle ekle = new KelimeEkle();
            ekle.ShowDialog();
        }

        private void btn_IngTrCeviri_Click(object sender, EventArgs e)
        {
            string cumle = "exec EnTrTranslate '" + txt_Kelime.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            dt_Ceviri.DataSource = translate.listele(adapter, cumle);
            dt_Ceviri.RowHeadersVisible = false; //Gizlenmesini sağlar
            
            
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Show();
        }
    }
}
