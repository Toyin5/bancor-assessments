using ScratchCard.Database;
using ScratchCard.interfaces;
using ScratchCard.Models;
using ScratchCard.Services;
using System.Data.Entity;

namespace ScratchCard.Repositories
{
    public class CardRepository(Context context) : ICardRepository
    {
        public async Task GenerateCards(int count)
        {
            List<Card> cards = new();
            for (int i = 0; i < count; i++)
            {
                cards.Add(CreateCard());
            }
            await context.AddRangeAsync(cards);
            await context.SaveChangesAsync();
        }

        private Card CreateCard()
        {
            return new Card
            {
                Pin = Helpers.GeneratePin(),
                CardStatus = CardStatus.ACTIVE,
            };

        }

        public async Task<List<Card>> GetCards(CardStatus cardStatus)
        {
            return await context.Cards.AsNoTracking().ToListAsync();
        }

        public async Task<Card?> PurchaseCard(int id)
        {
            var card = await context.Cards.FindAsync(id);
            if (card is null)
            {
                return null;
            }
            card.CardStatus = CardStatus.PURCHASED;
            await context.SaveChangesAsync();
            return card;
        }

        public async Task UseCard(string pin)
        {
            var card = await context.Cards.FirstOrDefaultAsync(x => x.Pin == pin);
            if (card is null)
            {
                return;
            }
            card.CardStatus = CardStatus.USED;
            await context.SaveChangesAsync();
        }
    }
}
