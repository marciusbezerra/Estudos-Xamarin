using SQLite;

namespace XFDataAccess
{
    public interface IDatabase
    {
        SQLiteConnection DBConnect();
    }
}
