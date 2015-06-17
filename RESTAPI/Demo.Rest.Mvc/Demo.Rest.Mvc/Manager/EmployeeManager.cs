using System.Collections.Generic;
using Demo.Rest.Mvc.Common.Model;
using Demo.Rest.Mvc.DataAccessLayer;
using Microsoft.Practices.Unity;

namespace Demo.Rest.Mvc.Manager
{
    public interface IEmployeeManager
    {
        IDataProvider DataProvider { get; set; }
        IEnumerable<Employee> Get();
        Employee Get(string id);
        void Create(string firstName, string lastName);
        void Update(string id, dynamic data);
        void Delete(string id);
    }
    public class EmployeeManager : IEmployeeManager
    {
        [Dependency]
        public IDataProvider DataProvider { get; set; }


        public IEnumerable<Employee> Get()
        {
            return DataProvider.GetAll();
        }

        public Employee Get(string id)
        {
            return DataProvider.Get(id);
        }

        public void Create(string firstName, string lastName)
        {
            DataProvider.New(firstName, lastName);
        }

        public void Update(string id, dynamic data)
        {
            string firstName = data.firstName == null ? null : data.firstName.Value;
            string lastName = data.lastName == null ? null : data.lastName.Value;
            
            DataProvider.Update(id, firstName, lastName);
        }

        public void Delete(string id)
        {
            DataProvider.Delete(id);
        }
    }
}