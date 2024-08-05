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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp.DataManager
{
    public partial class ListForm : MetroForm
    {
        private readonly AcademyDbContext _db;
        public ListForm()
        {
            InitializeComponent();
            _db = new();
        }
        void Refresh()
        {
            lstPeople.Items.Clear();

            var people = _db.People.Select(p => new
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Mail = p.Mail,
                Phone = p.Phone
            }).ToList();
            foreach (var person in people)
            {
                ListViewItem item = new ListViewItem(person.Id.ToString());
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Mail);
                item.SubItems.Add(person.Phone);
                lstPeople.Items.Add(item);
            }


        }

        private void cmsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Delete Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.No)
            {
                return;
            }

          
            var selectedIdText = lstPeople.SelectedItems[0].Text;



            var person = _db.People.SingleOrDefault(p => p.Id == int.Parse(selectedIdText));

            if (person != null)
            {
                _db.People.Remove(person);
            }
            bool result = _db.SaveChanges() > 0;

            if (result)
            {
                lstPeople.Items.Remove(lstPeople.SelectedItems[0]);
            }

            MessageBox.Show(
                    result ? "Record Deleted" : "Operation Error",
                    "Record Deletion Notification",
                    MessageBoxButtons.OK,
                    result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
                );
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to update.",
                    "Update Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string selectedId = lstPeople.SelectedItems[0].Text;
            EditForm frm = new(selectedId);
            frm.ShowDialog();
        }
    }
}
