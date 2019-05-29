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
    public partial class Quiz : DevExpress.XtraEditors.XtraForm
    {
        
        public Quiz()
        {
            InitializeComponent();
        }
        Translate translate = new Translate();

        private void btn_QuizYap_Click(object sender, EventArgs e)
        {
            //Quiz Yapmamız için gereken kodlar
            DataGridViewRow satir = dt_TrKelime.CurrentRow;
            DataTable dt = new DataTable();
            string cumle = "exec EnTrTranslate '" + txt_IngKelime.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            dt = translate.listele(adapter, cumle);
            //try catch if sorgusunun exp hatasına dusmemesi için gerekli..s
            try
            {
                //Ingılızce kelimeyi turkceye cevirip rasgele gelen kelime ile kıyaslayan kod satırı
                if (satir.Cells[0].Value.ToString() == dt.Rows[0]["Kelime"].ToString())
                {
                    MessageBox.Show("Doğru Bildiniz!!!", "Yeni Quiz Yapmak İster Misin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    Quiz_Load(null, null);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Öğrende gel aslan !!", "Yeni Quiz Yapmak İster Misin?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                Quiz_Load(null, null);
            }
     
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            //VeriTabanından rasgele kelime getirmek için yapılan işlemler
            string cumle2 = "SELECT TOP 1 Kelime FROM Turkce ORDER BY NEWID()";
            SqlDataAdapter adapter = new SqlDataAdapter();
            dt_TrKelime.DataSource = translate.listele(adapter, cumle2);
            dt_TrKelime.RowHeadersVisible = false;
            dt_TrKelime.ColumnHeadersVisible = false;
        }
    }
}