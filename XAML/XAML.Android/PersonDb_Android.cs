using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XAML.Database;
using XAML.Droid;
[assembly: Xamarin.Forms.Dependency(typeof(PersonDb_Android))]
namespace XAML.Droid
{
    class PersonDb_Android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "PersonDb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);

            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            return conn;
        }
    }
}