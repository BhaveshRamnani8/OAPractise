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
        }

        public Employee? Get(long id)
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
        }        

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update (Employee emp)
        {
            if (emp is null)
                throw new ArgumentNullException("entity");
            var employee = entities.SingleOrDefault(s=> s.Id==emp.Id);

            if (employee == null)
                throw new ArgumentNullException("User not found");

            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.Email = emp.Email;
            employee.Gender = emp.Gender;
            employee.MaritalStatus = emp.MaritalStatus;
            employee.Salary = emp.Salary;
            employee.BirthDate = emp.BirthDate;
            employee.Hobbies = emp.Hobbies;
            employee.Address = emp.Address;
            employee.CountryId = emp.CountryId;
            employee.StateId = emp.StateId;
            employee.CityId = emp.CityId;
            employee.ZipCode = emp.ZipCode;
            employee.Password = emp.Password;
        }
    }
}
