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
        public virtual DbSet<OrganismTypes> OrganismTypes { get; set; }
        public virtual DbSet<Organisms> Organisms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=Clypeus;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
         
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
