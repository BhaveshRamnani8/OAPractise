using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(long id);
        void Insert(Employee emp);
        void Update(Employee emp);
        void Delete(Employee emp);
        void Remove(Employee emp);
        void SaveChanges();
    }
}
