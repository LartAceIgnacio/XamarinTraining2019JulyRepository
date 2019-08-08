using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinExercise.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
