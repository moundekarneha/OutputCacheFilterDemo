using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheFilterDemo.Controllers
{
    //[OutputCache(Duration = 20)]
    public class DemoController : Controller
    {
        // GET: Demo
        //time in se    cond
        // [OutputCache(Duration = 20)]
       // [Outp+utCache(Location = System.Web.UI.OutputCacheLocation.Any,Duration =20)]
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Client,Duration =20)]
        public ActionResult GetData()
        {

            return View();
        }
    }
}