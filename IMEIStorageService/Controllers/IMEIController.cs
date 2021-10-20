using IMEIStorageService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMEIStorageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMEIController : ControllerBase
    {
        private DataContext _DataContext;
        public IMEIController(DataContext dataContext)
        {
            _DataContext = dataContext;
        }

        [HttpGet("All")]
        public IEnumerable<IMEIModel> Get()
        {
            return _DataContext.Data.Where(p=>p.RemovedDate == null);
        }

        [HttpPost("Add/{imei}")]
        public IMEIModel Post(string imei)
        {
            if (string.IsNullOrWhiteSpace(imei))
            {
                throw new ArgumentException("IMEI can not be null or empty.");
            }

            imei = imei.Trim().ToUpper();

            if (_DataContext.Data.Any(p=>p.IMEI == imei))
            {
                throw new Exception("IMEI exists.");
            }


            IMEIModel model = new IMEIModel();
            model.IMEI = imei;
            model.AddedDate = DateTime.Now;
            model.AddedInfo = $"Address: {Request.HttpContext.Connection.RemoteIpAddress}:{Request.HttpContext.Connection.RemotePort}";

            _DataContext.Data.Add(model);
            _DataContext.SaveChanges();


            return model;
        }

        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            IMEIModel model = _DataContext.Data.FirstOrDefault(p => p.Id == id);
            if(model != null)
            {
                _DataContext.Data.Remove(model);
                _DataContext.SaveChanges();
            }
        }
    }
}
