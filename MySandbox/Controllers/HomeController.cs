using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MySandbox.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var data = @"search-search-search-product-product-product,7311
search-search-search-product-product-search,2807
search-search-search-product-search-account,145
search-search-search-product-search-end,501
search-search-search-product-search-home,57
search-search-search-product-search-other,16
search-search-search-product-search-product,4559
search-search-search-product-search-search,2030
search-search-search-search-account-account,300
search-search-search-search-account-end,49
search-search-search-search-account-home,16
search-search-search-search-account-other,28
search-search-search-search-account-product,194
search-search-search-search-account-search,51
search-search-search-search-end,1991
search-search-search-search-home-account,14
search-search-search-search-home-end,44
search-search-search-search-home-home,33
search-search-search-search-home-other,5
search-search-search-search-home-product,80
search-search-search-search-home-search,112
search-search-search-search-other-account,1
search-search-search-search-other-end,9
search-search-search-search-other-home,2
search-search-search-search-other-other,26
search-search-search-search-other-product,34
search-search-search-search-other-search,9
search-search-search-search-product-account,295
search-search-search-search-product-end,2112
search-search-search-search-product-home,289
search-search-search-search-product-other,33
search-search-search-search-product-product,3856
search-search-search-search-product-search,2203
search-search-search-search-search-account,241
search-search-search-search-search-end,756
search-search-search-search-search-home,111
search-search-search-search-search-other,43
search-search-search-search-search-product,3125
search-search-search-search-search-search,3600";

            var json = Json(data);
            return json;
        }
    }
}
