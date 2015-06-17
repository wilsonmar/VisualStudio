using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Demo.Rest.Mvc.Common.Model;
using Demo.Rest.Mvc.Controllers;
using Demo.Rest.Mvc.DataAccessLayer;
using Demo.Rest.Mvc.Manager;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Demo.Rest.Mvc.TestHarness.Integration
{
    [TestFixture]
    public class Test
    {
        const string FakeFirstName = "fakeFirstName";
        const string FakeLastName = "fakeLastName";

        private UnityContainer _container;
        private EmployeeController _controller;
        

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _container = new UnityContainer();

            _container.RegisterType<IDataProvider, DataProvider>();
            _container.RegisterType<IEmployeeManager, EmployeeManager>();
            
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            
        }

        [SetUp]
        public void Setup()
        {
            _controller = _container.Resolve<EmployeeController>();
        }

        [TearDown]
        public void Teardown() {}

        [Test]
        public void CRUD_Should_Behave_As_Expected()
        {
            Get_Returns_All_Data();
            Get_Returns_Data_With_Id();
            Put_Creates_New_Data();
            Post_Updates_Employee_Properties();
            Delete_Removes_Data();
        }

        public void Get_Returns_All_Data()
        {
            var data =  _controller.Get() as OkNegotiatedContentResult<IEnumerable<Employee>>;
            Assert.IsNotNull(data.Content);
        }

        public void Get_Returns_Data_With_Id()
        {
            const string id = "1";
            var data = _controller.Get(id) as OkNegotiatedContentResult<Employee>;
            Assert.AreEqual(id, data.Content.Id);
        }

        public void Put_Creates_New_Data()
        {
            var fakeEmployee = GetJsonEmployee(FakeFirstName, FakeLastName);
            var jobj = JObject.FromObject(fakeEmployee);
            var response = _controller.Put(jobj) as OkNegotiatedContentResult<IEnumerable<Employee>>;
           
            Assert.IsTrue(response.Content.Any(e => e.FirstName.Equals(FakeFirstName)));
        }

        public void Post_Updates_Employee_Properties()
        {
            var data = GetJsonEmployee(FakeFirstName, null);
            var response = _controller.Post("1", data) as OkNegotiatedContentResult<Employee>;
            Assert.AreEqual( FakeFirstName,response.Content.FirstName);
            Assert.IsNotNull(response.Content.LastName);
        }

        public void Delete_Removes_Data()
        {
            const string id = "1";
            var response = _controller.Delete(id) as OkNegotiatedContentResult<IEnumerable<Employee>>;
            Assert.IsFalse(response.Content.Any(e => e.Id.Equals(id)));
        }

        private static JObject GetJsonEmployee(string firstName, string lastName)
        {
            var fakeEmployee = new JObject();
            fakeEmployee["firstName"] = firstName;
            fakeEmployee["lastName"] = lastName;
            return fakeEmployee;
        }
    }
}
