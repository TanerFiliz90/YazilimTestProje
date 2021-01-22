using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazılımSınamaFinal.DbLayers;
using yazılımSınamaFinal.businessEntities;


namespace yazılımSınamaFinal
{
    [TestFixture]
    class Test:DbConnection
    {
        [Test]
        public void baglantıTest()
        {
            //database bağlanıp bağlanılmadığının testi
            con.Open();
            Assert.AreEqual(con.State, ConnectionState.Open);
            con.Close();
        }

        [Test]
        public void degerAlmaTesti()
        {
            //durum tablosu database bağlantısı yapılıyor ve durum değerlerini çekmeye çalışılıyor
            durumDbLayer db = new durumDbLayer();
            Assert.AreNotEqual(0, db.getdurumList().Count);
        }

        [Test]
        public void degerGirme()
        {
            //database bağlantısı yapılıyor
            taskDbLayer db = new taskDbLayer();
            Tasklar task = new Tasklar();
            //istenilen değerler giriliyor
            task.durumId = 1;
            task.projeId = 2;
            task.kullaniciId = 3;
            task.taskAdi = "Test";
            task.aciklama = "aa";
            task.notlar = "";
            task.olusturmaTarih = DateTime.Today;
            task.tahminiSonTarih = DateTime.Today;
            Assert.AreEqual(true,db.insertTask(task));
        }


    }
}
