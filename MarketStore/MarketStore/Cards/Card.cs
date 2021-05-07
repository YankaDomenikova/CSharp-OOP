namespace MarketStore.Cards
{
    public class Card
    {
        public string CardHolder { get; set; }

        public string Type { get; set; }

        public decimal Turnover { get; set; }

        public decimal InitialDiscountRate { get; set; }

        public decimal DiscountRate { get; set; }
    }
}
