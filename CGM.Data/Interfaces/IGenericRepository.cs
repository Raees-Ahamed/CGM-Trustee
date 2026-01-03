using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CGM.Data.Interfaces
{
    public interface IGenericRepository
    {
        T GetById<T>(int id);
        IEnumerable<T> GetAll<T>();
        IEnumerable<T> Find<T>(Expression<Func<T, bool>> expression); 

    }
}
