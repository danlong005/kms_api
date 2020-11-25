using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kms_api.Models
{
    public class KMSDBContext : DbContext
    {
        public KMSDBContext(DbContextOptions<KMSDBContext> options) : base(options) {}

        public DbSet<Congregation> Congregations { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Part> Parts { get; set; }
    }
}
