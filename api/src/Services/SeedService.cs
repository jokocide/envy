using System.Text.Json;
using Envy.API.Context;
using Envy.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Envy.API.Services;

public static class SeedService
{
    public static async Task SeedEntities(IApplicationBuilder app)
    {
        EnvyDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<EnvyDbContext>();

        if (context.Database.GetPendingMigrations().Any()) 
        {
            context.Database.Migrate();
        }

        if (await context.Decks.AnyAsync()) return;

        string deckSeedData = await File.ReadAllTextAsync("Data/SeedData.json");

        List<Deck> decks = JsonSerializer.Deserialize<List<Deck>>(deckSeedData, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
        });

        foreach(Deck deck in decks)
        {
            foreach(Card card in deck.Cards.ToList())
            {
                deck.Cards.Add(card);
            }

            context.Decks.Add(deck);
        }

        await context.SaveChangesAsync();
    }
}