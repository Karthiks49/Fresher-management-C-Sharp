using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace FreshersInfo
{
    public partial class CreateFresher : Form
    {
        ViewFresher viewFresher = new ViewFresher();
        FresherManagement fresherManagement = new FresherManagement();
        public BindingList<FresherDetail> fresherList = new BindingList<FresherDetail>();
        public string name;
        private DateTime dateOfBirth;
        private long mobileNumber;
        private string address;
        private string qualification;
        public int row;

        public CreateFresher()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            name = nameContainer.Text;
            dateOfBirth = dateOfBirthContainer.Value;
            mobileNumber = long.Parse(mobileNumberContainer.Text);
            address = addressContainer.Text;
            qualification = course.Text;

            FresherDetail fresher = new FresherDetail(name, dateOfBirth, mobileNumber, address, qualification);

            fresherList.Add(fresher);
            Clear();
            FresherManagement fresherManagement = new FresherManagement();
            fresherManagement.AddFresher(fresher);
            MessageBox.Show(name + " added successfully !!!");
        }

        public void Clear()
        {
            nameContainer.Clear();
            dateOfBirthContainer.Text = "";
            mobileNumberContainer.Clear();
            addressContainer.Clear();
            course.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            fresherList = fresherManagement.GetFreshers();

            fresherList[row].name = nameContainer.Text;
            fresherList[row].dateOfBirth = dateOfBirthContainer.Value;
            fresherList[row].mobileNumber = long.Parse(mobileNumberContainer.Text);
            fresherList[row].address = addressContainer.Text;
            fresherList[row].qualification = course.Text;

            fresherManagement.UpdateFresherList(name, fresherList[row]);
            viewFresher.Display();
            Clear();

            MessageBox.Show(fresherList[row].name + " updated successfully !!!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            fresherList = fresherManagement.GetFreshers();
            string name = fresherList[row].name;
            fresherList.RemoveAt(row);
            viewFresher.Display();
            Clear();
            MessageBox.Show(name + " deleted successfully !!!");
        }

        public void GetValues(string name, DateTime dateOfBirth, string mobileNumber, string address, string qualification)
        {
            nameContainer.Text = name;
            dateOfBirthContainer.Value = dateOfBirth;
            mobileNumberContainer.Text = mobileNumber;
            addressContainer.Text = address;
            course.Text = qualification;
        }
    }
}
