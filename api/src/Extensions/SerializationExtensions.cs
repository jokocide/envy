using Envy.API.DTO;
using Envy.API.Entities;

namespace Envy.API.Extensions
{
    public static class SerializationExtensions
    {
        public static IEnumerable<DeckDTO> AsDeckDTO(this IEnumerable<Deck> decks) 
            => decks.Select(a => a.AsDeckDTO());

        public static DeckDTO AsDeckDTO(this Deck deck) 
        => new DeckDTO()
            {
                Id = (Guid)deck.Id,
                CreatedDate = deck.CreatedDate,
                UpdatedDate = deck.UpdatedDate,
                Title = deck.Title,
                CardsCount = deck.CardsCount
            };

        public static IEnumerable<DeckWithRelationDTO> AsDeckWithRelationDTO(this IEnumerable<Deck> decks) 
        => decks.Select(a => a.AsDeckWithRelationDTO());

        public static DeckWithRelationDTO AsDeckWithRelationDTO(this Deck deck) 
        => new DeckWithRelationDTO()
            {
                Id = (Guid)deck.Id,
                CreatedDate = deck.CreatedDate,
                UpdatedDate = deck.UpdatedDate,
                Title = deck.Title,
                Cards = deck.Cards.AsCardDTO(),
                CardsCount = deck.CardsCount
            };

        public static IEnumerable<CardDTO> AsCardDTO(
            this IEnumerable<Card> cards
            ) => cards.Select(a => a.AsCardDTO());

        public static CardDTO AsCardDTO(
            this Card card
            )
            => new CardDTO() 
                { 
                    Id = card.Id,  
                    CreatedDate = card.CreatedDate,
                    UpdatedDate = card.UpdatedDate,
                    Sides = card.Sides
                };

        public static IEnumerable<CardWithRelationDTO> AsCardWithRelationDTO(
            this IEnumerable<Card> cards
        ) => cards.Select(a => a.AsCardWithRelationDTO());

        public static CardWithRelationDTO AsCardWithRelationDTO(
            this Card card
        )
        => new CardWithRelationDTO()
            {
                    Id = card.Id,  
                    CreatedDate = card.CreatedDate,
                    UpdatedDate = card.UpdatedDate,
                    Sides = card.Sides,
                    Deck = card.Deck.AsDeckDTO()
            };
    }
}