using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    public class Payment
    {
        private IPaymentStrategy PaymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }
        public void Pay(double amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }

    public enum PaymentType
    {
        CreditCard = 1,  // 1 for CreditCard
        DebitCard = 2   // 2 for DebitCard        
    }
}
