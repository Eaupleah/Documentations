using CSharp.DataManager.Models;
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
    public partial class EditForm : MetroForm
    {
        private string _id;
        private readonly AcademyDbContext _db;
        public EditForm(string Id)
        {
            _id = Id;
            InitializeComponent();
            _db = new();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var person = _db.People.SingleOrDefault(p => p.Id == int.Parse(_id));
            txtFirstName.Text=person.FirstName;
            txtLastName.Text=person.LastName;
            txtPhone.Text=person.Phone;
            txtMail.Text=person.Mail;



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var person = _db.People.SingleOrDefault(p => p.Id == int.Parse(_id));

            if (person != null)
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Mail = txtMail.Text;
                person.Phone = txtPhone.Text;
            }

            _db.SaveChanges();
            MessageBox.Show(
                    "Record Edited",
                    "Edit Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            this.Close();
            Refresh();


        }
    }
}

