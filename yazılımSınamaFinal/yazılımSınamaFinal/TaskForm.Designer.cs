namespace yazılımSınamaFinal
{
    partial class TaskForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjeAdLabel = new System.Windows.Forms.Label();
            this.ProjeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KullaniciId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OlusturmaTarihiLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KartIdLbl = new System.Windows.Forms.Label();
            this.TahminiTarihLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TaskAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskNotlar = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.TaskAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjeAdLabel
            // 
            this.ProjeAdLabel.AutoSize = true;
            this.ProjeAdLabel.Location = new System.Drawing.Point(24, 21);
            this.ProjeAdLabel.Name = "ProjeAdLabel";
            this.ProjeAdLabel.Size = new System.Drawing.Size(49, 13);
            this.ProjeAdLabel.TabIndex = 0;
            this.ProjeAdLabel.Text = "Proje Adı";
            // 
            // ProjeAdi
            // 
            this.ProjeAdi.Location = new System.Drawing.Point(107, 21);
            this.ProjeAdi.Name = "ProjeAdi";
            this.ProjeAdi.Size = new System.Drawing.Size(228, 20);
            this.ProjeAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teknik Uzman";
            // 
            // KullaniciId
            // 
            this.KullaniciId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KullaniciId.FormattingEnabled = true;
            this.KullaniciId.Location = new System.Drawing.Point(107, 109);
            this.KullaniciId.Name = "KullaniciId";
            this.KullaniciId.Size = new System.Drawing.Size(228, 21);
            this.KullaniciId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oluşturma Tarihi";
            // 
            // OlusturmaTarihiLbl
            // 
            this.OlusturmaTarihiLbl.AutoSize = true;
            this.OlusturmaTarihiLbl.Location = new System.Drawing.Point(612, 22);
            this.OlusturmaTarihiLbl.Name = "OlusturmaTarihiLbl";
            this.OlusturmaTarihiLbl.Size = new System.Drawing.Size(35, 13);
            this.OlusturmaTarihiLbl.TabIndex = 5;
            this.OlusturmaTarihiLbl.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kart No";
            // 
            // KartIdLbl
            // 
            this.KartIdLbl.AutoSize = true;
            this.KartIdLbl.Location = new System.Drawing.Point(612, 49);
            this.KartIdLbl.Name = "KartIdLbl";
            this.KartIdLbl.Size = new System.Drawing.Size(35, 13);
            this.KartIdLbl.TabIndex = 7;
            this.KartIdLbl.Text = "label4";
            // 
            // TahminiTarihLbl
            // 
            this.TahminiTarihLbl.AutoSize = true;
            this.TahminiTarihLbl.Location = new System.Drawing.Point(612, 91);
            this.TahminiTarihLbl.Name = "TahminiTarihLbl";
            this.TahminiTarihLbl.Size = new System.Drawing.Size(0, 13);
            this.TahminiTarihLbl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tahmini Bitiş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İş Açıklama";
            // 
            // TaskAciklama
            // 
            this.TaskAciklama.Location = new System.Drawing.Point(27, 175);
            this.TaskAciklama.Multiline = true;
            this.TaskAciklama.Name = "TaskAciklama";
            this.TaskAciklama.Size = new System.Drawing.Size(718, 86);
            this.TaskAciklama.TabIndex = 13;
            this.TaskAciklama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TaskAdi_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Notlar";
            // 
            // TaskNotlar
            // 
            this.TaskNotlar.Location = new System.Drawing.Point(27, 280);
            this.TaskNotlar.Multiline = true;
            this.TaskNotlar.Name = "TaskNotlar";
            this.TaskNotlar.Size = new System.Drawing.Size(718, 63);
            this.TaskNotlar.TabIndex = 16;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(27, 368);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(718, 40);
            this.ekleBtn.TabIndex = 18;
            this.ekleBtn.Text = "İşi Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // TaskAdi
            // 
            this.TaskAdi.Location = new System.Drawing.Point(107, 83);
            this.TaskAdi.Name = "TaskAdi";
            this.TaskAdi.Size = new System.Drawing.Size(228, 20);
            this.TaskAdi.TabIndex = 19;
            this.TaskAdi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TaskAdi_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "İş Adı";
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Location = new System.Drawing.Point(27, 368);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(718, 40);
            this.GuncelleBtn.TabIndex = 21;
            this.GuncelleBtn.Text = "İşi Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskAdi);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.TaskNotlar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TaskAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TahminiTarihLbl);
            this.Controls.Add(this.KartIdLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OlusturmaTarihiLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KullaniciId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjeAdi);
            this.Controls.Add(this.ProjeAdLabel);
            this.Name = "TaskForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjeAdLabel;
        private System.Windows.Forms.TextBox ProjeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KullaniciId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OlusturmaTarihiLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KartIdLbl;
        private System.Windows.Forms.Label TahminiTarihLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TaskAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskNotlar;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.TextBox TaskAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GuncelleBtn;
    }
}

