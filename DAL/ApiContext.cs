using CitizenManagementSystemAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CitizenManagementSystemAPI.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region DefaultValues
            modelBuilder.Entity<Manager>().Property(c => c.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Citizen>().Property(c => c.IsDeleted).HasDefaultValue(false);
            #endregion

            #region Data Seeds

            #region Manager Seed
            modelBuilder.Entity<Manager>().HasData(
                new Manager()
                {
                    ManagerId = 1,
                    Name = "Nurlan",
                    Surname = "Khankishiyev",
                    Username = "admin",
                    Password = "password"
                });
            #endregion
            #region Region Seed
            modelBuilder.Entity<Region>()
                .HasData(new Region()
                {
                    RegionId = 1,
                    RegionName = "Baku",
                });
            #endregion
            #region Street Seed
            modelBuilder.Entity<Street>()
                .HasData(new Street()
                {
                    StreetId = 1,
                    StreetName = "Ehmed Recebli",
                    RegionId = 1
                });
            #endregion
            #region Entrance Seed
            modelBuilder.Entity<Entrance>()
                .HasData(new Entrance()
                {
                    EntranceId = 1,
                    EntranceName = "44A",
                    StreetId = 1,
                });
            #endregion
            #region EnumKey Seed
            modelBuilder.Entity<EnumKey>()
                .HasData(new EnumKey()
                {
                    Id = 1,
                    Key = "gender"
                });
            #endregion
            #region EnumValue Seed
            modelBuilder.Entity<EnumValue>()
                .HasData(new EnumValue()
                {
                    Id = 1,
                    KeyId = 1,
                    Value = "Male"
                },
                new EnumValue()
                {
                    Id = 2,
                    KeyId = 1,
                    Value = "Female"
                });
            #endregion

            #endregion

            #region Citizen Relations
            modelBuilder.Entity<Citizen>()
                .HasOne(c => c.Father)
                .WithMany()
                .HasForeignKey(c => c.FatherId);
            modelBuilder.Entity<Citizen>()
                .HasOne(c => c.Mother)
                .WithMany()
                .HasForeignKey(c => c.MotherId);
            modelBuilder.Entity<Citizen>()
                .Property(p => p.BirthDate)
                .HasColumnType("date");
            modelBuilder.Entity<Citizen>()
                .HasIndex(c => c.Pin)
                .IsUnique();
            #endregion

        }

        #region DbSets

        public DbSet<Manager> Managers { get; set; }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Entrance> Entrances { get; set; }
        public DbSet<CurrentPlace> CurrentPlaces { get; set; }
        public DbSet<Citizen> Citizens { get; set; }

        #endregion

    }
}
