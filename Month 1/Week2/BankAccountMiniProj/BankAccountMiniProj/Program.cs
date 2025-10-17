using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMiniProj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and Welcome!");
            Console.WriteLine("It is me again, rhouge");
            Console.WriteLine("this is my second week of programming using C#");
            Console.WriteLine("and today, I have made a program, that I designed myself");
            Console.WriteLine("using my new knowledge about OOP");
            Console.WriteLine("I now present you, The Bank Account System");
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                    Bank Account System");
            Console.WriteLine("-----------------------------------------------------------");

            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();
            BankAccount account3 = new BankAccount();
            BankAccount shinroacc = new BankAccount();
            BankAccount rhougeacc = new BankAccount();

            Console.WriteLine(account1.name);
            shinroacc.Initialize("Shinro");
            rhougeacc.Initialize("Rhouge");

            shinroacc.Deposit(1000);
            rhougeacc.Deposit(1000);

            Console.WriteLine("Accouts before transaction: ");

            Console.WriteLine("");
            Console.WriteLine("");

            account1.PrintInfo();
            account2.PrintInfo();
            account3.PrintInfo();
            rhougeacc.PrintInfo();
            shinroacc.PrintInfo();

            Console.WriteLine("");
            Console.WriteLine("");

            try
            {
                do
                {
                    string[] options = { "1 = Initialize an account", "2 = Deposit", "3 = Withdraw", "4 = Transfer" };
                    foreach (string option in options)
                    {
                        Console.WriteLine(option);
                    }

                    Console.Write("Enter a transaction: ");
                    int transaction = Convert.ToInt32(Console.ReadLine());

                    switch (transaction)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.Write("Enter your name: ");
                            string name = Console.ReadLine();

                            string[] availableAccounts = { "1 = Account number 1", "2 = Account number 2", "3 = Account number 3" };
                            foreach (string acc in availableAccounts)
                            {
                                Console.WriteLine(acc);
                            }

                            Console.WriteLine("");
                            Console.Write("Enter an account number: ");
                            int chooseAccount = Convert.ToInt32(Console.ReadLine());

                            switch (chooseAccount)
                            {
                                case 1:
                                    account1.Initialize(name);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 2:
                                    account2.Initialize(name);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 3:
                                    account3.Initialize(name);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("1 = " + account1.name);
                            Console.WriteLine("2 = " + account2.name);
                            Console.WriteLine("3 = " + account3.name);
                            Console.WriteLine("4 = " + rhougeacc.name);
                            Console.WriteLine("5 = " + shinroacc.name);
                            Console.WriteLine("Account with no name does not have an owner");

                            Console.Write("Choose your Account:");
                            int chooseDepAcc = Convert.ToInt32(Console.ReadLine());

                            switch (chooseDepAcc)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to deposit?: ");
                                    uint deposit = Convert.ToUInt32(Console.ReadLine());
                                    account1.Deposit(deposit);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to deposit?: ");
                                    uint deposit1 = Convert.ToUInt32(Console.ReadLine());
                                    account2.Deposit(deposit1);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to deposit?: ");
                                    uint deposit2 = Convert.ToUInt32(Console.ReadLine());
                                    account3.Deposit(deposit2);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 4:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to deposit?: ");
                                    uint deposit3 = Convert.ToUInt32(Console.ReadLine());
                                    rhougeacc.Deposit(deposit3);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 5:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to deposit?: ");
                                    uint deposit4 = Convert.ToUInt32(Console.ReadLine());
                                    shinroacc.Deposit(deposit4);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("1 = " + account1.name);
                            Console.WriteLine("2 = " + account2.name);
                            Console.WriteLine("3 = " + account3.name);
                            Console.WriteLine("4 = " + rhougeacc.name);
                            Console.WriteLine("5 = " + shinroacc.name);
                            Console.WriteLine("Account with no name does not have an owner");

                            Console.Write("Choose your Account:");
                            int chooseWDAcc = Convert.ToInt32(Console.ReadLine());

                            switch (chooseWDAcc)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to withdraw?: ");
                                    uint withdraw = Convert.ToUInt32(Console.ReadLine());
                                    account1.Withdraw(withdraw);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to withdraw?: ");
                                    uint withdraw1 = Convert.ToUInt32(Console.ReadLine());
                                    account2.Withdraw(withdraw1);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to withdraw?: ");
                                    uint withdraw2 = Convert.ToUInt32(Console.ReadLine());
                                    account3.Withdraw(withdraw2);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 4:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to withdraw?: ");
                                    uint withdraw3 = Convert.ToUInt32(Console.ReadLine());
                                    rhougeacc.Withdraw(withdraw3);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                                case 5:
                                    Console.WriteLine("");
                                    Console.Write("How much do you want to withdraw?: ");
                                    uint withdraw4 = Convert.ToUInt32(Console.ReadLine());
                                    shinroacc.Withdraw(withdraw4);

                                    Console.WriteLine("Accouts after transaction: ");

                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    account1.PrintInfo();
                                    account2.PrintInfo();
                                    account3.PrintInfo();
                                    rhougeacc.PrintInfo();
                                    shinroacc.PrintInfo();
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("1 = " + account1.name);
                            Console.WriteLine("2 = " + account2.name);
                            Console.WriteLine("3 = " + account3.name);
                            Console.WriteLine("4 = " + rhougeacc.name);
                            Console.WriteLine("5 = " + shinroacc.name);
                            Console.WriteLine("Account with no name does not have an owner");
                            Console.WriteLine("");
                            Console.Write("Choose your Account: ");
                            int chooseTransAcc = Convert.ToInt32(Console.ReadLine());

                            switch (chooseTransAcc)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("1 = " + account2.name);
                                    Console.WriteLine("2 = " + account3.name);
                                    Console.WriteLine("3 = " + rhougeacc.name);
                                    Console.WriteLine("4 = " + shinroacc.name);
                                    Console.WriteLine("Account with no name does not have an owner");
                                    Console.WriteLine("");
                                    Console.Write("Who do you want to send money to?: ");
                                    int sendMoneyTo = Convert.ToInt32(Console.ReadLine());

                                    switch (sendMoneyTo)
                                    {
                                        case 1:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney = Convert.ToUInt32(Console.ReadLine());

                                            account1.Transfer(account2, sendMoney);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 2:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney1 = Convert.ToUInt32(Console.ReadLine());

                                            account1.Transfer(account3, sendMoney1);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 3:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney2 = Convert.ToUInt32(Console.ReadLine());

                                            account1.Transfer(rhougeacc, sendMoney2);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 4:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney3 = Convert.ToUInt32(Console.ReadLine());

                                            account1.Transfer(shinroacc, sendMoney3);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.WriteLine("1 = " + account1.name);
                                    Console.WriteLine("2 = " + account3.name);
                                    Console.WriteLine("3 = " + rhougeacc.name);
                                    Console.WriteLine("4 = " + shinroacc.name);
                                    Console.WriteLine("Account with no name does not have an owner");
                                    Console.WriteLine("");
                                    Console.Write("Who do you want to send money to?: ");
                                    int sendMoneyTo1 = Convert.ToInt32(Console.ReadLine());

                                    switch (sendMoneyTo1)
                                    {
                                        case 1:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney = Convert.ToUInt32(Console.ReadLine());

                                            account2.Transfer(account1, sendMoney);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 2:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney1 = Convert.ToUInt32(Console.ReadLine());

                                            account2.Transfer(account3, sendMoney1);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 3:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney2 = Convert.ToUInt32(Console.ReadLine());

                                            account2.Transfer(rhougeacc, sendMoney2);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 4:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney3 = Convert.ToUInt32(Console.ReadLine());

                                            account2.Transfer(shinroacc, sendMoney3);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.WriteLine("1 = " + account1.name);
                                    Console.WriteLine("2 = " + account2.name);
                                    Console.WriteLine("3 = " + rhougeacc.name);
                                    Console.WriteLine("4 = " + shinroacc.name);
                                    Console.WriteLine("Account with no name does not have an owner");
                                    Console.WriteLine("");
                                    Console.Write("Who do you want to send money to?: ");
                                    int sendMoneyTo2 = Convert.ToInt32(Console.ReadLine());

                                    switch (sendMoneyTo2)
                                    {
                                        case 1:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney = Convert.ToUInt32(Console.ReadLine());

                                            account3.Transfer(account1, sendMoney);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 2:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney1 = Convert.ToUInt32(Console.ReadLine());

                                            account3.Transfer(account2, sendMoney1);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 3:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney2 = Convert.ToUInt32(Console.ReadLine());

                                            account3.Transfer(rhougeacc, sendMoney2);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                        case 4:
                                            Console.WriteLine("");
                                            Console.Write("How much money do you want to send?: ");
                                            uint sendMoney3 = Convert.ToUInt32(Console.ReadLine());

                                            account3.Transfer(shinroacc, sendMoney3);

                                            Console.WriteLine("Accouts after transaction: ");

                                            Console.WriteLine("");
                                            Console.WriteLine("");

                                            account1.PrintInfo();
                                            account2.PrintInfo();
                                            account3.PrintInfo();
                                            rhougeacc.PrintInfo();
                                            shinroacc.PrintInfo();
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("");
                                    Console.WriteLine("Account Unavailable");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("This Transaction is Unavailable");
                            break;
                    }
                    Console.WriteLine("");
                    Console.Write("Would you like to do another transaction? (Press Y if yes, Press N if No): ");
                } while (Console.ReadLine().ToUpper() == "Y");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Incorrect Format, Only insert the the character needed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }

            Console.WriteLine("");
            Console.WriteLine("Accounts after transaction: ");

            Console.WriteLine("");
            account1.PrintInfo();
            account2.PrintInfo();
            account3.PrintInfo();
            rhougeacc.PrintInfo();
            shinroacc.PrintInfo();

            Console.WriteLine("Thank you for using my program!");

            Console.ReadLine();
        }
    }
}
