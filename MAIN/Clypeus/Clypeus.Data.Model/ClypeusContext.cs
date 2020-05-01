using System;
using Clypeus.Data.Model.Configurations;
using Clypeus.Data.Model.Configurations.GeographyConfigurations;
using Clypeus.Data.Model.Configurations.MedicinalConfigurations;
using Clypeus.Data.Model.Configurations.Medicinals;
using Clypeus.Data.Model.Configurations.Organisations;
using Clypeus.Data.Model.Configurations.PeopleConfigurations;
using Clypeus.Data.Model.Configurations.SensitivityConfigurations;
using Clypeus.Data.Model.Configurations.Users;
using Clypeus.Data.Model.Geography;
using Clypeus.Data.Model.Medicinals;
using Clypeus.Data.Model.Organisations;
using Clypeus.Data.Model.People;
using Clypeus.Data.Model.Specimens;
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


        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<DrugGroup> DrugGroup { get; set; }
        public virtual DbSet<DrugGroupMembers> DrugGroupMembers { get; set; }
        public virtual DbSet<DrugTypes> DrugTypes { get; set; }
        public virtual DbSet<Drugs> Drugs { get; set; }
        public virtual DbSet<MedicalPractioner> MedicalPractioners { get; set; }
        public virtual DbSet<NotifiableDisease> NotifiableDiseases { get; set; }
        public virtual DbSet<SystemOrganisations> Organisation { get; set; }
        public virtual DbSet<OrganismGenus> OrganismTypes { get; set; }
        public virtual DbSet<Organisms> Organisms { get; set; }
        public virtual DbSet<PrimaryCarePractice> PrimaryCarePractices { get; set; }
        public virtual DbSet<Sensitivity> Sensitivities { get; set; }
        public virtual DbSet<SystemUser> Users { get; set; }
        
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
            modelBuilder = OnModelSpecimens(modelBuilder);
            
            OnModelCreatingPartial(modelBuilder);
        }

        protected ModelBuilder OnModelCreatingUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SystemUserConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalPractionerConfiguration());
            modelBuilder.ApplyConfiguration(new SystemOrganisationConfiguration());
            modelBuilder.ApplyConfiguration(new PrimaryCarePracticeConfiguration());
           
            return modelBuilder;
        }


        protected ModelBuilder OnModelSpecimens(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SensitivityConfiguration());
            modelBuilder.ApplyConfiguration(new SpecimenSensitivityConfiguration());

            return modelBuilder;
        }

        protected ModelBuilder OnModelGeographyUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            
          
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
