using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazılımSınamaFinal.businessEntities;

namespace yazılımSınamaFinal.DbLayers
{
    
    class taskDbLayer:DbConnection
    {
        /// <summary>
        /// MSSQLdeki task Tablosundaki Değerleri Programda Tasklar Listesi Yapıyor
        /// </summary>
        /// <returns>List(Tasklar) Türünde Bir List</returns>
        public List<Tasklar> gettaskList()
        {
            //döndürmek için bir Task listesi oluşturuyor
            List<Tasklar> taskList = new List<Tasklar>();
            try
            {
                cmd = new SqlCommand("SELECT * FROM task", con);//task Tablosunda değer çekmek için bir select Yazılıyor
                con.Open();//database bağlanılıyor
                SqlDataReader rdr = cmd.ExecuteReader();//verileri rdr isimli değişkene atıyor
                while (rdr.Read())//rdr değişkeninde okunacak satır kadar rdr bir satır okuyor
                {
                    Tasklar task = new Tasklar();//kullanıcıyı bilgilerini tutmak için bir nesne yaratılıyor
                    task.taskId = Convert.ToInt32(rdr["taskId"]);//okunan satırdaki taskId değişkeni task nesnesine atılıyor
                    task.taskAdi = rdr["taskAdi"].ToString();
                    task.durumId= Convert.ToInt32(rdr["durumId"]);
                    task.projeId= Convert.ToInt32(rdr["projeId"]);
                    task.kullaniciId = Convert.ToInt32(rdr["kullaniciId"]);
                    task.aciklama= rdr["aciklama"].ToString();
                    task.notlar= rdr["notlar"].ToString();
                    task.olusturmaTarih= Convert.ToDateTime(rdr["olusturmaTarih"]);
                    task.tahminiSonTarih= Convert.ToDateTime(rdr["tahminiSonTarih"]);
                    taskList.Add(task);//Olusturulan task nesnesi listeye atılıyor
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();//açılan database bağlantısı kapatılıyor
            }
            return taskList;//oluşturulan kullanıcı listesi döndürülüyor
        }
        /// <summary>
        /// Programdan Gelen Task Nesnesini MSSQL task tablosu içerisine yazmaya yarayan kodlar
        /// </summary>
        /// <param name="task"> Taskların bilgilerinin tutulduğu bir businessEntities classı</param>
        /// <returns>Bool değer</returns>
        public bool insertTask(Tasklar task)
        {
                try
                {
                //Gerekli tabloya değer eklemek için gereken sql kodun yazılması
                    cmd = new SqlCommand("INSERT INTO task (taskAdi,durumId,projeId,kullaniciId,aciklama,notlar,olusturmaTarih,tahminiSonTarih) VALUES(@taskAdi,@durumId,@projeId,@kullaniciId,@aciklama,@notlar,@olusturmaTarih,@tahminiSonTarih)", con);
                    cmd.Parameters.AddWithValue("@taskAdi", task.taskAdi);//sql ifadeye programdan parametre ataması yapılıyor
                    cmd.Parameters.AddWithValue("@durumId", task.durumId);
                    cmd.Parameters.AddWithValue("@projeId", task.projeId);
                cmd.Parameters.AddWithValue("@kullaniciId", task.kullaniciId);
                cmd.Parameters.AddWithValue("@aciklama", task.aciklama);
                cmd.Parameters.AddWithValue("@notlar", task.notlar);
                cmd.Parameters.AddWithValue("@olusturmaTarih", task.olusturmaTarih);
                cmd.Parameters.AddWithValue("@tahminiSonTarih", task.tahminiSonTarih);
                con.Open();//database bağlanılıyor
                cmd.ExecuteNonQuery();//Sql İfadesi veritabanında bağlantı yapılıyor
                }
                catch
                {
                con.Close();//bir hata durumunda veritabanı açık kalmış ise kapatılıyor
                return false;
                }
                finally
                {
                    con.Close();
                }
                return true;
            
        }
        /// <summary>
        /// Programdan Gelen güncel Task nesnesini değerleri ile MSSQLdeki bağlantılı olan task tablosunu güncelliyor
        /// </summary>
        /// <param name="task">Taskların bilgilerinin tutulduğu bir businessEntities classı</param>
        /// <returns>Bool değer</returns>
        public bool updateTask(Tasklar task)
        {
            try
            {
                //programdan gelen task verisiyle tablodaki taskId ile eşleşen sonuçları güncelliyor
                cmd = new SqlCommand("UPDATE Task SET taskAdi = @taskAdi,durumId = @durumId, kullaniciId = @kullaniciId ,aciklama = @aciklama,notlar= @notlar,tahminiSonTarih = @tahminiSonTarih WHERE taskId = @taskId", con);
                cmd.Parameters.AddWithValue("@taskAdi", task.taskAdi);//sql ifadeye programdan parametre ataması yapılıyor
                cmd.Parameters.AddWithValue("@taskId", task.taskId);
                cmd.Parameters.AddWithValue("@durumId", task.durumId);
                cmd.Parameters.AddWithValue("@kullaniciId", task.kullaniciId);
                cmd.Parameters.AddWithValue("@aciklama", task.aciklama);
                cmd.Parameters.AddWithValue("@notlar", task.notlar);
                cmd.Parameters.AddWithValue("@tahminiSonTarih", task.tahminiSonTarih);
                con.Open();//database bağlanılıyor
                cmd.ExecuteNonQuery();//Sql İfadesi veritabanında bağlantı yapılıyor
            }
            catch
            {
                con.Close();//bir hata durumunda veritabanı açık kalmış ise kapatılıyor
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        /// <summary>
        /// Programda yeni bir task eklemeden önce en son eklenen task idsini çekiyor ve yeni bir id için bu Idiyi 1 ile artırıp döndürüyor
        /// </summary>
        /// <returns>İnt Değer</returns>
        public int newIndex()
        {
            cmd = new SqlCommand("SELECT IDENT_CURRENT('task')", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i+1;
        }
    }
}
