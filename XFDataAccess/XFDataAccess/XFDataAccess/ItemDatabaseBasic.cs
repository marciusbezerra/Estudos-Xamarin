using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XFDataAccess.Models;

namespace XFDataAccess
{
    public class ItemDatabaseGeneric
    {
        protected static object locker = new object();
        protected SQLiteConnection database;

        public ItemDatabaseGeneric()
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            database.CreateTable<Item>();
            database.CreateTable<Person>();
        }

        public IEnumerable<T> GetObjects<T>() where T: IObject, new()
        {
            lock (locker)
            {
                return (from i in database.Table<T>() select i).ToList();
            }
        }

        public IEnumerable<T> GetFirstObjects<T>() where T: IObject, new()
        {
            lock(locker)
            {
                return database.Query<T>("SELECT * FROM Item WHERE Name = 'First'");
            }
        }

        public T GetObject<T>(int id) where T: IObject, new()
        {
            lock(locker)
            {
                return database.Table<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveObject<T>(T obj) where T: IObject
        {
            lock (locker)
            {
                if (obj.Id != 0)
                {
                    database.Update(obj);
                    return obj.Id;
                } else
                {
                    return database.Insert(obj);
                }
            }
        }

        public int DeleteObject<T>(int id) where T: IObject, new()
        {
            return database.Delete<T>(id);
        }

        public void DeleteAllObjects<T>() where T: IObject, new()
        {
            database.DropTable<T>();
            database.CreateTable<T>();
        }

    }
}
