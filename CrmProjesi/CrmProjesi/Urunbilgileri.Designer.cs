namespace CrmProjesi
{
    partial class urunbilgileri
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
            this.dgurunbilgileri = new System.Windows.Forms.DataGridView();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.Urunsil = new System.Windows.Forms.Button();
            this.brnurunguncelle = new System.Windows.Forms.Button();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtalisfiyati = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsatisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmalisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgurunbilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgurunbilgileri
            // 
            this.dgurunbilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgurunbilgileri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmid,
            this.clmad,
            this.clmsatisfiyati,
            this.clmalisfiyati,
            this.miktar});
            this.dgurunbilgileri.Location = new System.Drawing.Point(209, 26);
            this.dgurunbilgileri.Name = "dgurunbilgileri";
            this.dgurunbilgileri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgurunbilgileri.Size = new System.Drawing.Size(429, 227);
            this.dgurunbilgileri.TabIndex = 0;
            this.dgurunbilgileri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgurunbilgileri_CellContentClick);
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(41, 449);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(75, 39);
            this.btnurunekle.TabIndex = 1;
            this.btnurunekle.Text = "Ürün Ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // Urunsil
            // 
            this.Urunsil.Location = new System.Drawing.Point(675, 377);
            this.Urunsil.Name = "Urunsil";
            this.Urunsil.Size = new System.Drawing.Size(101, 39);
            this.Urunsil.TabIndex = 2;
            this.Urunsil.Text = "Ürün sil";
            this.Urunsil.UseVisualStyleBackColor = true;
            this.Urunsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // brnurunguncelle
            // 
            this.brnurunguncelle.Location = new System.Drawing.Point(675, 312);
            this.brnurunguncelle.Name = "brnurunguncelle";
            this.brnurunguncelle.Size = new System.Drawing.Size(101, 39);
            this.brnurunguncelle.TabIndex = 3;
            this.brnurunguncelle.Text = "Ürün Güncelle";
            this.brnurunguncelle.UseVisualStyleBackColor = true;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(112, 300);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(138, 20);
            this.txturunadi.TabIndex = 4;
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Location = new System.Drawing.Point(112, 331);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(138, 20);
            this.txtsatisfiyati.TabIndex = 5;
            // 
            // txtalisfiyati
            // 
            this.txtalisfiyati.Location = new System.Drawing.Point(112, 357);
            this.txtalisfiyati.Name = "txtalisfiyati";
            this.txtalisfiyati.Size = new System.Drawing.Size(138, 20);
            this.txtalisfiyati.TabIndex = 6;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(112, 387);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(138, 20);
            this.txtmiktar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ürünadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "satisfiyati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alişfiyati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "miktar";
            // 
            // clmid
            // 
            this.clmid.DataPropertyName = "urunid";
            this.clmid.HeaderText = "urunid";
            this.clmid.Name = "clmid";
            this.clmid.Visible = false;
            // 
            // clmad
            // 
            this.clmad.DataPropertyName = "urunadi";
            this.clmad.HeaderText = "urunadi";
            this.clmad.Name = "clmad";
            // 
            // clmsatisfiyati
            // 
            this.clmsatisfiyati.DataPropertyName = "satisfiyati";
            this.clmsatisfiyati.HeaderText = "satisfiyati";
            this.clmsatisfiyati.Name = "clmsatisfiyati";
            // 
            // clmalisfiyati
            // 
            this.clmalisfiyati.DataPropertyName = "alisfiyati";
            this.clmalisfiyati.HeaderText = "alisfiyati";
            this.clmalisfiyati.Name = "clmalisfiyati";
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "miktar";
            this.miktar.Name = "miktar";
            // 
            // urunbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txtalisfiyati);
            this.Controls.Add(this.txtsatisfiyati);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.brnurunguncelle);
            this.Controls.Add(this.Urunsil);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.dgurunbilgileri);
            this.Name = "urunbilgileri";
            this.Text = "Urunbilgileri";
            this.Load += new System.EventHandler(this.urunbilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgurunbilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgurunbilgileri;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button Urunsil;
        private System.Windows.Forms.Button brnurunguncelle;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtsatisfiyati;
        private System.Windows.Forms.TextBox txtalisfiyati;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsatisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmalisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;



    }
}