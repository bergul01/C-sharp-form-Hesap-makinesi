namespace HesapMakinesi
{
    partial class Form1
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
            this.lblEkran = new System.Windows.Forms.Label();
            this.buttonPayda = new System.Windows.Forms.Button();
            this.buttonUstu = new System.Windows.Forms.Button();
            this.buttonKok = new System.Windows.Forms.Button();
            this.buttonBolme = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonCarpma = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonEksi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonArtı = new System.Windows.Forms.Button();
            this.buttonYuzde = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEsittir = new System.Windows.Forms.Button();
            this.buttonAlDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEkran
            // 
            this.lblEkran.BackColor = System.Drawing.Color.White;
            this.lblEkran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkran.Location = new System.Drawing.Point(14, 9);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(443, 97);
            this.lblEkran.TabIndex = 0;
            this.lblEkran.Text = "0";
            this.lblEkran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPayda
            // 
            this.buttonPayda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPayda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPayda.Location = new System.Drawing.Point(14, 187);
            this.buttonPayda.Name = "buttonPayda";
            this.buttonPayda.Size = new System.Drawing.Size(106, 74);
            this.buttonPayda.TabIndex = 1;
            this.buttonPayda.Text = "1/x";
            this.buttonPayda.UseVisualStyleBackColor = false;
            this.buttonPayda.Click += new System.EventHandler(this.buttonPayda_Click);
            // 
            // buttonUstu
            // 
            this.buttonUstu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUstu.Location = new System.Drawing.Point(126, 187);
            this.buttonUstu.Name = "buttonUstu";
            this.buttonUstu.Size = new System.Drawing.Size(106, 74);
            this.buttonUstu.TabIndex = 2;
            this.buttonUstu.Text = "x^2";
            this.buttonUstu.UseVisualStyleBackColor = false;
            this.buttonUstu.Click += new System.EventHandler(this.buttonUstu_Click);
            // 
            // buttonKok
            // 
            this.buttonKok.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKok.Location = new System.Drawing.Point(241, 188);
            this.buttonKok.Name = "buttonKok";
            this.buttonKok.Size = new System.Drawing.Size(106, 74);
            this.buttonKok.TabIndex = 3;
            this.buttonKok.Text = "Sqrt(x)";
            this.buttonKok.UseVisualStyleBackColor = false;
            this.buttonKok.Click += new System.EventHandler(this.buttonKok_Click);
            // 
            // buttonBolme
            // 
            this.buttonBolme.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBolme.Location = new System.Drawing.Point(356, 187);
            this.buttonBolme.Name = "buttonBolme";
            this.buttonBolme.Size = new System.Drawing.Size(106, 74);
            this.buttonBolme.TabIndex = 4;
            this.buttonBolme.Text = "/";
            this.buttonBolme.UseVisualStyleBackColor = false;
            this.buttonBolme.Click += new System.EventHandler(this.buttonBolme_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(14, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 74);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(126, 267);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 74);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(241, 268);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 74);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonCarpma
            // 
            this.buttonCarpma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCarpma.Location = new System.Drawing.Point(356, 267);
            this.buttonCarpma.Name = "buttonCarpma";
            this.buttonCarpma.Size = new System.Drawing.Size(106, 74);
            this.buttonCarpma.TabIndex = 8;
            this.buttonCarpma.Text = "X";
            this.buttonCarpma.UseVisualStyleBackColor = false;
            this.buttonCarpma.Click += new System.EventHandler(this.buttonCarpma_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(15, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 74);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(126, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 74);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(241, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 74);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonEksi
            // 
            this.buttonEksi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEksi.Location = new System.Drawing.Point(354, 348);
            this.buttonEksi.Name = "buttonEksi";
            this.buttonEksi.Size = new System.Drawing.Size(106, 74);
            this.buttonEksi.TabIndex = 12;
            this.buttonEksi.Text = "-";
            this.buttonEksi.UseVisualStyleBackColor = false;
            this.buttonEksi.Click += new System.EventHandler(this.buttonEksi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(15, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 74);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(126, 427);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(106, 74);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(241, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 74);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonArtı
            // 
            this.buttonArtı.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonArtı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonArtı.Location = new System.Drawing.Point(354, 429);
            this.buttonArtı.Name = "buttonArtı";
            this.buttonArtı.Size = new System.Drawing.Size(106, 74);
            this.buttonArtı.TabIndex = 16;
            this.buttonArtı.Text = "+";
            this.buttonArtı.UseVisualStyleBackColor = false;
            this.buttonArtı.Click += new System.EventHandler(this.buttonArtı_Click);
            // 
            // buttonYuzde
            // 
            this.buttonYuzde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYuzde.Location = new System.Drawing.Point(353, 509);
            this.buttonYuzde.Name = "buttonYuzde";
            this.buttonYuzde.Size = new System.Drawing.Size(106, 74);
            this.buttonYuzde.TabIndex = 17;
            this.buttonYuzde.Text = "%";
            this.buttonYuzde.UseVisualStyleBackColor = false;
            this.buttonYuzde.Click += new System.EventHandler(this.buttonYuzde_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button0.Location = new System.Drawing.Point(126, 510);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 74);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonEsittir
            // 
            this.buttonEsittir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEsittir.Location = new System.Drawing.Point(241, 510);
            this.buttonEsittir.Name = "buttonEsittir";
            this.buttonEsittir.Size = new System.Drawing.Size(106, 74);
            this.buttonEsittir.TabIndex = 20;
            this.buttonEsittir.Text = "=";
            this.buttonEsittir.UseVisualStyleBackColor = false;
            this.buttonEsittir.Click += new System.EventHandler(this.buttonEsittir_Click);
            // 
            // buttonAlDelete
            // 
            this.buttonAlDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAlDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAlDelete.Location = new System.Drawing.Point(356, 109);
            this.buttonAlDelete.Name = "buttonAlDelete";
            this.buttonAlDelete.Size = new System.Drawing.Size(106, 74);
            this.buttonAlDelete.TabIndex = 21;
            this.buttonAlDelete.Text = "C";
            this.buttonAlDelete.UseVisualStyleBackColor = false;
            this.buttonAlDelete.Click += new System.EventHandler(this.buttonAlDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(472, 596);
            this.Controls.Add(this.buttonAlDelete);
            this.Controls.Add(this.buttonEsittir);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonYuzde);
            this.Controls.Add(this.buttonArtı);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEksi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCarpma);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonBolme);
            this.Controls.Add(this.buttonKok);
            this.Controls.Add(this.buttonUstu);
            this.Controls.Add(this.buttonPayda);
            this.Controls.Add(this.lblEkran);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEkran;
        private System.Windows.Forms.Button buttonPayda;
        private System.Windows.Forms.Button buttonUstu;
        private System.Windows.Forms.Button buttonKok;
        private System.Windows.Forms.Button buttonBolme;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonCarpma;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonEksi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonArtı;
        private System.Windows.Forms.Button buttonYuzde;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonEsittir;
        private System.Windows.Forms.Button buttonAlDelete;
    }
}

