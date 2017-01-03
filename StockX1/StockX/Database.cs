using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;//DLL mit Verweis einbinden
using System.Data;

namespace StockX
{
    class Database
    {
        SQLiteCommand cmd;
        SQLiteConnection con;
        private static Database instance;    
        private Database()//Konstruktor, hier wird Datenbank Verbindung hergestellt
        {
            try
            {
                con = new SQLiteConnection(@"Data Source=Database.db;Version=3;");//Connect Database
                con.Open();
            }
            catch(Exception q)
            {
                System.Windows.Forms.MessageBox.Show("Problem mit Datenbankverbindung: " + q.Message); 
            }     
            finally
            {
                cmd = con.CreateCommand();
            }      
        }
        public static Database GetInstance()//Singelton(Sicherstellen dass nur eine Instanz dieser Klasse existiert)
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public DataTable CreateDataTable()//Hier wird ein Objekt vom Typ DataTable erstellt um das DGV zu befüllen
        {
            cmd.CommandText = "select l.menge, a.Einheit, a.Bezeichnung, a.Preis, a.Rabatt, l.Menge*a.Preis as Gesamtpreis from lager l, artikelstamm a where l.Artikel_ID = a. Artikel_ID order by a.Bezeichnung ASC";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;
            try
            {
                da = new SQLiteDataAdapter(cmd);
            }
            catch (Exception w)
            {
                System.Windows.Forms.MessageBox.Show("Problem mit der Datenabfrage: " + w.Message);
            }
            finally
            {
                da.Fill(dt);               
            }
            return dt;
        }    
        public DataTable CreateCategorieDataTable(string Category)//Hier wird ein Objekt vom Typ DataTable erstellt um das DGV zu befüllen
        {
            cmd.CommandText = "select l.menge, a.Einheit, a.Bezeichnung, a.Preis, a.Rabatt from lager l, artikelstamm a where l.Artikel_ID = a. Artikel_ID and a.Kategorie_ID = (select Kategorie_ID from Kategorie where Bezeichnung = " + '"' + Category + '"' + ") order by a.Bezeichnung ASC";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;
            try
            {
                da = new SQLiteDataAdapter(cmd);
            }
            catch (Exception w)
            {
                System.Windows.Forms.MessageBox.Show("Problem mit der Datenabfrage: " + w.Message);
            }
            finally
            {
                da.Fill(dt);
            }
            return dt;
        }
        public List<string> GetSubCategoryByCategory(string Category)
        {
            cmd.CommandText = "select Bezeichnung from Unterkategorie where Kategorie_ID = (select Kategorie_ID from Kategorie where Bezeichnung = " + '"' + Category + '"' + ") order by Bezeichnung ASC";
            List<string> subcategories = new List<string>();
            SQLiteDataReader reader = null;
            try
            {
               reader = cmd.ExecuteReader();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Problem mit Unterkategorie Abfrage: "+e.Message);
            }
            finally
            {
                while(reader.Read())
                {
                    subcategories.Add(reader["Bezeichnung"].ToString());
                }
                reader.Close();
            }
            return subcategories;
        }
        public void CloseDB()
        {
            con.Close();
        }

    }
}
