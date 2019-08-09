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
using XamarinActivities.Droid.Util;
using XamarinActivities.Util;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteDb))]
namespace XamarinActivities.Droid.Util
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, "ContactsDb.db3");

            return new SQLiteConnection(path);
        }
    }
}