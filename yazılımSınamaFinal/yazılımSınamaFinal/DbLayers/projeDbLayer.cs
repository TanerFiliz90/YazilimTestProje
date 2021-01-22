using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazılımSınamaFinal.businessEntities;

namespace yazılımSınamaFinal.DbLayers
{
    class projeDbLayer:DbConnection
    {
        /// <summary>
        /// MSSQLdeki Proje Tablosundaki Değerleri Programda Kullanici Listesi Yapıyor
        /// </summary>
        /// <returns>List(Proje) Türünde Bir List</returns>
        public List<Projeler> getprojeList()
        {
            //döndürmek için bir kullanıcı listesi oluşturuyor
            List<Projeler> projeList = new List<Projeler>();
            try
            {
                cmd = new SqlCommand("SELECT * FROM proje", con);//proje Tablosunda değer çekmek için bir select Yazılıyor
                con.Open();//database bağlanılıyor
                SqlDataReader rdr = cmd.ExecuteReader();//verileri rdr isimli değişkene atıyor
                while (rdr.Read())//rdr değişkeninde okunacak satır kadar rdr bir satır okuyor
                {
                    Projeler proje = new Projeler();//kullanıcıyı bilgilerini tutmak için bir nesne yaratılıyor
                    proje.projeId = Convert.ToInt32(rdr["projeId"]);//okunan satırdaki projeId değişkeni proje nesnesine atılıyor
                    proje.projeAdi = rdr["projeAdi"].ToString();
                    projeList.Add(proje);//Olusturulan proje nesnesi listeye atılıyor
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();//açılan database bağlantısı kapatılıyor
            }
            return projeList;//oluşturulan kullanıcı listesi döndürülüyor
        }

    }
}
