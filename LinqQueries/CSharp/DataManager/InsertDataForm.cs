using MetroFramework.Forms;
using CSharp.DataManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CSharp.DataManager
{

    public partial class InsertDataForm : MetroForm
    {
        private readonly AcademyDbContext _db;
        public InsertDataForm()
        {
            InitializeComponent();
            _db = new();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txtbox)
                {
                    txtbox.Clear();
                }
                else if (item is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _db.People.Add(new()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Mail = txtMail.Text,
                Phone = txtPhone.Text,

            });

            //_db.SaveChanges();

            bool result = _db.SaveChanges() > 0;


            MessageBox.Show(
                  text: result ? "Record Added" : "Operation Error",
                  caption: "Record Addition Notification",
                  buttons: MessageBoxButtons.OK,
                  icon: result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
            );

        }

        private void InsertDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormInstance.Show();

        }
    }
}
