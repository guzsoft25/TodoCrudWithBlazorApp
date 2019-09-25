using CrudWithBlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithBlazorApp.Data
{
    public class DatabaseDataContext:DbContext
    {
        public DatabaseDataContext(DbContextOptions<DatabaseDataContext> Options)
            :base(Options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
