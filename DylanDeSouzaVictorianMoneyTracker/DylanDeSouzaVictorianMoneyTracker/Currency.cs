using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanDeSouzaVictorianMoneyTracker
{
    public class Currency
    {
        public enum CurrencyInFarthings
        {
            Pound = 4 * 5 * 12 * 4,
            Crown = 5 * 12 * 4,
            Shilling = 12 * 4,
            Penny = 4,
            Farthing = 1
        }

        public static int ConvertToFarthings(int amount, string denomination)
        {
            int amountInFarthings = 0;
            if (amount > 0)
            {
                switch (denomination.ToLower())
                {
                    case "pounds":
                        amountInFarthings = amount * (int)CurrencyInFarthings.Pound;
                        break;
                    case "crowns":
                        amountInFarthings = amount * (int)CurrencyInFarthings.Crown;
                        break;
                    case "shillings":
                        amountInFarthings = amount * (int)CurrencyInFarthings.Shilling;
                        break;
                    case "pence":
                        amountInFarthings = amount * (int)CurrencyInFarthings.Penny;
                        break;
                }
            }
            return amountInFarthings;
        }
    }
}
