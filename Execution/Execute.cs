using Encapsulation.Bank;
using Encapsulation.Shopping;

namespace Encapsulation.Execution
{
    class Program
    {
        static void Main()
        {
            //-----------------------Bank---------------------------------------
            BankAccount account = new BankAccount(1000);

            Console.WriteLine("Initial Balance: {account.GetBalance()}");

            account.Deposit(500);

            account.Withdraw(300);

            account.Withdraw(2000);

            //-------------------------shopping-----------------------------
            ShoppingCart cart = new ShoppingCart();

            cart.AddItem("BaggyJeanse", 1200, "MaxFashion", 1, "L");
            cart.AddItem("CropTop", 500, "Zudio", 2, "M");
            cart.AddItem("KurntiSet", 4000, "Trends", 2, "XL");
            cart.AddItem("Jacket", 1800, "Pantaloons", 1, "S");
            cart.AddItem("Shooes", 3000, "Bata", 1, "L");
            cart.AddItem("Compact", 350, "FitMe", 1, "NA");
            cart.AddItem("Lipstick", 900, "Suger", 3, "Mini");
            cart.AddItem("Tshirt", 300, "Zudio", 4, "XS");
            cart.AddItem("Hoodie", 1000, "Zara", 1, "M");

            cart.GetCartDetails();
            Console.WriteLine($"Total Price: {cart.CalculateTotal()}");
        }
    }
}
