using SQLite;
using System.IO;
using Xamarin.Forms;
using XFDataAccess.iOS;

[assembly: Dependency(typeof(DatabaseIOS))]
namespace XFDataAccess.iOS
{
    public class DatabaseIOS: IDatabase
    {
        public DatabaseIOS() { }

        //Install-Package sqlite-net-pcl -Version 1.4.118
        public SQLiteConnection DBConnect()
        {
            var filename = "data.db3";
            var folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryFolder = Path.Combine(folder, "..", "Library");
            var path = Path.Combine(libraryFolder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}