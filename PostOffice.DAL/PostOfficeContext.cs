using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.DAL
{
    public class PostOfficeContext : DbContext
    {
        public DbSet<Domain.Entities.Service> Services { get; set; }
        public DbSet<Domain.Entities.ServiceAttribute> ServiceAttributes { get; set; }
    }
}