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
using XamarinExercise.Database;
using XamarinExercise.Droid;
using XamarinExercise.Models;

[assembly: Xamarin.Forms.Dependency(typeof(ContactsDb_Droid))]
namespace XamarinExercise.Droid
{
    public class ContactsDb_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "ContactsDb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); //Documents folder
            var path = Path.Combine(documentsPath, sqliteFileName);

            var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            return conn;
        }
    }
}