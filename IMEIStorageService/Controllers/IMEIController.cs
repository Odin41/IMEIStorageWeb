using IMEIStorageService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMEIStorageService.Controllers
{
    public class IMEIController
    {
        private DataContext _DataContext;
        public IMEIController(DataContext dataContext)
        {
            _DataContext = dataContext;
        }

        public IEnumerable<IMEIModel> All()
        {
            return _DataContext.Data.AsNoTracking().Where(p=>p.RemovedDate == null);
        }

     
        public IMEIModel Add(string imei, string info)
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
            model.AddedInfo = info;

            _DataContext.Data.Add(model);
            _DataContext.SaveChanges();


            return model;
        }

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
