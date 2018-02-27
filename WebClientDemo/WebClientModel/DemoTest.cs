using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientModel
{
    public class DemoTest
    {
        public object SaveEmployee(Employee model)
        {
            IEnumerable<string> values;
           // var found = Request.Headers.TryGetValues("Custom", out values);


            var token = request.Headers.GetValues("Custom").First();
            return "";
        }
    }
}
