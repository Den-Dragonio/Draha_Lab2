using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2._8
{
    public class Invoice
    {

        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;


        private string _article = String.Empty;
        private int _quantity;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double SummWithNds(double nds = 1.2)
        {
            return Account * nds;
        }

        public void Show()
        {
            Console.WriteLine($"{Customer} зробив/ла замовлення у {Provider} на {_quantity} {_article}");
            Console.WriteLine($"Рахунок становить {Account} без урахування НДС та { SummWithNds()} з НДС!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(45999, "Тарасенко Тарас Тарасович", "Apple Inc")
            {
                Quantity = 1,
                Article = "Iphone 12"
            };
            invoice.SummWithNds();
            invoice.Show();

            Console.ReadKey();
        }
    }
}
