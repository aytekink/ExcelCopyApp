using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFolderApp
{
    public partial class FormCopy : Form
    {
        public FormCopy()
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

        }
    }
}
