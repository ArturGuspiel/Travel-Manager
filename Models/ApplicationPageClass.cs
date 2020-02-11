using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travel_Manager.Models;

namespace Travel_Manager.Models
{
    public class ApplicationPageClass:DbContext
    {

        public ApplicationPageClass(DbContextOptions<ApplicationPageClass> options) : base(options)
        {

        }
        public DbSet<AddPage> Posts { get; set; }
    }
}
