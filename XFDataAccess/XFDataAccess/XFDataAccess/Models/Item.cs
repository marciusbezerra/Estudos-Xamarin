using SQLite;

namespace XFDataAccess.Models
{
    //Install-Package sqlite-net-pcl -Version 1.4.118
    public class Item: IObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
