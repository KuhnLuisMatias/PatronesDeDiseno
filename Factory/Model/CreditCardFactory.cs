using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;

            switch (cardType)
            {
                case "MoneyBack":
                    cardDetails = new MoneyBack();
                    break;
                case "Titanium":
                    cardDetails = new Titanium();
                    break;
                case "Platinum":
                    cardDetails = new Platinum();
                    break;
            }

            return cardDetails;
        }
    }
}
