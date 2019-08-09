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
using XamarinExcercise.Db;
using XamarinExcercise.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ContactDb_Android))]
namespace XamarinExcercise.Droid
{
    public class ContactDb_Android : ISqlite
    {
        public SQLiteConnection GetConnection() 
        {
            var sqliteFileName = "UserDb.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            return conn;
        }


    }
}