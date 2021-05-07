namespace MarketStore.Cards
{
    class GoldCard : Card
    {
        private const decimal INITIAL_DISCOUNT_RATE = 0.02m;

        private decimal discountRate;

        public GoldCard()
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
                if (this.Turnover < 100)
                {
                    this.discountRate = INITIAL_DISCOUNT_RATE;
                }

                decimal rateOfGrowth = 0.01m;
                decimal amountOfGrowth = 100;
                decimal maxRate = 0.1m;

                decimal additionalRate = rateOfGrowth * (this.Turnover / amountOfGrowth);
                decimal currentRate = INITIAL_DISCOUNT_RATE + additionalRate;

                if (currentRate > maxRate)
                {
                    currentRate = maxRate;
                }

            }
        }
    }
}
