using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMEIStorageASP
{
    public class IMEIController : Controller
    {
        private Service _Service;


        public IMEIController()
        {
            _Service = new Service("http://dswork:5000", new System.Net.Http.HttpClient());
        }


        public IActionResult Index()
        {
            // List<IMEIModel> models = _Service.    

            var res = _Service.AllAsync().Result.ToList();

            return View( res);
        }

        public ActionResult IMEIAdd()
        {
            return PartialView("_IMEIAddForm");
        }
    }
}
