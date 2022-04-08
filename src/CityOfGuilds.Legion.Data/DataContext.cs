using CityOfGuilds.Legion.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityOfGuilds.Legion.Data;

public class DataContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<CharacterItemBadLuck> PlayerItemDropChances { get; set; }
    public DbSet<Rarity> Rarities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>().HasOne<Player>().WithMany(p => p.Characters);

        modelBuilder.Entity<CharacterItemBadLuck>(p => { p.HasKey(p => new { Player = p.Character, p.Item }); });
    }
}