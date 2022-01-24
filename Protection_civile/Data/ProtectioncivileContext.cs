using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Protection_civile.Models;

namespace Protection_civile.Data
{
    public class ProtectioncivileContext : DbContext
    {
        public ProtectioncivileContext (DbContextOptions<ProtectioncivileContext> options)
            : base(options)
        {
        }
        public DbSet<Protection_civile.Models.Demande> Demande { get; set; }

        
    }
}
