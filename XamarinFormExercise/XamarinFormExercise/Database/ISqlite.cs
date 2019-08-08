using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormExercise.Database
{
   public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
