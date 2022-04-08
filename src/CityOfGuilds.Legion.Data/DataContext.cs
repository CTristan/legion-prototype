using CityOfGuilds.Legion.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityOfGuilds.Legion.Data;

public class DataContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerItemDropChance> PlayerItemDropChances { get; set; }
    public DbSet<Rarity> Rarities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>().HasOne<Player>().WithMany(p => p.Characters);

        modelBuilder.Entity<PlayerItemDropChance>(p => { p.HasKey(p => new { p.Player, p.Item }); });
    }
}
