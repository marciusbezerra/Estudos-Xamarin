using System.IO;
using SQLite;
using Xamarin.Forms;
using XFDataAccess.Droid;

[assembly: Dependency(typeof(DatabaseAndroid))]
namespace XFDataAccess.Droid
{
    public class DatabaseAndroid: IDatabase
    {
        public DatabaseAndroid() { }

        //Install-Package sqlite-net-pcl -Version 1.4.118
        public SQLiteConnection DBConnect()
        {
            var filename = "data.db3";
            var folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}