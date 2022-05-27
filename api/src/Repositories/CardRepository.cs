using Microsoft.EntityFrameworkCore;
using Envy.API.Context;
using Envy.API.Entities;
using Envy.API.Interfaces;

namespace Envy.API.Repositories
{
    public class CardRepository : ICardRepository
    {
        public EnvyDbContext Context { get; }
        
        public CardRepository(EnvyDbContext context) 
            => Context = context;

        public async Task<Card> GetCardAsync(Guid id)
        {
            Card card = await Context.Cards.FindAsync(id);

            return 
                card == null ? null : card;
        }

        public async Task<IEnumerable<Card>> GetAllCardsAsync() 
            => await Context.Cards.ToListAsync();

        public async Task<IEnumerable<Card>> GetAllCardsWithRelationAsync()
            => await Context.Cards.Include(x => x.Deck).ToListAsync();

        public async Task CreateCardAsync(Card card)
        {
            await Context.AddAsync(card);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Card>> GetCardsFromDeckAsync(Guid id)
        {
            IEnumerable<Card> cards = await Context.Cards.Where(x => x.DeckId == id).ToListAsync();

            if (!cards.Any()) return null;

            return cards;
        }
    }
}