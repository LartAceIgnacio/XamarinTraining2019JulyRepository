using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace TestXamarin.Contacts.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
