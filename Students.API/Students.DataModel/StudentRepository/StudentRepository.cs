using MongoDB.Driver;
using Students.DataModel.Models;

namespace Students.DataModel.StudentRepository
{
    public class StudentRepository<T> where T : class
    {
        private IMongoDatabase _database;

        private string _tableName;

        private IMongoCollection<T> _collection;

        public StudentRepository(IMongoDatabase db, string tblName)
        {
            _database = db;
            _tableName = tblName;
            _collection = _database.GetCollection<T>(tblName);
        }

        //public T Get(int i)
        //{
            
        //}
    }
}
