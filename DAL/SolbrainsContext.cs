using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SolbrainsContext:DbContext
    {
        public SolbrainsContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
