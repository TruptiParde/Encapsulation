namespace Encapsulation.Bank
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            if (balance >= 0)
            {
                balance = balance;
            }
            else
            {
                Console.WriteLine("Initial balance can not be negative");
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited: {amount}. Current balance {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrawed: {amount}. Current balace {balance}");
            }
            else
            {
                Console.WriteLine("Invalid Withdraw amount");
            }
        }
    }
}
   