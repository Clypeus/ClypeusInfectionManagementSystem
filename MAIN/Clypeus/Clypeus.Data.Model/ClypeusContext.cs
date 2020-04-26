using System;
using Clypeus.Data.Model.Configurations;
using Clypeus.Data.Model.Configurations.MedicinalConfigurations;
using Clypeus.Data.Model.Configurations.Medicinals;
using Clypeus.Data.Model.Configurations.Users;
using Clypeus.Data.Model.Medicinals;
using Clypeus.Data.Model.Users;
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
        public virtual DbSet<OrganismGenus> OrganismTypes { get; set; }
        public virtual DbSet<Organisms> Organisms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=Clypeus;Trusted_Connection=True;");
   
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = OnModelCreatingMedicinals(modelBuilder);
            modelBuilder = OnModelCreatingUsers(modelBuilder);
            
            OnModelCreatingPartial(modelBuilder);
        }

        protected ModelBuilder OnModelCreatingUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OrganisationsConfiguration());

            return modelBuilder;
        }

        protected ModelBuilder OnModelCreatingMedicinals(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DrugGroupConfiguration());
            modelBuilder.ApplyConfiguration(new DrugGroupMembersConfiguration());
            modelBuilder.ApplyConfiguration(new DrugsConfiguration());
            modelBuilder.ApplyConfiguration(new DrugTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismClassConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismFamilyConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismKingdomConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismOrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismPhylumConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismsConfiguration());
            modelBuilder.ApplyConfiguration(new OrganismTypesConfiguration());
            modelBuilder.ApplyConfiguration(new NotifiableDiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new NotifiableDiseaseOrganismConfiguration());

            return modelBuilder;
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
