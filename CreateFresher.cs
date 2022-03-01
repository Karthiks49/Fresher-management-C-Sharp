using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FreshersInfo
{
    public partial class CreateFresher : Form
    {
        ViewFresher viewFresher = new ViewFresher();
        FresherManagement fresherManagement = new FresherManagement();
        public BindingList<FresherDetail> fresherList = new FresherManagement().GetFreshers();
        public string name;
        private DateTime dateOfBirth;
        private long mobileNumber;

        private string address;
        private string qualification;
        public int row = 0;

        public CreateFresher()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isFresherExist = UpdateFresher();

                if (!isFresherExist)
                {
                    name = nameContainer.Text;
                    dateOfBirth = dateOfBirthContainer.Value;
                    mobileNumber = long.Parse(mobileNumberContainer.Text);
                    address = addressContainer.Text;
                    qualification = course.Text;

                    FresherDetail fresher = new FresherDetail(name, dateOfBirth.ToString("dd/MM/yyyy"), 
                                                              mobileNumber, address, qualification);

                    Clear();
                    fresherManagement.AddFresher(fresher);
                    MessageBox.Show(name + " added successfully !!!");
                    name = null;
                    save.Visible=true;
                }
            }
        }

        private bool UpdateFresher()
        {
            bool isFresherExist = false;

            if (fresherList.Count > row && name != null)
            {
                foreach (FresherDetail candidate in fresherList)
                {
                    if (name == candidate.name)
                    {
                        string updatedName = nameContainer.Text;
                        dateOfBirth = dateOfBirthContainer.Value;
                        mobileNumber = long.Parse(mobileNumberContainer.Text);
                        address = addressContainer.Text;
                        qualification = course.Text;

                        FresherDetail fresher = new FresherDetail(updatedName, dateOfBirth.ToString("dd/MM/yyyy"),
                                                                  mobileNumber, address, qualification);

                        fresherManagement.UpdateFresherList(name, fresher);
                        viewFresher.Display();
                        Clear();
                        MessageBox.Show(fresherList[row].name + " updated successfully !!!");
                        isFresherExist = true;
                        break;
                    }
                }
            }
            return isFresherExist;
        }

        public void Clear()
        {
            nameContainer.Clear();
            dateOfBirthContainer.Text = "";
            mobileNumberContainer.Clear();
            addressContainer.Clear();
            course.Text = "";
        }

        public void DeleteFresher(int index)
        {
            name = fresherList[index].name;
            fresherList.RemoveAt(index);
            viewFresher.Display();
            Clear();
            MessageBox.Show(name + " deleted successfully !!!");
        }

        public void GetValues(int index)
        {
            nameContainer.Text = fresherList[index].name;
            dateOfBirthContainer.Text = fresherList[index].dateOfBirth;
            mobileNumberContainer.Text = fresherList[index].mobileNumber.ToString();
            addressContainer.Text = fresherList[index].address;
            course.Text = fresherList[index].qualification;

            name = fresherList[index].name;
        }

        private void nameContainer_Validating(object sender, CancelEventArgs e)
        {
            string stringRegex = @"^([a-zA-Z .]*)$";
            Regex regex = new Regex(stringRegex);
            string name = nameContainer.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                e.Cancel = true;
                nameContainer.Focus();
                errorProvider1.SetError(nameContainer, "Name should not be left blank");

            } else if (!regex.IsMatch(name))
            {
                e.Cancel = true;
                nameContainer.Focus();
                errorProvider1.SetError(nameContainer, "Name should contain only alphabets");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nameContainer, "");
            }
        }

        private void dateOfBirthContainer_Validating(object sender, CancelEventArgs e)
        {
            bool isValidDateOfBirth = false;
            dateOfBirth = dateOfBirthContainer.Value;
            isValidDateOfBirth = GetAge(dateOfBirth);
            if (isValidDateOfBirth)
            {
                e.Cancel = false;
                errorProvider1.SetError(dateOfBirthContainer, "");
            } else
            {
                e.Cancel = true;
                dateOfBirthContainer.Focus();
                errorProvider1.SetError(dateOfBirthContainer, "Age should be above 18");               
            }
        }

        private bool GetAge(DateTime date)
        {
            bool isAgeValid = false;
            DateTime currentDate = DateTime.Today;
            int currentYear = currentDate.Year;
            int age = (currentYear - date.Year);

            if (age > 18)
             {
                isAgeValid = true;
             }
               
            return isAgeValid;
        }

        private void CreateFresher_Load(object sender, EventArgs e)
        {
            this.ActiveControl = nameContainer;
        }

        private void mobileNumberContainer_Validating(object sender, CancelEventArgs e)
        {
            string stringRegex = @"^([789]\d{9})$";
            Regex regex = new Regex(stringRegex);
            string mobileNumber = mobileNumberContainer.Text;
            if (regex.IsMatch(mobileNumber))
            {
                e.Cancel = false;
                errorProvider1.SetError(mobileNumberContainer, "");
            } else
            {
                e.Cancel = true;
                mobileNumberContainer.Focus();
                errorProvider1.SetError(mobileNumberContainer, "Enter valid mobile number");
            }
        }
    }
}
