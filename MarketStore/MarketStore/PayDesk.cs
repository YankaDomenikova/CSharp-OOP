namespace MarketStore
{
    using MarketStore.Cards;

    public static class PayDesk
    {
        public static decimal DiscountRate(Card card)
        {
            return card.DiscountRate;
        }

        public static decimal Discount(decimal purchaseValue, Card card)
        {
            decimal discount = purchaseValue * card.DiscountRate;
            return discount;
        }

        public static decimal Total(decimal purchaseValue, Card card)
        {
            decimal total = purchaseValue - Discount(purchaseValue, card);
            return total;
        }

    }
}
