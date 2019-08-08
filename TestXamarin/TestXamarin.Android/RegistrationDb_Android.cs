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

using TestXamarin.Contacts.Database;
using TestXamarin.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(RegistrationDb_Android))]
namespace TestXamarin.Droid
{
    public class RegistrationDb_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "ContactsDb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);

            var connection = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            return connection;
        }
    }
}