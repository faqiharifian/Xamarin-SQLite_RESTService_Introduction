using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.IO;
using Xamarin.Forms;
using Modul5_Practice.Droid;
using Modul5_Practice;

[assembly: Dependency(typeof(SqliteService))]
namespace Modul5_Practice.Droid
{
    class SqliteService : ISQLite
    {
        public SqliteService() { }

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Pegawai.db3";
            string documentsPath =
                   Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}