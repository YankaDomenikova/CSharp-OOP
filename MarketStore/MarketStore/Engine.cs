namespace MarketStore
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MarketStore.Cards;
    using MarketStore.Factories;

    public class Engine
    {
        private CardFactory cardFactory;

        public void PrintOutput()
        {
            string type = Console.ReadLine();
            decimal turnover = decimal.Parse(Console.ReadLine());
            decimal purchaseValue = decimal.Parse(Console.ReadLine());

            Card card = this.cardFactory.Create(type, turnover, purchaseValue);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Purchase value: {purchaseValue}");
            sb.AppendLine($"Discount rate: {card.DiscountRate}");
            sb.AppendLine($"Discount: {}");
            sb.Append($"Total: {}");

            Console.WriteLine(sb.ToString());
        }
    }
}
