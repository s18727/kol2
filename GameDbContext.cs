using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Player_Team> PlayerTeams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Championship_team> ChampionshipTeams { get; set; }

        public GameDbContext()
        {

        }

        public GameDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>(opt =>
            {
                opt.HasKey(p => p.IdPlayer);
                opt.Property(p => p.FirstName).HasMaxLength(30).IsRequired();
                opt.Property(p => p.LastName).HasMaxLength(30).IsRequired();
                opt.Property(p => p.DateOfBirth).IsRequired();
            });


            //DALEJ ROBOTA \/

            modelBuilder.Entity<Player_Team>(opt =>
            {
                opt.HasKey(p => p.IdPlayer);
                opt.Property(p => p.NumOnShirt);
                opt.Property(p => p.Comment).HasMaxLength(300);
            });

            modelBuilder.Entity<Team>(opt =>
            {
                opt.HasKey(p => p.IdTeam);
                opt.Property(p => p.TeamName).HasMaxLength(30);
                opt.Property(p => p.MaxAge);
                 
            });

            modelBuilder.Entity<Championship>(opt =>
            {
                opt.HasKey(p => p.idChampionship);
                opt.Property(p => p.OfficialName).HasMaxLength(100);

                opt.Property(p => p.Year)
                    .IsRequired();
            });

            modelBuilder.Entity<Championship_team>(opt =>
            {
                opt.HasKey(p => p.IdChampionship);
                opt.Property(p => p.IdChampionship)
                   .ValueGeneratedOnAdd();
                
                opt.Property(p => p.IdTeam)
                   .ValueGeneratedOnAdd();

                opt.Property(p => p.Score)
                   .IsRequired();
            });
        }
    }
}
