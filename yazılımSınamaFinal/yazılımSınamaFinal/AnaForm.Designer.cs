namespace yazılımSınamaFinal
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaskBoard = new System.Windows.Forms.Button();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnTaskBoard);
            this.panel1.Controls.Add(this.btnTaskEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnTaskBoard
            // 
            this.btnTaskBoard.Location = new System.Drawing.Point(135, 12);
            this.btnTaskBoard.Name = "btnTaskBoard";
            this.btnTaskBoard.Size = new System.Drawing.Size(93, 44);
            this.btnTaskBoard.TabIndex = 1;
            this.btnTaskBoard.Text = "Task Board Aç";
            this.btnTaskBoard.UseVisualStyleBackColor = true;
            this.btnTaskBoard.Click += new System.EventHandler(this.btnTaskBoard_Click);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(22, 12);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(75, 44);
            this.btnTaskEkle.TabIndex = 0;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 0);
            this.panel2.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 75);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "Ana Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaskBoard;
    }
}