using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clypeus.Data.Model
{
    public partial class ClypeusContext : DbContext
    {
        public ClypeusContext()
        {
        }

        public ClypeusContext(DbContextOptions<ClypeusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DrugGroup> DrugGroup { get; set; }
        public virtual DbSet<DrugGroupMembers> DrugGroupMembers { get; set; }
        public virtual DbSet<DrugTypes> DrugTypes { get; set; }
        public virtual DbSet<Drugs> Drugs { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<OrganismTypes> OrganismTypes { get; set; }
        public virtual DbSet<Organisms> Organisms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
