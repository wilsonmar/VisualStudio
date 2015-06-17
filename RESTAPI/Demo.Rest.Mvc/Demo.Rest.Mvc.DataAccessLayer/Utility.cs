using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Rest.Mvc.Common.Model;

namespace Demo.Rest.Mvc.DataAccessLayer
{
    class Utility
    {
        internal static Employee GetEmployee(string id, string firstName, string lastName)
        {
            return new Employee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}
