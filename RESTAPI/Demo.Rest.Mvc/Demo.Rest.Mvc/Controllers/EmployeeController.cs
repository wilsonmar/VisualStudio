using System.Web.Http;
using Demo.Rest.Mvc.Manager;
using Microsoft.Practices.Unity;

namespace Demo.Rest.Mvc.Controllers
{
    public class EmployeeController : ApiController
    {
        [Dependency]
        public IEmployeeManager EmployeeManager { get; set; }

        // GET http://server:port/api/Employee
        public IHttpActionResult Get()
        {
            return Ok(EmployeeManager.Get());
        }

        //GET http://server:port/api/Employee/1
        public IHttpActionResult Get(string id)
        {
            return Ok(EmployeeManager.Get(id));
        }

        //GET http://server:port/api/Values?param1=1&param2=2
        public IHttpActionResult Get([FromUri] string param1, [FromUri] string param2)
        {
            return Ok(string.Format("received for search : {0}, {1}", param1, param2));
        }

        // POST http://server:port/api/Employee/1
        // header -> Content-Type : application/json
        // data { "firstName": "John" } 
        public IHttpActionResult Post(string id, [FromBody] dynamic data)
        {
            EmployeeManager.Update(id, data);
            return Ok(EmployeeManager.Get(id));
        }

        // PUT http://server:port/api/Employee/1
        // header -> Content-Type : application/json
        // data {"firstName": "x" , "lastName" : "y"}
        public IHttpActionResult Put([FromBody] dynamic data)
        {
            EmployeeManager.Create(data.firstName.Value, data.lastName.Value);
            return Ok(EmployeeManager.Get());
        }

        // DELETE http://server:port/api/Employee/1
        public IHttpActionResult Delete(string id)
        {
            EmployeeManager.Delete(id);
            return Ok(EmployeeManager.Get());
        }
    }
}