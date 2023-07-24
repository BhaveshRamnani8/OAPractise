using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class Repository : IRepository
    {
        private readonly OAContext context;
        private DbSet<Employee> entities;
        string errorMessage = string.Empty;

        public Repository(OAContext context)
        {
            this.context = context;
            entities = context.Set<Employee>();
        }

        public void Delete(Employee entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Remove(entity);
            context.SaveChanges();
        }

        public Employee Get(long id)
        {
            return entities.SingleOrDefault(s=> s.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(Employee entity)
        {
            if (entity is null)
                throw new ArgumentNullException("entity");

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Employee entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update (Employee entity)
        {
            if (entity is null)
                throw new ArgumentNullException("entity");

            context.SaveChanges();
        }
    }
}
