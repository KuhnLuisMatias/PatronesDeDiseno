using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Model
{
    public class Order
    {
        //Facade class
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            
            var product = new Product();
            product.GetProductDetails();
            
            var payment = new Payment();
            payment.MakePayment();
            
            var invoice = new Invoice();
            invoice.Sendinvoice();
     
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
