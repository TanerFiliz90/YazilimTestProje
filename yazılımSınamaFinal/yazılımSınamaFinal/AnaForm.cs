using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımSınamaFinal
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// İç İçe form Açılımını yapılması için yapılan Kod
        /// </summary>
        /// <param name="frm">Açılacak Form nesnesi</param>
        public void formGetir(Form frm)
        {
            //ilk önce açılacak formu yerleştirmek için içini boşaltıliyor
            panel2.Controls.Clear();
            //bu Formun ana Form Olduğu söyleniyor
            frm.MdiParent = this;
            //Açılan Formun ana forma tam sığması için ana Formu boyunu büyütülüyor
            this.Size = new Size(frm.Size.Width,frm.Size.Height+80) ;
            //açılan formun kenarlıkları gözükmemesi için özelliğini değiştiriliyor
            frm.FormBorderStyle = FormBorderStyle.None;
            //Açılan formu anaform daki panelin içine ekliyor
            panel2.Controls.Add(frm);
            //açılan formu gösteriliyor
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskForm taskFrm = new TaskForm(this);
            formGetir(taskFrm);
        }

        private void btnTaskBoard_Click(object sender, EventArgs e)
        {
            TaskBoardForm taskBoard = new TaskBoardForm(this);
            formGetir(taskBoard);
        }
    }
}
