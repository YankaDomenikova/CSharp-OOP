namespace MarketStore.Cards
{
    public class BronzeCard : Card
    {
        private const decimal INITIAL_DISCOUNT_RATE = 0;

        private decimal discountRate;

        public BronzeCard()
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
                if (this.Turnover >= 100 && this.Turnover <= 300)
                {
                    this.discountRate = 0.01m;
                }
                else if (this.Turnover > 300)
                {
                    this.discountRate = 0.025m;
                }

            }
        }
    }
}
