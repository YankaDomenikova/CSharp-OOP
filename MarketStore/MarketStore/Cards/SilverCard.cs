namespace MarketStore.Cards
{
    public class SilverCard : Card
    {
        private const decimal INITIAL_DISCOUNT_RATE = 0.02m;

        private decimal discountRate;

        public SilverCard()
        {
            this.InitialDiscountRate = INITIAL_DISCOUNT_RATE;
        }

        public decimal DiscountRate 
        {
            get
            {
                return this.discountRate;
            }
            set
            {
                if (this.Turnover > 300)
                {
                    this.discountRate = 0.035m;
                }
            }
        }
    }
}
