using System.Web.Http;
using Demo.Rest.Mvc.Manager;
using Microsoft.Practices.Unity;

namespace Demo.Rest.Mvc.Controllers
{
    public class EmployeeController : ApiController
    {
        [Dependency]
        public IEmployeeManager EmployeeManager { get; set; }

        /// <summary>
        /// GET : http://server:port/api/Employee
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            return Ok(EmployeeManager.Get());
        }

        /// <summary>
        /// GET : http://server:port/api/Employee/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(string id)
        {
            return Ok(EmployeeManager.Get(id));
        }

        /// <summary>
        /// GET : http://server:port/api/Values?param1=1&param2=2
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public IHttpActionResult Get([FromUri] string param1, [FromUri] string param2)
        {
            return Ok(string.Format("received for search : {0}, {1}", param1, param2));
        }

        /// <summary>
        /// POST : http://server:port/api/Employee/1
        /// header -> Content-Type : application/json
        /// data { "firstName": "John" } 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public IHttpActionResult Post(string id, [FromBody] dynamic data)
        {
            EmployeeManager.Update(id, data);
            return Ok(EmployeeManager.Get(id));
        }

        /// <summary>
        /// PUT : http://server:port/api/Employee/1
        /// header -> Content-Type : application/json
        /// data {"firstName": "x" , "lastName" : "y"}
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IHttpActionResult Put([FromBody] dynamic data)
        {
            EmployeeManager.Create(data.firstName.Value, data.lastName.Value);
            return Ok(EmployeeManager.Get());
        }

        /// <summary>
        /// DELETE : http://server:port/api/Employee/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(string id)
        {
            EmployeeManager.Delete(id);
            return Ok(EmployeeManager.Get());
        }
    }
}