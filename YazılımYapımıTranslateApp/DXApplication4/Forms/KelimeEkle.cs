using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DXApplication4
{
    public partial class KelimeEkle : DevExpress.XtraEditors.XtraForm
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }
        Translate translate = new Translate();

        private void KelimeEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter();
            string cumle = "select * from Turkce t inner join Ingilizce i on t.Id=i.Id";
            dt_Kelimeler.DataSource=translate.listele(komut,cumle);
            dt_Kelimeler.RowHeadersVisible = false;
            dt_Kelimeler.Columns[0].Visible = false;
            dt_Kelimeler.Columns[1].HeaderText = "Turkce Kelime";
            dt_Kelimeler.Columns[2].Visible = false;
            dt_Kelimeler.Columns[3].HeaderText = "Ingilizce Kelime";
        }

        private void btn_KelimeEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();                
            string cumle2 = "Exec KelimeEkleTr'" + txt_TrKelime.Text + "'";
            string cumle = "Exec KelimeEkleEn'" + txt_IngKelime.Text + "'";
            translate.ekle_sil_guncelle(komut, cumle);
            translate.ekle_sil_guncelle(komut, cumle2);
            KelimeEkle_Load(null, null);
        }

    }
}