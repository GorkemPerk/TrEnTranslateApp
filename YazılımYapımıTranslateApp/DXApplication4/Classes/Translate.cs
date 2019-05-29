using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DXApplication4
{
    public class Translate
    {
        DataTable tablo;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NN2045F;Initial Catalog=Translate;Integrated Security=True");
 
        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            con.Open();
            komut.Connection = con;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }

        public DataTable listele(SqlDataAdapter adapter, string sorgu)
        {
            tablo = new DataTable();
            adapter = new SqlDataAdapter(sorgu, con);
            adapter.Fill(tablo);
            con.Close();
            return tablo;
        }
    }
}
