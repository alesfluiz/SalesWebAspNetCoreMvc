using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebAspNet.Models;

namespace ProjectWebAspNet.Data
{
    public class ProjectWebAspNetContext : DbContext
    {
        public ProjectWebAspNetContext (DbContextOptions<ProjectWebAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectWebAspNet.Models.Department> Department { get; set; }
    }
}
