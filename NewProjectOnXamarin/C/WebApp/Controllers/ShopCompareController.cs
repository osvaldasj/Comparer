using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.ComparisonEngine;

namespace WebApp.Controllers
{
    public class ShopCompareController : ApiController
    {
        [RoutePrefix("api")]

        public class TestController : ApiController
        {
            [HttpGet]
            [Route("getdatabases")]
            public IHttpActionResult GetDatabases()
            {
                string databases = "";

                return Ok(databases);
            }

            [HttpPost]
            [Route("compareshops")]
            public IHttpActionResult CompareShops([FromBody] string receivedString)
            {
                CompareShops x = new CompareShops();
                string a = x.CompareResults(receivedString);

                return Ok(a);
            }
        }
    }
}
