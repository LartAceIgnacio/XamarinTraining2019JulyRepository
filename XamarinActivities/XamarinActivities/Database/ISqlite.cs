using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinActivities.Database
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
