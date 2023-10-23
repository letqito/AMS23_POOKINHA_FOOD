using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_CAROUSEL.Models;
using Microsoft.EntityFrameworkCore;

namespace AMS23_CAROUSEL.Data.Repository
{
    public class ApplicationDataContext : DbContext
    {
        protected ApplicationDataContext(DbContextOptions<ApplicationDataContext>options): base(options){}
        public DbSet<CategoryModel> Category {get;set;}
    }
}