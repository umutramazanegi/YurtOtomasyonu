using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Form_Yurt_Otomasyonu_SQL
{
    class SQLBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=UMUT\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
            baglanti.Open();
            return baglanti;

        }
    }
}
