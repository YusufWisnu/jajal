using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MumtaazHerbal.Function
{
    public class DbHelper
    {
        //get connectionstring
        public string ConnectionString {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
            set
            {
                Properties.Settings.Default.ConnectionString = value;
            }
        }

        public string Datasource
        {
            get
            {
                return Properties.Settings.Default.DataSource;
            }
            set
            {
                Properties.Settings.Default.DataSource = value;
            }
        }

    }
}
