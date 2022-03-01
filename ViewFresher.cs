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

        private void update_Click(object sender, EventArgs e)
        {
            CreateFresher createFresher = new CreateFresher();
            int index = listView.CurrentCell.RowIndex;
            createFresher.row = index;
            createFresher.GetValues(index);
            createFresher.ShowDialog();
            listView.Refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            CreateFresher createFresher = new CreateFresher();
            int index = listView.CurrentCell.RowIndex;
            createFresher.DeleteFresher(index);
        }
    }
}
