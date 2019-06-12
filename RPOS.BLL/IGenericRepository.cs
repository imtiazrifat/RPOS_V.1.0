using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOS.BLL
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectedById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        //-----------
        IEnumerable<T> SelectSpecificColumnsList(string sqlQuery);
    }
}
