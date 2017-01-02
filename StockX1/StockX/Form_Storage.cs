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
    public partial class Form_Storage : Form
    {
        Database db = Database.GetInstance();
        public Form_Storage()
        {
            InitializeComponent();
            Fill_DGV();

        }
        private void Fill_DGV()//Befüllt das DGV mit allen notwendigen Daten
        {
            //DataTable dt = db.CreateDataTable();
            dgv_storeditems.DataSource = db.CreateDataTable();
            dgv_storeditems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Füllt das DGV aus
            dgv_storeditems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//Passt die Breite der Bezeichnungsspalte dem Inhalt(Full Responsive)
            UpdateRowCount();

        }

        private void b_installation_Click(object sender, EventArgs e)
        {
            dgv_storeditems.DataSource = null;
            dgv_storeditems.DataSource = db.CreateCategorieDataTable("Installation");
            UpdateRowCount();
        }

        private void b_sanitaer_Click(object sender, EventArgs e)
        {
            dgv_storeditems.DataSource = null;
            dgv_storeditems.DataSource = db.CreateCategorieDataTable("Sanitär");
            UpdateRowCount();
        }

        private void b_heizung_Click(object sender, EventArgs e)
        {
            dgv_storeditems.DataSource = null;
            dgv_storeditems.DataSource = db.CreateCategorieDataTable("Heizung");
            UpdateRowCount();
        }
        private void UpdateRowCount()//Zeigt die Anzahl der Zeilen in einem Label
        {
            l_RowCount.Text = "Anzahl Zeilen: " + dgv_storeditems.Rows.Count.ToString();
        }
    }
}
