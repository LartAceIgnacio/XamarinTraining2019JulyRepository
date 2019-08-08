using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XAML.Database
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
