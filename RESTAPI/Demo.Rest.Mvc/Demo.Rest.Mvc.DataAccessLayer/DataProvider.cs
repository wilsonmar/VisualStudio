using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using Demo.Rest.Mvc.Common.Model;

namespace Demo.Rest.Mvc.DataAccessLayer
{
    public interface IDataProvider
    {
        Employee Get(string id);
        IEnumerable<Employee> GetAll();
        void Update(string id, string firstName = null, string lastName = null);
        void New(string firstName, string lastName);
        void Delete(string id);
    }

    public class DataProvider :IDataProvider
    {
        public static readonly List<Employee> DataStore = new List<Employee>
        {
            Utility.GetEmployee("1", "John", "Doe"),
            Utility.GetEmployee("2", "Jane", "Doe"),
            Utility.GetEmployee("3", "Jim", "Doe"),
        };

        public Employee Get(string id)
        {
            return GetAll().First(e => e.Id.Equals(id));
        }

        public IEnumerable<Employee> GetAll()
        {
            return DataStore;
        }

        public void Update(string id, string firstName = null, string lastName = null)
        {
            var employee = Get(id);
            if (!string.IsNullOrEmpty(firstName))
            {
                employee.FirstName = firstName;
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                employee.LastName = lastName;
            }
        }

        public void New(string firstName, string lastName)
        {
            DataStore.Add(Utility.GetEmployee(Guid.NewGuid().ToString(), firstName, lastName));
        }

        public void Delete(string id)
        {
            DataStore.RemoveAll(e => e.Id.Equals(id));
        }
    }
}
