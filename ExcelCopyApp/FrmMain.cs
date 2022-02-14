using System;
using System.IO;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace ExcelCopyApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnKaynak_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_Kaynak.SelectedPath = txtKaynak.Text;
            DialogResult drResult = folderBrowserDialog_Kaynak.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtKaynak.Text = folderBrowserDialog_Kaynak.SelectedPath;
        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_Hedef.SelectedPath = txtHedef.Text;
            DialogResult drResult = folderBrowserDialog_Hedef.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtHedef.Text = folderBrowserDialog_Hedef.SelectedPath;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            openFileDialog_Excel.Title = "Lütfen Dosya Seçiniz";
            openFileDialog_Excel.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            openFileDialog_Excel.FilterIndex = 1;
            openFileDialog_Excel.Multiselect = true;
            if (openFileDialog_Excel.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                lbExcel.Items.Clear();
                lbHata.Items.Clear();

                txtExcel.Text = openFileDialog_Excel.FileName;

                ExcelApp.Application excelApp = new ExcelApp.Application();
                ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(openFileDialog_Excel.FileName);
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                ExcelApp.Range excelRange = excelSheet.UsedRange;

                for (int i = 2; i <= excelRange.Rows.Count; i++)
                {
                    lbExcel.Items.Add(excelRange.Cells[i, 2].Value); // .ToString());
                }


                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                if (lbExcel.Items.Count > 0)
                {
                    lblKayitSayisi.Text = lbExcel.Items.Count.ToString();
                    btnKopyala.Enabled = true;
                }
                else
                {
                    lblKayitSayisi.Text = lbExcel.Items.Count.ToString();
                    btnKopyala.Enabled = false;
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (txtKaynak.Text == "" || txtHedef.Text == "")
            {
                MessageBox.Show("Kaynak ve hedef adresleri boş bırakılamaz!", "Hata");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            string fileName = "";
            string sourcePath = txtKaynak.Text;
            string targetPath = txtHedef.Text;
            for (int i = 0; i < lbExcel.Items.Count; i++)
            {
                fileName = lbExcel.Items[i].ToString();
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                try { System.IO.File.Copy(sourceFile, destFile, true); }
                catch { lbHata.Items.Add(fileName); }
            }



            if (lbHata.Items.Count == 0)
            {
                btnListeyiKaydet.Enabled = false;
                lbExcel.Items.Clear();
                MessageBox.Show("Kopyalama hatasız tamamlanmıştır.", "Sonuç");
            }
            else
            {
                btnListeyiKaydet.Enabled = true;
                lbExcel.Items.Clear();
                for (int i = 0; i < lbHata.Items.Count; i++)
                    lbExcel.Items.Add(lbHata.Items[i].ToString());
                MessageBox.Show("Kopyalama hatalı tamamlanmıştır.", "Sonuç");
            }

            lblKayitSayisi.Text = lbExcel.Items.Count.ToString();

            Cursor.Current = Cursors.Default;
        }

        private void btnListeyiKaydet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string dosyaAdi = Application.StartupPath.ToString() + "\\Hata_" + DateTime.Now.ToString().Replace(":", "_");
            FileStream fs = File.Create(dosyaAdi);
            fs.Close();
            StreamWriter sw = new StreamWriter(dosyaAdi);
            for (int i = 0; i < lbExcel.Items.Count; i++)
                sw.WriteLine(lbExcel.Items[i].ToString());
            sw.Close();

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Liste Kaydedilmiştir.", "Sonuç");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
