using SQLite;

namespace XFDataAccess
{
    public class Person : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }
    }
}