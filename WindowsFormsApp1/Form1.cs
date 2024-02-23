using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        private People peopleList = new People();
        public MyForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            nmrAge.Value = nmrAge.Minimum;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {

                FirstName = txtbxFirstName.Text,
                LastName = txtbxLastName.Text,
                Age = (int)nmrAge.Value,
                MobileType = rdbtnApple.Checked ? MobileType.Apple : MobileType.Android
            };

            peopleList.Add(person);

            btnClear_Click(sender, e);
            DisplayPeople();
            UpdateVisiblePeopleCount();
        }

        private void rdbtnAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPeople();
        }

        private void rdbtnAppleUsers_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPeople();
        }

        private void rdbtnAndroidUsers_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPeople();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            peopleList.Clear();
            dtgdPeople.DataSource = null;  
            UpdateVisiblePeopleCount();
        }
        private void DisplayPeople()
        {
            if (rdbtnAllUsers.Checked)
                dtgdPeople.DataSource = peopleList.GetAllPeople().ToList();
            else if (rdbtnAppleUsers.Checked)
                dtgdPeople.DataSource = peopleList.GetApplePeople().ToList();
            else if (rdbtnAndroidUsers.Checked)
                dtgdPeople.DataSource = peopleList.GetAndroidPeople().ToList();

            UpdateVisiblePeopleCount();
        }
        private void UpdateVisiblePeopleCount()
        {
            lblVisiblePeople.Text = $"Visible People: {dtgdPeople.RowCount}";
            lblTotalPeople.Text = $"Total People: {peopleList.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
