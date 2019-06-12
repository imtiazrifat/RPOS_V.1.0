using RPOS.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;



namespace RPOS.BLL
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly RposEntities _db;
        private readonly DbSet<T> _aTable;

        public GenericRepository(RposEntities db)
        {
            _db = db;
            _aTable = _db.Set<T>();
        }
        public GenericRepository()
        {
            _db = new RposEntities();
            _aTable = _db.Set<T>();
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<T> SelectAll()
        {

            return _aTable.ToList();
        }

        public T SelectedById(object id)
        {
            return _aTable.Find(id);
        }

        public void Insert(T obj)
        {
            _aTable.Add(obj);
        }

        public void Update(T obj)
        {
            _aTable.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T find = _aTable.Find(id);
            _aTable.Remove(find);
        }

        public void Save()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<T> SelectSpecificColumnsList(string sqlQuery)
        {
            var anonymousList = _db.Database.SqlQuery<T>(sqlQuery).ToList();
            return anonymousList;
        }
    }
}
