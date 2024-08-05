using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.DataManager
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDataForm frm = new InsertDataForm();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListForm frm = new ListForm();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }
    }
}
