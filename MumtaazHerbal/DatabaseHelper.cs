using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace MumtaazHerbal
{
    class DatabaseHelper
    {
        //Database File name
        public string DatabaseName = "Mumtaaz1db.db";

        public string GetConnection()
        {
            return @"Data Source=" + DatabaseName + "; Version=3";
        }

        public void CreateDatabase()
        {
            using(SQLiteConnection con = new SQLiteConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand();

            }
            {

            }
        }
    }
}
