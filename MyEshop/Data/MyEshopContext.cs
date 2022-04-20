using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext:DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext>options):base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
