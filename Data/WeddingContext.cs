using deleohynekwedding.Models;
using Microsoft.EntityFrameworkCore;

namespace deleohynekwedding.Data
{
    public class WeddingContext: DbContext
    {
        public WeddingContext(DbContextOptions<WeddingContext> options): base(options)
        {
            Invitations.Include(invite => invite.Guests).ToListAsync();
            Guests.Include(guest => guest.ResponseInfo).ToListAsync();
        }

        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestResponseInfo> GuestResponseInfo { get; set; }
        public DbSet<MenuOption> MenuOptions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invitation>().ToTable("Invitations").HasMany(i => i.Guests);
            modelBuilder.Entity<Guest>().ToTable("Guests").HasOne(g => g.ResponseInfo);
            modelBuilder.Entity<GuestResponseInfo>().ToTable("GuestResponseInfo");
            modelBuilder.Entity<MenuOption>().ToTable("MenuOptions");
        }
    }
}
