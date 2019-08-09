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
using App3.SQLite;

using SQLite;
using SQLitePCL;
using App3.Droid;

[assembly : Xamarin.Forms.Dependency(typeof(ContactDb_Android))]
namespace App3.Droid
{
    public class ContactDb_Android : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ContactDb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            return conn;
        }
    }
}