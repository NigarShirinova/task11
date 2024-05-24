using ShopTask.Models;
using task5;

namespace ShopTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Shop<Product> shop = new Shop<Product>();


            IDrinkShop<Product> shop2 = new Shop<Product>();

            while (true)
            {
                Console.WriteLine("Choose with numbers:");
                Console.WriteLine("1) Add product");
                Console.WriteLine("2) Sell product");
                Console.WriteLine("3) Show available products");
                Console.WriteLine("4) Show income");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProductToShop(shop);
                        break;
                    case "2":
                        SellProductFromShop(shop);
                        break;
                    case "3":
                        shop.DisplayProducts();
                        break;
                    case "4":
                        shop.ShowIncome();
                        break;
                    default:
                        Console.WriteLine("There is not such as option");
                        break;
                }
            }
        }



        private static void AddProductToShop(Shop<Product> shop)
        {
            Console.WriteLine("Enter product type(c or t)");
            char productType = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter price");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter count:");
            int count = Convert.ToInt32(Console.ReadLine());

            if (productType == 't')
            {
                shop.AddProduct(new Tea(productName, count, price));
            }
            else if (productType == 'c')
            {
                shop.AddProduct(new Coffee(productName, count, price));
            }
            else
            {
                Console.WriteLine("Invalid type");
            }
        }

        private static void SellProductFromShop(Shop<Product> shop)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter quantity");

            int quantity = Convert.ToInt32(Console.ReadLine());

            shop.SellProduct(name, quantity);
        }
    }
}