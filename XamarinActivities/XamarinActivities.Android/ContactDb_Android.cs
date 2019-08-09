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
using XamarinActivities.Database;
using XamarinActivities.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ContactDb_Android))]
namespace XamarinActivities.Droid
{
    public class ContactDb_Android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "ContactzDb.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);

            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite |
                                            SQLiteOpenFlags.Create |
                                            SQLiteOpenFlags.SharedCache);

            return conn;
        }
    }
}