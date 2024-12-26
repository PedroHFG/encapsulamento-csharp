using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Entre com o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string owner = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char choice = char.Parse(Console.ReadLine().ToLower());

            while (choice != 's' && choice != 'n') 
            {
                Console.Write("Opção inválida! Escolha uma opção válida (s/n): ");
                choice = char.Parse(Console.ReadLine().ToLower());
            }

            if (choice == 's')
            {
                Console.Write("Entre com o número do depósito inicial: $ ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, owner, initialDeposit);
            }
            else
            {
                account = new Account(number, owner);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: $ ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: $ ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdrawal(amount);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(account);
        }
    }
}
