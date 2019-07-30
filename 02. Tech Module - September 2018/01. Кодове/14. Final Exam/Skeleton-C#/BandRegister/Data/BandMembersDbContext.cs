using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandRegister.Data
{
    public class BandMembersDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS01;Database=BandRegisterDb; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public virtual DbSet<Band> Banbds { get; set; }
    }
}
