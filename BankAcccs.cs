using System;


    class BankAccount
    {
        public string accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }

        public void ModifyBalance(double amount)
        {
            balance += amount;
            Console.WriteLine("\nUpdated Balance: " + balance + " + " + amount);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder, double initialBalance)
            : base(accountNumber, accountHolder, initialBalance)
        {
        }

        public void DisplaySavingsAccountDetails()
        {
            Console.WriteLine("Savings Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter Account Holder Name: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());

            BankAccount account1 = new BankAccount(accountNumber, accountHolder, initialBalance);
            account1.DisplayAccountDetails();

            Console.Write("\nEnter amount to deposit/withdraw (positive for deposit, negative for withdrawal): ");
            double amount = Convert.ToDouble(Console.ReadLine());
            account1.ModifyBalance(amount);

            Console.Write("\nEnter Savings Account Number: ");
            string savingsAccountNumber = Console.ReadLine();

            Console.Write("Enter Savings Account Holder Name: ");
            string savingsAccountHolder = Console.ReadLine();

            Console.Write("Enter Initial Balance for Savings Account: ");
            double savingsInitialBalance = Convert.ToDouble(Console.ReadLine());

            SavingsAccount savingsAccount1 = new SavingsAccount(savingsAccountNumber, savingsAccountHolder, savingsInitialBalance);
            savingsAccount1.DisplaySavingsAccountDetails();

            savingsAccount1.ModifyBalance(0);
        }
    }


