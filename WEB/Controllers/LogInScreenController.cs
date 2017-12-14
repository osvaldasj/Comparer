using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class LogInScreenController : Controller
    {
        // GET: LogInScreen
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Http.RoutePrefix("login")]
        public class LogInController : ApiController
        {
            private Random _random = new Random();
            [System.Web.Http.HttpPost]
            [System.Web.Http.Route("register")]
            public IHttpActionResult Register([FromBody] string details)
            {
                var UP = details.Split('$');
                string newID = UP[0].Substring(0, 4) + UP[1].Substring(0, 4) + _random.Next(0, 9999).ToString("D4");
                using (var db = new ComparerModel())
                {
                    var x = new Customer() { Name = UP[0], Password = UP[1], Spent = 0, CardID = newID };
                    db.Customers.Add(x);
                    db.SaveChanges();
                }
                return Ok("success");
            }

            [System.Web.Http.HttpPost]
            [System.Web.Http.Route("login")]
            public IHttpActionResult Login([FromBody] string details)
            {
                bool exist = false;
                float spent = 0;
                var UP = details.Split('$');
                string custID = "";
                using (var db = new ComparerModel())
                {
                    var cust = db.Customers.ToList();
                    foreach(Customer x in cust)
                    {
                        if (UP[0] == x.Name && UP[1] == x.Password)
                        {
                            exist = true;
                            spent = x.Spent;
                            custID = x.CardID;
                        }

                    }
                }
                if (exist)
                    return Ok(custID + "success" + spent.ToString());
                else
                    return Ok("failure");
            }
        }
    }
}