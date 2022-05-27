namespace Envy.API.Context;

using Envy.API.Entities;
using Microsoft.EntityFrameworkCore;

public class EnvyDbContext : DbContext
{
    public EnvyDbContext() { }

    public EnvyDbContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<Deck> Decks { get; init; }

    public virtual DbSet<Card> Cards { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Deck>()
            .HasMany(x => x.Cards)
            .WithOne(x => x.Deck);

        modelBuilder.Entity<Card>()
            .HasOne(x => x.Deck)
            .WithMany(x => x.Cards);
    }
}