using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımSınamaFinal.DbLayers
{
    /// <summary>
    /// Database İle Bağlantı Sağlamak için gerekli özellikleri tutan sınıf
    /// </summary>
   abstract class  DbConnection
    {
        private string connectionString;//databasei bağlamak için gerekli bağlantı cümlesi
        protected SqlConnection con;//database bağlantısı sağlayan değişken
        protected SqlCommand cmd;//databasede sql işlemleri yapmayı sağlayan değişken
        public DbConnection()
        {
            connectionString = "Database=proje; Server=localhost; Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
    }
}
