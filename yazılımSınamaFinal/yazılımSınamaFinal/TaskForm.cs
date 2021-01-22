using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yazılımSınamaFinal.businessEntities;
using yazılımSınamaFinal.DbLayers;

namespace yazılımSınamaFinal
{
    public partial class TaskForm : Form
    {
        Tasklar Ts;
        taskDbLayer taskDb = new taskDbLayer();
        AnaForm anaFrm;
        
        public TaskForm(AnaForm frm)
        {
            anaFrm = frm;
            InitializeComponent();
            GuncelleBtn.Visible = false;
            ekleBtn.Visible = true;
            ekleBtn.Enabled = false;
        }
        /// <summary>
        /// task Güncellem formunu sadece ona özel özellkilerin çağırıldığı ve değerlerinin girilidiği kısım
        /// </summary>
        /// <param name="frm"></param>
        public TaskForm(int taskId,AnaForm frm)
        {
            anaFrm = frm;
            Ts = taskDb.gettaskList().Find(x => x.taskId == taskId);
            string a= Ts.kullaniciId.ToString();
            InitializeComponent();
            GuncelleBtn.Visible = true;
            ekleBtn.Visible = false;
            TaskAdi.Text = Ts.taskAdi;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            kullaniciDbLayer kullaniciDb = new kullaniciDbLayer();
            List<Kullanicilar> klist = kullaniciDb.getKullaniciList();
            foreach (var item in klist)
            {
                KullaniciId.Items.Add(item.kullaniciAdi);
            }
            projeDbLayer projeDb = new projeDbLayer();
            List<Projeler> projeList = projeDb.getprojeList();
            ProjeAdi.ReadOnly = true;
            ProjeAdi.BackColor = System.Drawing.SystemColors.Window;

            if (Ts==null)
            {
                Ts = new Tasklar();
                KullaniciId.SelectedIndex = 0;
                Ts.olusturmaTarih = DateTime.Today;
                ProjeAdi.Text = projeList.Find(x => x.projeId == 1).projeAdi;
                Ts.taskId = taskDb.newIndex();
            }
            else
            {
                KullaniciId.SelectedIndex = Ts.kullaniciId-1;
                ProjeAdi.Text = projeList.Find(x => x.projeId == Ts.projeId).projeAdi;
                TaskAciklama.Text = Ts.aciklama;
                TaskNotlar.Text = Ts.notlar;
            }
            tahminiTarihBul();
            OlusturmaTarihiLbl.Text = Ts.olusturmaTarih.ToString("dd/MM/yyyy");
            TahminiTarihLbl.Text = Ts.tahminiSonTarih.ToString("dd/MM/yyyy");
            KartIdLbl.Text = Ts.taskId.ToString();

        }
        /// <summary>
        /// Task Adi girilene kadar kayıt edilmemesini sağlamak için ve Task adı ve task açıklamanın uzunluğuna göre tarih tahmini yapan kısmın çalıştırılığı kısım
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskAdi_KeyUp(object sender, KeyEventArgs e)
        {
            if (TaskAdi.Text=="")
            {
                GuncelleBtn.Enabled = false;
                ekleBtn.Enabled = false;
            }
            else
            {
                GuncelleBtn.Enabled = true;
                ekleBtn.Enabled = true;
            }
            tahminiTarihBul();

        }
        /// <summary>
        /// task eklerken/güncellerken ortak alınan değişkenleri formdan alan fonksiyon
        /// </summary>
        public void taskAdiAl()
        {
            Ts.kullaniciId = (KullaniciId.SelectedIndex)+1;
            Ts.aciklama = TaskAciklama.Text;
            Ts.notlar = TaskNotlar.Text;
            Ts.taskAdi = TaskAdi.Text;
        }
        /// <summary>
        /// task Ekleme Kodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            taskAdiAl();
            Ts.projeId = 1;
            Ts.durumId = 1;
            taskDb.insertTask(Ts);
            MessageBox.Show("Task Eklenmiştir");
            TaskBoardForm taskBoard = new TaskBoardForm(anaFrm);
            anaFrm.formGetir(taskBoard);
            this.Close();
        }
        /// <summary>
        /// ilk önce oluşturma tarihine 1 gün ekleniyor ve girilen task adi ve task açıklaması birleşeminin uzunluğunu alıp çıkan sonucun 24 ile bölüp bir gün ekliyor (Her 24 kelimede bir gün ekliyor)
        /// </summary>
        private void tahminiTarihBul()
        {
            string str = TaskAdi.Text + TaskAciklama.Text;
                Ts.tahminiSonTarih = Ts.olusturmaTarih.AddDays(1);
            Ts.tahminiSonTarih = Ts.tahminiSonTarih.AddDays(str.Length / 24);
                TahminiTarihLbl.Text = Ts.tahminiSonTarih.ToString("dd/MM/yyyy");
        }
        //güncelleme kısmı
        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            taskAdiAl();
            taskDb.updateTask(Ts);
            MessageBox.Show("Task Güncellenmiştir");
            TaskBoardForm taskBoard = new TaskBoardForm(anaFrm);
            anaFrm.formGetir(taskBoard);
            this.Close();
        }

    
    }
}
