using System.Data;
using HamsBurgerHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace HamsBurgerHelper.Data
{
    public class ArmyIndexContext : DbContext
    {
        public ArmyIndexContext(DbContextOptions<ArmyIndexContext> options) : base(options)
        {
        }
        
        public DbSet<ArmyIndex> ArmyIndices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArmyIndex>().ToTable("ArmyIndex");
        }
    }
}