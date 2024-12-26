using System.Globalization;

namespace Course
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Owner { get; set; }
        public double Balance { get; private set; }

        public Account()
        {
        }

        public Account(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public Account(int number, string owner, double balance) : this(number, owner)
        {
            Balance = balance;
        }

        public void Withdrawal(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string? ToString()
        {
            return "Conta " + Number
                + ", Titular: " + Owner
                + ", Saldo: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
