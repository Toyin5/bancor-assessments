using ScratchCard.Models;

namespace ScratchCard.interfaces
{
    public interface ICardRepository
    {
        Task GenerateCards(int count);
        Task<List<Card>> GetCards(CardStatus cardStatus);
        Task UseCard(string pin);
        Task<Card?> PurchaseCard(int id);
    }
}
