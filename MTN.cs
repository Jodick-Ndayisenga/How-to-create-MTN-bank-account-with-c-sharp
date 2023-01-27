using System;
using System.Security.Cryptography.X509Certificates;

public class CardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public String getCardNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public void setCardNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please, choose one of the following options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show the balance");
            Console.WriteLine("4. Exit");
        }

        void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much would you love to deposit: ?");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your trust. Your new balance is: " + currentUser.getBalance());

        }

        void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much would you love to withdraw? ");
            double withdraw = double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdraw)
            {
                Console.WriteLine("I am sorry, you have insufficient money!!");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Thank you, you are good to go!");
            };

            void balance(CardHolder currentUser)
            {
                Console.WriteLine("Your current balance is: " + currentUser.getBalance());
            }

        }
    }

}