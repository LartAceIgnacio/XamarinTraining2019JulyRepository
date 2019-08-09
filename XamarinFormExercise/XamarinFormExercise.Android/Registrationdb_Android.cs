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
using XamarinFormExercise.Database;
using XamarinFormExercise.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Registrationdb_Android))]
namespace XamarinFormExercise.Droid
{
    public class Registrationdb_Android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteContact = "Contactdb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteContact);
            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            return conn;
        }

      
    }
}