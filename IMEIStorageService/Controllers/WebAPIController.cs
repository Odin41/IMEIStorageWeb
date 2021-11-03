using IMEIStorageService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMEIStorageService.Controllers
{
    [Route("api")]
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        private IMEIController _IMEIController;

        public WebAPIController(DataContext dataContext)
        {
            _IMEIController = new IMEIController(dataContext);
        }


        [HttpGet("IMEIAll")]
        public IEnumerable<IMEIModel> IMEIAll()
        {
            return _IMEIController.All();
        }


        [HttpPost("IMEIAdd/{imei}")]
        public IMEIModel IMEIAdd(string imei)
        {
            return _IMEIController.Add(imei, $"Address: {Request.HttpContext.Connection.RemoteIpAddress}:{Request.HttpContext.Connection.RemotePort}");
        }

        [HttpDelete("IMEIDelete/{id}")]
        public void IMEIDelete(int id)
        {
            _IMEIController.Delete(id);
        }
    }
    
}
