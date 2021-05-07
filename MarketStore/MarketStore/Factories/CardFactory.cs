namespace MarketStore.Factories
{
    using MarketStore.Cards;
    using System;

    public class CardFactory
    {
        private const string INVALID_CARD_TYPE = "Invalid card type";
        public Card Create(string type, decimal turnover, decimal purchaseValue)
        {
            Card card = null;

            if (type == "Bronze")
            {
                card = new BronzeCard();
            }
            else if (type == "Silver")
            {
                card = new SilverCard();
            }
            else if (type == "Gold")
            {
                card = new GoldCard();
            }

            throw new ArgumentException(INVALID_CARD_TYPE);

        }
    }
}
