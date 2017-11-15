using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using static Google.Apis.Requests.BatchRequest;
using System.IO;
using System.Collections.Specialized;
using WebService.Models;
using System.Web.UI.WebControls;

namespace WebService.Controllers
{
    [RoutePrefix("api/MyTest")]

    public class TestController : ApiController
    {

        [HttpGet]
        [Route("computeaddition/{num1:int}/{num2:int}")]
        public IHttpActionResult ComputeAddition(int num1, int num2)
        {
            return Ok(num1 + num2);
        }

        [HttpPost]
        [Route("computeMulti")]
        public IHttpActionResult ComputeMulti([FromBody] string receivedString)
        {   
            
            return Ok(receivedString);
        }
    }
}
