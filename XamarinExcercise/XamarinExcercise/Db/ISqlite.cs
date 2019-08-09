using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;

namespace XamarinExcercise.Db
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}