using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazılımSınamaFinal.businessEntities;

namespace yazılımSınamaFinal.DbLayers
{
    class durumDbLayer:DbConnection
    {
        /// <summary>
        /// MSSQLdeki Durum Tablosundaki Değerleri Programda Durum Listesi Yapıyor
        /// </summary>
        /// <returns>List(Durumlar) Türünde Bir List</returns>
        public List<Durumlar> getdurumList()
        {
            //döndürmek için bir kullanıcı listesi oluşturuyor
            List<Durumlar> durumList = new List<Durumlar>();
            try
            {
                cmd = new SqlCommand("SELECT * FROM durum", con);//durum Tablosunda değer çekmek için bir select Yazılıyor
                con.Open();//database bağlanılıyor
                SqlDataReader rdr = cmd.ExecuteReader();//verileri rdr isimli değişkene atıyor
                while (rdr.Read())//rdr değişkeninde okunacak satır kadar rdr bir satır okuyor
                {
                    Durumlar durum = new Durumlar();//kullanıcıyı bilgilerini tutmak için bir nesne yaratılıyor
                    durum.durumId = Convert.ToInt32(rdr["durumId"]);//okunan satırdaki durumId değişkeni durum nesnesine atılıyor
                    durum.durumAdi = rdr["durumAdi"].ToString();
                    durumList.Add(durum);//Olusturulan durum nesnesi listeye atılıyor
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();//açılan database bağlantısı kapatılıyor
            }
            return durumList;//oluşturulan durum listesi döndürülüyor
        }
    }
}
