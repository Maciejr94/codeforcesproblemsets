using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPatterns.CreativePattern
{
    public enum EPaymentMethod
    {
        BANK_ONE,
        BANK_TWO,
        PAYPAL,
        PRZELEWY24
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public interface IPaymentGateway
    {
        void MakePayment(Product product);
    }

    public class BankOne : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Pierwszy rodzaj płatności za {0}, kwota {1}", product.Name, product.Price);
        }
    }
    public class BankTwo : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Drugi rodzaj płatności za {0}, kwota {1}", product.Name, product.Price);
        }
    }
    public class Paypal : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Trzeci rodzaj płatności (PayPal) za {0}, kwota {1}", product.Name, product.Price);
        }
    }
    public class Przelewy24 : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine("Trzeci rodzaj płatności (PRZELEWY24) za {0}, kwota {1}", product.Name, product.Price);
        }
    }

    public class PaymentGatewayFactory 
    {
        public virtual IPaymentGateway CreatePaymentGateway(EPaymentMethod method)
        {
            IPaymentGateway gateway = null;
            switch (method)
            {
                case EPaymentMethod.BANK_ONE:
                    gateway = new BankOne();
                    break;
                case EPaymentMethod.BANK_TWO:
                    gateway = new BankTwo();
                    break;
                case EPaymentMethod.PAYPAL:
                    gateway = new Paypal();
                    break;
                case EPaymentMethod.PRZELEWY24:
                    gateway = new Przelewy24();
                    break;
                default:
                    break;
            }
            return gateway;
        }
    }
    public class FactoryMethod
    {


        public void Main()
        {
            PaymentGatewayFactory pre = new PaymentGatewayFactory();
            Product prod = new Product();
            prod.Name = "Audi RS6";
            prod.Price = 560000;
            prod.Description = "Bardzo szybkie rodzinne kombi";
            pre.CreatePaymentGateway(EPaymentMethod.PAYPAL).MakePayment(prod);
        }
    }
}
