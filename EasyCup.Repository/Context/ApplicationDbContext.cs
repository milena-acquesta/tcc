using EasyCup.Domain;
using EasyCup.Repository.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        #region DbSet

        public virtual DbSet<Championship> Championships { get; set; }

        public virtual DbSet<ChampionshipTeamPlayer> ChampionshipsTeamsPlayers { get; set; }

        public virtual DbSet<CupManager> CupManagers { get; set; }

        public virtual DbSet<Match> Matches { get; set; }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<FootballSchool> FootballSchools { get; set; }

        public virtual DbSet<FootballSchoolUnit> FootballSchoolUnits { get; set; }

        public virtual DbSet<FutsalCourt> FutsalCourts { get; set; }


        #endregion

        #region Constructor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
            Database.Migrate();
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChampionshipTeamPlayer>(new ChampionshipTeamPlayerConfiguration().Configure);

            //modelBuilder.Entity<Match>().WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
