using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        T Update(int id, T category);
        bool Delete(T entity);
    }
}
