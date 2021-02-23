using Microsoft.EntityFrameworkCore;
using skivor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skivor.Data
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options)
        {

        }
        
        public DbSet<Record> Record { get; set; }
        public DbSet<Artist> Artist { get; set; }
    }
}
