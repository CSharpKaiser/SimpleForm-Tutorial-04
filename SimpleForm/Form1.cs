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
    public partial class fMain : Form
    {
        List<Person> personList;
        public fMain()
        {
            InitializeComponent();
            personList = new List<Person>();
        }

        private void Populate()
        {
            lvPeople.Items.Clear();
            foreach (Person pep in personList)
            {
                ListViewItem item = new ListViewItem(pep.Title);
                item.SubItems.Add(pep.Forename);
                item.SubItems.Add(pep.Surname);

                lvPeople.Items.Add(item);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fAddPerson addPerson = new fAddPerson();
            if (addPerson.ShowDialog() == DialogResult.OK)
            {

                Person newPerson = addPerson.SavedPerson;
                personList.Add(newPerson);
                Populate();
            }
        }
    }
}
