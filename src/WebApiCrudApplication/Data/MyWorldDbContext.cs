using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrudApplication.Data.Entities;

namespace WebApiCrudApplication.Data
{
    public class MyWorldDbContext:DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Cake> Cake { get; set; }

    }
}
