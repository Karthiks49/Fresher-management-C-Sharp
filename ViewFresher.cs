using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshersInfo
{
    public partial class ViewFresher : Form
    {
        public ViewFresher()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            FresherManagement fresherManagement = new FresherManagement();
            listView.DataSource = fresherManagement.GetFreshers();
        }

        private void listView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreateFresher createFresher = new CreateFresher();
            createFresher.row= e.RowIndex;
            
            string name = listView.Rows[e.RowIndex].Cells[0].Value.ToString();
            createFresher.name = name;
            DateTime dateOfBirth = DateTime.Parse(listView.Rows[e.RowIndex].Cells[1].Value.ToString());
            string mobileNumber = listView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string address = listView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string qualification = listView.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            createFresher.GetValues(name, dateOfBirth, mobileNumber, address, qualification);
            createFresher.ShowDialog();
        }
    }
}
