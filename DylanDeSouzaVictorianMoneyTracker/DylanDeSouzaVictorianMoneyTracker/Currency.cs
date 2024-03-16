using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.UI.Xaml.Media.Animation;
using static System.Collections.Specialized.BitVector32;

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

        // Implement the event handlers for the plus and minus buttons to modify the amount of each currency type.
        // Implement the event handlers for the arrow buttons to handle the conversion logic between different currency denominations.
        // Disable buttons when conversion is impossible.
        // Pluralization of currency names.
        // Explain functions' purpose and key sections.
        // Bind UI elements to properties
        // UI's design

        public bool CanConvertToHigherDenomination(string denomination)
        {
            bool canConvert = false;
            switch (denomination)
            {
                case "pounds":
                    canConvert = Crowns * (int)CurrencyInFarthings.Crown >= (int)CurrencyInFarthings.Pound;
                    break;
                case "crowns":
                    canConvert = Shillings * (int)CurrencyInFarthings.Shilling >= (int)CurrencyInFarthings.Crown; 
                    break;
                case "shillings":
                    canConvert = Pence * (int)CurrencyInFarthings.Penny >= (int)CurrencyInFarthings.Shilling;
                    break;
                case "pence":
                    canConvert = Farthings * (int)CurrencyInFarthings.Farthing >= (int)CurrencyInFarthings.Pound; 
                    break;
                case "farthings":
                    canConvert = Farthings >= (int)CurrencyInFarthings.Penny;
                    break;
            }
            return canConvert;
        }

        public int CalculateTotalWorth()
        {
            return (Pounds * (int)CurrencyInFarthings.Pound + Crowns * (int)CurrencyInFarthings.Crown + Shillings * (int)CurrencyInFarthings.Shilling + Pence * (int)CurrencyInFarthings.Penny + Farthings); 
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
            switch (denomination)
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
