namespace ExcelCopyApp
{
    partial class FrmMain
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
            this.lbExcel = new System.Windows.Forms.ListBox();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHedef = new System.Windows.Forms.Button();
            this.btnKaynak = new System.Windows.Forms.Button();
            this.txtHedef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog_Hedef = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_Kaynak = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog_Excel = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnListeyiKaydet = new System.Windows.Forms.Button();
            this.lbHata = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbExcel
            // 
            this.lbExcel.FormattingEnabled = true;
            this.lbExcel.ItemHeight = 16;
            this.lbExcel.Location = new System.Drawing.Point(14, 43);
            this.lbExcel.Name = "lbExcel";
            this.lbExcel.Size = new System.Drawing.Size(642, 660);
            this.lbExcel.TabIndex = 2;
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(134, 11);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.ReadOnly = true;
            this.txtExcel.Size = new System.Drawing.Size(441, 22);
            this.txtExcel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Excel Doyası";
            // 
            // btnHedef
            // 
            this.btnHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHedef.Location = new System.Drawing.Point(581, 794);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(75, 26);
            this.btnHedef.TabIndex = 6;
            this.btnHedef.Text = "Seç";
            this.btnHedef.UseVisualStyleBackColor = true;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            // 
            // btnKaynak
            // 
            this.btnKaynak.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaynak.Location = new System.Drawing.Point(581, 753);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(75, 26);
            this.btnKaynak.TabIndex = 4;
            this.btnKaynak.Text = "Seç";
            this.btnKaynak.UseVisualStyleBackColor = true;
            this.btnKaynak.Click += new System.EventHandler(this.btnKaynak_Click);
            // 
            // txtHedef
            // 
            this.txtHedef.Location = new System.Drawing.Point(134, 796);
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.ReadOnly = true;
            this.txtHedef.Size = new System.Drawing.Size(441, 22);
            this.txtHedef.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 799);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hedef Klasör";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kaynak Klasör";
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(134, 755);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.ReadOnly = true;
            this.txtKaynak.Size = new System.Drawing.Size(441, 22);
            this.txtKaynak.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kayıt Sayısı";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitSayisi.ForeColor = System.Drawing.Color.Blue;
            this.lblKayitSayisi.Location = new System.Drawing.Point(131, 715);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(15, 16);
            this.lblKayitSayisi.TabIndex = 18;
            this.lblKayitSayisi.Text = "0";
            // 
            // btnKopyala
            // 
            this.btnKopyala.Enabled = false;
            this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKopyala.ForeColor = System.Drawing.Color.Red;
            this.btnKopyala.Location = new System.Drawing.Point(134, 838);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(182, 67);
            this.btnKopyala.TabIndex = 7;
            this.btnKopyala.Text = "Kopyalamayı Başlat";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Location = new System.Drawing.Point(581, 9);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 26);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Seç";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnListeyiKaydet
            // 
            this.btnListeyiKaydet.Enabled = false;
            this.btnListeyiKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeyiKaydet.ForeColor = System.Drawing.Color.Blue;
            this.btnListeyiKaydet.Location = new System.Drawing.Point(334, 838);
            this.btnListeyiKaydet.Name = "btnListeyiKaydet";
            this.btnListeyiKaydet.Size = new System.Drawing.Size(182, 67);
            this.btnListeyiKaydet.TabIndex = 8;
            this.btnListeyiKaydet.Text = "Listeyi Kaydet";
            this.btnListeyiKaydet.UseVisualStyleBackColor = true;
            this.btnListeyiKaydet.Click += new System.EventHandler(this.btnListeyiKaydet_Click);
            // 
            // lbHata
            // 
            this.lbHata.FormattingEnabled = true;
            this.lbHata.ItemHeight = 16;
            this.lbHata.Location = new System.Drawing.Point(14, 67);
            this.lbHata.MultiColumn = true;
            this.lbHata.Name = "lbHata";
            this.lbHata.Size = new System.Drawing.Size(487, 628);
            this.lbHata.TabIndex = 22;
            this.lbHata.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 919);
            this.Controls.Add(this.lbHata);
            this.Controls.Add(this.btnListeyiKaydet);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbExcel);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHedef);
            this.Controls.Add(this.btnKaynak);
            this.Controls.Add(this.txtHedef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKaynak);
            this.Name = "FrmMain";
            this.Text = "ESC | Dosya Kopyalama";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbExcel;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHedef;
        private System.Windows.Forms.Button btnKaynak;
        private System.Windows.Forms.TextBox txtHedef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Hedef;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Kaynak;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Excel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnListeyiKaydet;
        private System.Windows.Forms.ListBox lbHata;
    }
}