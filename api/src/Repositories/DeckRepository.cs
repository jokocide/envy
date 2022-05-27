using Microsoft.EntityFrameworkCore;
using Envy.API.Context;
using Envy.API.Entities;
using Envy.API.Interfaces;

namespace Envy.API.Repositories
{
    public class DeckRepository : IDeckRepository
    {
        public EnvyDbContext Context { get; }
        
        public DeckRepository(EnvyDbContext context) => Context = context;

        public async Task<Deck> GetDeckAsync(Guid id)
        {
            Deck deck = await Context.Decks.FindAsync(id);

            return 
                deck == null ? null : deck;
        }

        public async Task<Deck> GetDeckWithRelationAsync(Guid id) => 
            await Context.Decks.Include(x => x.Cards).FirstOrDefaultAsync(c => c.Id == id);

        // public async Task<IEnumerable<Deck>> GetAllDecksAsync() => 
        //     await Context.Decks.ToListAsync();

        public async Task<IEnumerable<Deck>> GetAllDecksAsync()
        {
            List<Deck> decks = await Context.Decks.ToListAsync();

// TODO: Refactor, this is slow. Just need to get the data to the front end for now.
            foreach(Deck deck in decks)
            {
                deck.CardsCount = Context.Entry(deck)
                    .Collection(x => x.Cards)
                    .Query()
                    .Count();
            }

            return decks;
        }

        // public async Task<IEnumerable<Deck>> GetAllDecksWithRelationAsync() => 
        //     await Context.Decks.Include(x => x.Cards).ToListAsync();

        public async Task<IEnumerable<Deck>> GetAllDecksWithRelationAsync()
        {
            List<Deck> decks = await Context.Decks.Include(x => x.Cards).ToListAsync();

// TODO: Refactor, this is slow. Just need to get the data to the front end for now.
            foreach(Deck deck in decks)
            {
                deck.CardsCount = Context.Entry(deck)
                    .Collection(x => x.Cards)
                    .Query()
                    .Count();
            }

            return decks;
        }

        public async Task CreateDeckAsync(Deck deck)
        {
            await Context.AddAsync(deck);
            await Context.SaveChangesAsync();
        }
    }
}