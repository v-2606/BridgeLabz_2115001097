//using System;
//using System.Collections.Generic;

//abstract class BankAccount
//{
//    public string AccountNumber { get; private set; }
//    public string HolderName { get; private set; }
//    protected double Balance { get; set; }

//    public BankAccount(string accountNumber, string holderName, double initialBalance)
//    {
//        AccountNumber = accountNumber;
//        HolderName = holderName;
//        Balance = initialBalance;
//    }

//    public void Deposit(double amount)
//    {
//        Balance += amount;
//        Console.WriteLine("Deposited " + amount + ". New Balance: " + Balance);
//    }

//    public virtual void Withdraw(double amount)
//    {
//        if (amount > Balance)
//            Console.WriteLine("Insufficient Balance");
//        else
//        {
//            Balance -= amount;
//            Console.WriteLine("Withdrawn " + amount + ". New Balance: " + Balance);
//        }
//    }

//    public abstract double CalculateInterest();

//    public void DisplayAccountInfo()
//    {
//        Console.WriteLine("Account: " + AccountNumber + ", Holder: " + HolderName + ", Balance: " + Balance);
//    }
//}

//interface ILoanable
//{
//    void ApplyForLoan(double amount);
//    double CalculateLoanEligibility();
//}

//class SavingsAccount : BankAccount
//{
//    private const double InterestRate = 0.04;

//    public SavingsAccount(string accountNumber, string holderName, double initialBalance)
//        : base(accountNumber, holderName, initialBalance) { }

//    public override double CalculateInterest()
//    {
//        return Balance * InterestRate;
//    }
//}

//class CurrentAccount : BankAccount, ILoanable
//{
//    private const double InterestRate = 0.02;

//    public CurrentAccount(string accountNumber, string holderName, double initialBalance)
//        : base(accountNumber, holderName, initialBalance) { }

//    public override double CalculateInterest()
//    {
//        return Balance * InterestRate;
//    }

//    public void ApplyForLoan(double amount)
//    {
//        Console.WriteLine("Loan of " + amount + " applied successfully");
//    }

//    public double CalculateLoanEligibility()
//    {
//        return Balance * 5;
//    }
//}

//class BankingSystem
//{
//    static void Main(string[] args)
//    {
//        List<BankAccount> accounts = new List<BankAccount>();

//        Console.Write("Enter number of accounts: ");
//        int numAccounts = int.Parse(Console.ReadLine());

//        for (int i = 0; i < numAccounts; i++)
//        {
//            BankAccount account = null;
//            while (account == null)
//            {
//                Console.Write("\nEnter Account Type (Savings/Current): ");
//                string type = Console.ReadLine().Trim().ToLower();

//                if (type != "savings" && type != "current")
//                {
//                    Console.WriteLine("Invalid type enter 'Savings' or 'Current'.");
//                    continue;
//                }

//                Console.Write("Enter Account Number: ");
//                string accNumber = Console.ReadLine();

//                Console.Write("Enter Account Holder Name: ");
//                string holderName = Console.ReadLine();

//                Console.Write("Enter Initial Balance: ");
//                double balance = double.Parse(Console.ReadLine());

//                if (type == "savings") account = new SavingsAccount(accNumber, holderName, balance);
//                else if (type == "current") account = new CurrentAccount(accNumber, holderName, balance);
//            }

//            accounts.Add(account);
//            Console.WriteLine(account.GetType().Name + " Account (" + account.AccountNumber + ") created successfully\n");
//        }

//        Console.WriteLine("\nAccount Details and Interest Calculation:");
//        foreach (var acc in accounts)
//        {
//            acc.DisplayAccountInfo();
//            Console.WriteLine("Interest Earned: " + acc.CalculateInterest());

//            Console.Write("Enter Deposit Amount: ");
//            double depositAmount = double.Parse(Console.ReadLine());
//            acc.Deposit(depositAmount);

//            Console.Write("Enter Withdrawal Amount: ");
//            double withdrawAmount = double.Parse(Console.ReadLine());
//            acc.Withdraw(withdrawAmount);

//            if (acc is ILoanable loanAccount)
//            {
//                Console.WriteLine("Loan Eligibility: " + loanAccount.CalculateLoanEligibility());
//                Console.Write("Apply for Loan? (yes/no): ");
//                string choice = Console.ReadLine().Trim().ToLower();
//                if (choice == "yes")
//                {
//                    Console.Write("Enter Loan Amount: ");
//                    double loanAmount = double.Parse(Console.ReadLine());
//                    loanAccount.ApplyForLoan(loanAmount);
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}
