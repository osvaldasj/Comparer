using WEB.ComparisonEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace WEB.Controllers
{
    public class ShopCompareController : Controller
    {
        [System.Web.Http.RoutePrefix("api")]

        public class TestController : ApiController
        {
            // GET: ShopCompare
            [System.Web.Http.HttpGet]
            [System.Web.Http.Route("getdatabases")]
            public IHttpActionResult GetDatabases()
            {
                string databases = "";

                return Ok(databases);
            }

            [System.Web.Http.HttpGet]
            [System.Web.Http.Route("testmethod")]
            public IHttpActionResult testmethod()
            {
                string databases = "test method";

                return Ok(databases);
            }

            [System.Web.Http.HttpPost]
            [System.Web.Http.Route("compareshops")]
            public IHttpActionResult CompareShops([FromBody] string receivedString)
            {
                CompareShops x = new CompareShops(new WriteToFile());
                List<FromFileToStruct.Product> curr = FromFileToStruct.MakeProductList(receivedString);
                string a = x.CompareResults(curr);
                UpdateDababase.UpdateDatabase(curr);
                return Ok(a);
            }


        }
    }
}