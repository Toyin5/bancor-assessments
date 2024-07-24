namespace ScratchCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public required string Pin {  get; set; }
        public CardStatus CardStatus { get; set; }
        public string CardStatusDesc { get { return CardStatus.ToString(); } }
    }

    public enum CardStatus
    {
        ACTIVE=1,
        USED,
        PURCHASED
    }
}
