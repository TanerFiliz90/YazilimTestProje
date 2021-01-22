using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazılımSınamaFinal.businessEntities;
using yazılımSınamaFinal.DbLayers;

namespace yazılımSınamaFinal
{
    public partial class TaskBoardForm : Form
    {
        List<Button>[] gruplar;
        taskDbLayer taskDb;
        AnaForm anaFrm;
        public TaskBoardForm(AnaForm frm)
        {
            //bu formdan anaformda başka bir form açmak için anaform değişkenini taskBoardForm nesnesini oluştururken veriyor ve 
            //bu classın içerisindeki anaFrm değişkenine atıyor
            anaFrm = frm;
            InitializeComponent();
            //Durum Gruplarının içerisinde olacak buttonları tutacak gruplar listesini oluşturuyor
            gruplar = new List<Button>[5];
            gruplar[0] = new List<Button>();
            gruplar[0].Add(button1);
            gruplar[1] = new List<Button>();
            gruplar[1].Add(button2);
            gruplar[2] = new List<Button>();
            gruplar[2].Add(button3);
            gruplar[3] = new List<Button>();
            gruplar[3].Add(button4);
            gruplar[4] = new List<Button>();
            gruplar[4].Add(button5);
            //task İle database işlemlerini yapmak için bir taskDb nesnesi oluşturuyor
            taskDb = new taskDbLayer();
        }

        List<Tasklar> tasks;
        private void TaskBoardForm_Load(object sender, EventArgs e)
        {
            //taskDbden task verilerini çekiyor ve tasks listesine atıyor
            tasks = taskDb.gettaskList().FindAll(x=>x.projeId==1);
            //oluşan tablo kadar buton ekliyor ve butonları gruplarına göre gruplar değişkenine ekliyor
            for (int i = 0; i < tasks.Count(); i++)
            {
                Button btn = new Button();
                btn.Width = 150;
                btn.Height = 100;
                btn.MouseMove += new MouseEventHandler(btn_MouseMove);//Butonların Hareket etmesi için gerekli evenler ekleniyor
                btn.MouseUp += new MouseEventHandler(btn_MouseUp);
                btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                btn.Name = "task" + tasks[i].taskId;
                btn.Text = tasks[i].taskAdi;
                this.Controls.Add(btn);
                gruplar[tasks[i].durumId - 1].Add(btn);
            }
            buttonLokasyonDüzenle();
        }
        /// <summary>
        /// gruplar değişkeninde oluşan grupların hepsinde dolaşa dolaşarak butun grupların içerisindeki butonların doğru yerde ve alt alta dizelmesini sağlatıyor
        /// </summary>
        private void buttonLokasyonDüzenle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < gruplar[i].Count(); j++)
                {
                    gruplar[i][j].Location = new Point(gruplar[i][j - 1].Location.X, gruplar[i][j - 1].Location.Y + gruplar[i][j - 1].Size.Height + 15);
                }

            }
        }
        Point konum;
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            //tıklanılan buttonun özelliklerini btn değişkenine kopyalanıyor
            Button btn = (Button)sender;
            //eğer butona sağ tıklandıysa task güncelleme Formunu çalıştırılıyor
            if (e.Button == MouseButtons.Right)
            {
                TaskForm taskForm = new TaskForm(taskId, anaFrm);
                anaFrm.formGetir(taskForm);
                this.Close();
            }
            //eğer butona sağ tıklandı ise buttonun ilk konumunu konum değişkenine atıyor ve butonun olduğu gruptan silip grupların butonlarını yeniden sıralandırıyor
            else if (e.Button == MouseButtons.Left)
            {
                konum = e.Location;
                for (int i = 0; i < 5; i++)
                {
                    gruplar[i].Remove(btn);
                }
                buttonLokasyonDüzenle();
            }

        }
        /// <summary>
        /// button tıklanıldığı zaman mouse hareket ettirilmişse butonun hareketini sağlayan metod
        /// </summary>
        /// <param name="sender">Tıklanınan Buttonunun özellikleri</param>
        /// <param name="e">Mouse un özellikleri</param>
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            //tıklanınlan buttonun durum bilgisini güncellemek için hangi task id bulunması için yazılan kod
            taskId = Convert.ToInt32(btn.Name.Replace("task", ""));
            //Tıklanınan buttonun hareket ettiriliyor
            if (e.Button == MouseButtons.Left)
            {
                btn.Left += e.X - (konum.X);
                btn.Top += e.Y - (konum.Y);
            }
        }
        int taskId;
        /// <summary>
        /// buttonun değişen yerine göre gruplar listesine ekliyor 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="btn"></param>
        private void btnLocationChange(int i, Button btn)
        {
            int y = gruplar[i][gruplar[i].Count() - 1].Location.Y + gruplar[i][gruplar[i].Count() - 1].Size.Height + 15;
            int x = gruplar[i][gruplar[i].Count() - 1].Location.X;
            btn.Location = new Point(x, y);
            gruplar[i].Add(btn);
            tasks[taskId - 1].durumId = i + 1;
        }
        //yukarıdaki komut ile grupların sınırları içerisinde buttonu hareket ettiriyor
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if ((btn.Location.X + 150 < gruplar[1][0].Location.X))
            {
                btnLocationChange(0, btn);

            }
            else if (btn.Location.X + 150 > gruplar[4][0].Location.X)
            {
                btnLocationChange(4, btn);
            }
            else if ((btn.Location.X + 150 < gruplar[2][0].Location.X && btn.Location.X + 150 > gruplar[1][0].Location.X))
            {
                btnLocationChange(1, btn);
            }
            else if ((btn.Location.X + 150 < gruplar[3][0].Location.X && btn.Location.X + 150 > gruplar[2][0].Location.X))
            {
                btnLocationChange(2, btn);
            }
            else if ((btn.Location.X + 150 < gruplar[4][0].Location.X && btn.Location.X + 150 > gruplar[3][0].Location.X))
            {
                btnLocationChange(3, btn);
            }
            taskDb.updateTask(tasks[taskId - 1]);


        }

    }
}
