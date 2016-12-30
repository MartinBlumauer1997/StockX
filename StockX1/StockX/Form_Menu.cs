using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockX
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();


           
        }


        private void b_bill_Click(object sender, EventArgs e)
        {
            Form_Bill form_bill = new Form_Bill();
            form_bill.ShowDialog();
        }

        private void b_buildingsite_Click(object sender, EventArgs e)
        {
            Form_BuildingSite form_buildingSite = new Form_BuildingSite();
            form_buildingSite.ShowDialog();
        }

        private void b_storage_Click(object sender, EventArgs e)
        {
            Form_Storage form_stock = new Form_Storage();
            form_stock.ShowDialog();
        }

        private void b_settings_Click(object sender, EventArgs e)
        {
            Form_Settings form_settings = new Form_Settings();
            form_settings.ShowDialog();
        }

        private void b_bill_Click_1(object sender, EventArgs e)
        {

            Form_Bill form_bill = new Form_Bill();
            form_bill.ShowDialog();
        }
            
    }
}
