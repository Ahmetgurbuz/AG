namespace CrmProjesi
{
    partial class musteribilgigirisi
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
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.MusteriSoyad = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.rtxtadres = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgmusteri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgmusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(65, 429);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(166, 33);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(264, 429);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(143, 33);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(440, 429);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 33);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Guncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MusteriTckimlikno";
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(173, 47);
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(130, 20);
            this.txttcno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MusteriAD";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(173, 95);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(129, 20);
            this.txtad.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(173, 149);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // MusteriSoyad
            // 
            this.MusteriSoyad.AutoSize = true;
            this.MusteriSoyad.Location = new System.Drawing.Point(59, 152);
            this.MusteriSoyad.Name = "MusteriSoyad";
            this.MusteriSoyad.Size = new System.Drawing.Size(71, 13);
            this.MusteriSoyad.TabIndex = 8;
            this.MusteriSoyad.Text = "MusteriSoyad";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(173, 193);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(129, 20);
            this.txttel.TabIndex = 9;
            // 
            // rtxtadres
            // 
            this.rtxtadres.Location = new System.Drawing.Point(173, 234);
            this.rtxtadres.Name = "rtxtadres";
            this.rtxtadres.Size = new System.Drawing.Size(129, 67);
            this.rtxtadres.TabIndex = 10;
            this.rtxtadres.Text = "";
            this.rtxtadres.TextChanged += new System.EventHandler(this.rtxtadres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "telefonnumarasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "adres";
            // 
            // dgmusteri
            // 
            this.dgmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmusteri.Location = new System.Drawing.Point(349, 47);
            this.dgmusteri.Name = "dgmusteri";
            this.dgmusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmusteri.Size = new System.Drawing.Size(510, 253);
            this.dgmusteri.TabIndex = 13;
            this.dgmusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmusteri_CellContentClick);
            // 
            // musteribilgigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 470);
            this.Controls.Add(this.dgmusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtadres);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.MusteriSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Name = "musteribilgigirisi";
            this.Text = "MusteriBigliGirişi";
            this.Load += new System.EventHandler(this.Musteribilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label MusteriSoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.RichTextBox rtxtadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgmusteri;
    }
}