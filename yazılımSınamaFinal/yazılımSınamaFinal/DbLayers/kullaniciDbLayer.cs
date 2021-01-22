using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using yazılımSınamaFinal.businessEntities;

namespace yazılımSınamaFinal.DbLayers
{
    class kullaniciDbLayer:DbConnection
    {
        /// <summary>
        /// MSSQLdeki Kullanici Tablosundaki Değerleri Programda Kullanici Listesi Yapıyor
        /// </summary>
        /// <returns>List(kullanici) Türünde Bir List</returns>
        public List<Kullanicilar> getKullaniciList()
        {
            //döndürmek için bir kullanıcı listesi oluşturuyor
            List<Kullanicilar> kullaniciList = new List<Kullanicilar>();
            try
            {
                cmd = new SqlCommand("SELECT * FROM kullanici", con);//kullanici Tablosunda değer çekmek için bir select Yazılıyor
                con.Open();//database bağlanılıyor
                SqlDataReader rdr = cmd.ExecuteReader();//verileri rdr isimli değişkene atıyor
                while (rdr.Read())//rdr değişkeninde okunacak satır kadar rdr bir satır okuyor
                {
                    Kullanicilar kullanici = new Kullanicilar();//kullanıcıyı bilgilerini tutmak için bir nesne yaratılıyor
                    kullanici.kullaniciId = Convert.ToInt32(rdr["kullaniciId"]);//okunan satırdaki kullaniciId değişkeni kullanici nesnesine atılıyor
                    kullanici.kullaniciAdi = rdr["kullaniciAdi"].ToString();
                    kullaniciList.Add(kullanici);//Olusturulan Kullanici nesnesi listeye atılıyor
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();//açılan database bağlantısı kapatılıyor
            }
            return kullaniciList;//oluşturulan kullanıcı listesi döndürülüyor
        }


    }
}
