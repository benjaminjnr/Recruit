using System;
using System.Data.Entity;
using Recruit.Migrations;
namespace Recruit.Models
{
    public class RecruitDBContext : DbContext
    {
        public RecruitDBContext() : base("MySqlConnection")
        {
            Database.SetInitializer<RecruitDBContext>( new Migrations.Configuration<RecruitDBContext>());
        }


        public static RecruitDBContext Create()
        {
            return new RecruitDBContext();
        }

        public DbSet<CareerLevel> CareerLevel { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobApplicant> JobApplicant { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Specialization> Specialization { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserMetaData> UserMetaData { get; set; }

    }
}
