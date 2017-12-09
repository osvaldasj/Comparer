using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class DatabaseGenController : Controller
    {
        [System.Web.Http.RoutePrefix("database")]
        public class DatabaseController : ApiController
        {
            [System.Web.Http.HttpGet]
            [System.Web.Http.Route("generateDatabase")]
            public IHttpActionResult GenerateDatabase()
            {
                using (var db = new ComparerModel())
                {
                    var productA = new Product() { Id = 5, Name = "Jogurtas", Price = 1.57f, Date = DateTime.Now, Accept = false };
                    var productB = new Product() { Id = 6, Name = "Batonas", Price = 10.97f, Date = DateTime.Now, Accept = false };
                    db.Products.Add(productA);
                    db.Products.Add(productB);
                    db.SaveChanges();
                    
                }
                return Ok("success");
            }
        }
    }
}