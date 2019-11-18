using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DataGridViewTest
{
    public partial class Form1 : Form
    {
        NorthwindDB db = new NorthwindDB();

        public Form1()
        {
            InitializeComponent();
            customerBindingSource.DataSource = db.Customers.ToList(); // Local.ToBindingList();
            // db.Customers.Load();

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            customerDataGridView.EndEdit();
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
