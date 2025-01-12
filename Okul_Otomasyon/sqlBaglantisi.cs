using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Okul_Otomasyon
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=Philips\SQLEXPRESS;Initial Catalog=dbo.OkulOtomasyon;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
