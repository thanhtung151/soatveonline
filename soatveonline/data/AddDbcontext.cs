using Microsoft.EntityFrameworkCore;
using soatveonline.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soatveonline.data
{
    public class AddDbcontext : DbContext
    {
        public AddDbcontext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<news> 
    }
}
