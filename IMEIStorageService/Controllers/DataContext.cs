using IMEIStorageService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMEIStorageService.Controllers
{
    public class DataContext : DbContext
    {
        public DbSet<IMEIModel> Data { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
