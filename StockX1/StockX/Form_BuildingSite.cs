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

    public partial class Form_BuildingSite : Form
    {

        public Form_BuildingSite()
        {
            InitializeComponent();
            cb_BuildingSites.SelectedIndex = 0;

            
            //dgv_delivered.DefaultCellStyle.BackColor = Color.LightGreen;
        }

        //Name wird in die TextBox eingegeben und wir über den Button in die ComboBox gespeichert
        private void b_createNewBuildingSite_Click(object sender, EventArgs e)
        {
            cb_BuildingSites.Items.Add(tb_NewBuildingSite.Text);
            //Speichern danach sonst is wieder weg
        }
    }
}
