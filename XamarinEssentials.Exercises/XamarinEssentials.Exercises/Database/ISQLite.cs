using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinEssentials.Exercises.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
