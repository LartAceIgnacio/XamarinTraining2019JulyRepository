using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace App3.SQLite
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
