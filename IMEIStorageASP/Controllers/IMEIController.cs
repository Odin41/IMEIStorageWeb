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
            _Service = new Service("http://127.0.0.1:5000", new System.Net.Http.HttpClient());
        }


        public IActionResult Index()
        {
            var res = _Service.IMEIAllAsync().Result.ToList();
            return View(res);
        }

        [HttpPost]
        public ActionResult AddIMEI(string imei)
        {
            if (string.IsNullOrWhiteSpace(imei))
            {
                return NotFound();
            }
            IMEIModel res = _Service.IMEIAddAsync(imei).Result;
            JsonResult jRes = Json(res);
            return jRes;
        }
    }
}
