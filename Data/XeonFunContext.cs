using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XeonFun.Models;

namespace XeonFun.Data
{
    public class XeonFunContext : DbContext
    {
        public XeonFunContext (DbContextOptions<XeonFunContext> options)
            : base(options)
        {
        }

        public DbSet<XeonFun.Models.Assembling> Assembling { get; set; }
    }
}
