
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine("Pls insert coin into exchange automat: ");
string paymentstr = Validation();

if (!string.IsNullOrEmpty(paymentstr) && decimal.TryParse(paymentstr, out decimal euroPayment) && euroPayment > 0)
{
    int payment = (int)Math.Round(euroPayment * 100);
    int[] coins =
    { 
        200, 100, 50, 20, 10, 5, 2, 1 
    };
    string[] names = {
        "2 Euro", "1 Euro", "0.50 Euro", "0.20 Euro",
        "0.10 Euro", "0.05 Euro", "0.02 Euro", "0.01 Euro"
    };

    for (int i = 0; i < coins.Length; i++)
    {
        int amount = payment / coins[i];
        if (amount > 0)
        {
            Console.WriteLine($"{amount} x {names[i]}");
        }
        payment %= coins[i];
    }
}
}

static string Validation()
{
    string input = Console.ReadLine();
    decimal payment;

    while (string.IsNullOrEmpty(input) ||
           !decimal.TryParse(input, out payment) ||
           payment <= 0)
    {
        Console.WriteLine("Wrong format. Try again:");
        input = Console.ReadLine();
    }

    return input;
}
    }
}   