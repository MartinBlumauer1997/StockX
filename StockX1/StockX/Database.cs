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
        public static Database instance;
        SQLiteCommand cmd;
        SQLiteConnection con;
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
        public DataTable CreateDataTable()//Hier wird ein Objekt vom Typ DataTable erstellt um das DGV zu befüllen
        {
            cmd.CommandText = "select l.menge, a.Einheit, a.Bezeichnung, a.Preis, a.Rabatt, l.Menge*a.Preis as Gesamtpreis from lager l, artikelstamm a where l.Artikel_ID = a. Artikel_ID";
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static Database GetInstance()//Singelton(Sicherstellen dass nur eine Instanz dieser Klasse existiert)
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
    }
}
