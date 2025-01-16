namespace Praktika17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassicAccount classic = new();
            classic.Balance = 750;
            classic.CalculateInterest();

            WageAccount wageAccount = new WageAccount();
            wageAccount.Balance = 50000;
            wageAccount.CalculateInterest();

            Console.WriteLine($"Рассчет процента для стандартного профиля " + classic.Interest);
            Console.WriteLine($"Рассчет процента для зарплатного профиля " + wageAccount.Interest);
        }
    }
}
