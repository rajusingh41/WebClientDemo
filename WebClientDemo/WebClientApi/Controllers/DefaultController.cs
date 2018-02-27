using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClientModel;

namespace WebClientApi.Controllers
{
    public class DefaultController : BaseApiController
    {
        [HttpPost]
        public IHttpActionResult SaveEmployee(Employee model)
        {
            //IEnumerable<string> values;
            //var found = Request.Headers.TryGetValues("Custom", out values);

            //var request = System.Web.HttpContext.Current.Request;

            //var token = request.Headers.GetValues("Custom");

            DemoTest dt = new DemoTest();
            var tt = dt.SaveEmployee(model);

            return Content(HttpStatusCode.OK,"raju");
        }

        [HttpPost]
        public IHttpActionResult SaveMultipleEmployee(EmployeeList model)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult SaveTest(int id, string name)
        {
            return Ok();
        }
    }
}
