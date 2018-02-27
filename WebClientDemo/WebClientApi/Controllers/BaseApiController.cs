using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClientApi.Models;

namespace WebClientApi.Controllers
{
    public class BaseApiController : ApiController
    {
        protected string domainCode;
        public BaseApiController()
        {

            //var request = System.Web.HttpContext.Current.Request;

            //var token = request.Headers.GetValues("Custom");

        }
       

    }
}
