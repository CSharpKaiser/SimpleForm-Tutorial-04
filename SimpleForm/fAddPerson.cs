using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleForm.Model;

namespace SimpleForm
{
    public partial class fAddPerson : Form
    {
        public Person SavedPerson = null;

        public fAddPerson()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SavedPerson = new Person();
            SavedPerson.Title = tbTitle.Text;
            SavedPerson.Forename = tbForename.Text;
            SavedPerson.Surname = tbSurname.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
