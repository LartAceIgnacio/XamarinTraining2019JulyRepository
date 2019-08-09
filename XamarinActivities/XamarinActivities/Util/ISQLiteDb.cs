using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinActivities.Util
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
    }
}
