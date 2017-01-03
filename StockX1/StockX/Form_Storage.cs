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
        Database db = Database.GetInstance();//Instanzieren mit Singelton
        private SelectedCategory selectedCategory;
        private List<string> subcategories;
        public Form_Storage()
        {
            InitializeComponent();
            Fill_DGV();//Mit allen Daten befüllen

        }
        private void Fill_DGV()//Befüllt das DGV mit allen notwendigen Daten
        {
            dgv_storeditems.DataSource = db.CreateDataTable();//Gibt Datatable mit allen Werten zurück
            dgv_storeditems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Füllt das DGV aus
            dgv_storeditems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//Passt die Breite der Bezeichnungsspalte dem Inhalt(Full Responsive)
            UpdateRowCount();

        }
        private void b_installation_Click(object sender, EventArgs e)
        {
            selectedCategory = new SelectedCategory() { maincategorie = "Installation", subcategorie = null };
            MainCategorySelection();
           
        }//Button Installtion Klick Event (gibt "Installation weiter")
        private void b_sanitaer_Click(object sender, EventArgs e)
        {
            selectedCategory = new SelectedCategory() { maincategorie = "Sanitär", subcategorie = null };
            MainCategorySelection();
        }//gibt "Sanitär" weiter
        private void b_heizung_Click(object sender, EventArgs e)
        {
            selectedCategory = new SelectedCategory() { maincategorie = "Heizung", subcategorie = null };
            MainCategorySelection();
        }//gibt "Heizung" weiter
        private void UpdateRowCount()//Zeigt die Anzahl der Zeilen in einem Label
        {
            l_RowCount.Text = "Anzahl Zeilen: " + dgv_storeditems.Rows.Count.ToString();
        }
        private void MainCategorySelection()//wird nach dem Klick Events der Hauptkategorien aufgerufen um Code Inkonsistenz zu vermeiden (zweimal der gleiche Code)
        {
            dgv_storeditems.DataSource = null;//DGV Leeren
            dgv_storeditems.DataSource = db.CreateCategorieDataTable(selectedCategory.maincategorie);
            UpdateRowCount();
            Fill_SubCategory_LB();
        }

        private void Fill_SubCategory_LB()
        {
            subcategories = db.GetSubCategoryByCategory(selectedCategory.maincategorie);
            lb_subcategories.DataSource = subcategories;

        }

        private void lb_subcategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
