
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Database
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
