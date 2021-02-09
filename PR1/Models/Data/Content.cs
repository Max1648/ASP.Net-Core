using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PR1.Models;

namespace PR1.Models.Data
{
    public class Content : DbContext
    {
        public Content(DbContextOptions<Content> options)
           : base(options)
        {
        }

        public DbSet<Task> Task { get; set; }
    }
}
