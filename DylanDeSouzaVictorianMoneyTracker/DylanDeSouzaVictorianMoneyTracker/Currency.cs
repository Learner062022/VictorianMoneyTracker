using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanDeSouzaVictorianMoneyTracker
{
    public class Currency
    {
        public int Pounds { get; set; }
        public int Crowns { get; set; }
        public int Shillings { get; set; }
        public int Pence { get; set; }
        public int Farthings { get; set; }

        public enum CurrencyInFarthings
        {
            Pound = 4 * 5 * 12 * 4,
            Crown = 5 * 12 * 4,
            Shilling = 12 * 4,
            Penny = 4,
            Farthing = 1
        }

        public Currency(int totalFarthings) 
        { 
            ConvertFromFarthings(totalFarthings);
        }

        public void ConvertFromFarthings(int totalFarthings)
        {
            Pounds = totalFarthings / (int)CurrencyInFarthings.Pound;
            int remainder = totalFarthings % (int)CurrencyInFarthings.Pound;
            Crowns = remainder / (int)CurrencyInFarthings.Crown;
            remainder %= (int)CurrencyInFarthings.Crown;

            Shillings = remainder / (int)CurrencyInFarthings.Shilling;
            remainder %= (int)CurrencyInFarthings.Shilling;

            Pence = remainder / (int)CurrencyInFarthings.Penny;
            Farthings = remainder % (int)CurrencyInFarthings.Penny;
        }

        public static int ConvertToFarthings(int amount, string denomination)
        {
            int amountInFarthings = 0;
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
            return amountInFarthings;
        }
    }
}
