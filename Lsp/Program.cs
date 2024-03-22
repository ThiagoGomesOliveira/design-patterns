using Lsp.Payments;
using System;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            DebitCard card = new DebitCard();
            card.Validate();
            card.CollectPayment();


            Console.ReadLine(); 
        }
    }
}
