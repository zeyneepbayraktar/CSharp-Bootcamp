namespace marketAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---WELCOME TO MY MARKET---");
            Console.WriteLine("--------------------------");

            Console.Write("1. item name: ");
            string item1 = Console.ReadLine();
            Console.Write("1. item price: ");
            double price1 = double.Parse(Console.ReadLine());

            Console.Write("2. item name: ");
            string item2 = Console.ReadLine();
            Console.Write("2. item price: ");
            double price2 = double.Parse(Console.ReadLine());

            Console.Write("3. item name: ");
            string item3 = Console.ReadLine();
            Console.Write("3. item price: ");
            double price3 = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            totalPrice = price1 + price2 + price3;
            double kdv;
            kdv = totalPrice * 0.20;

            double lastPrice = totalPrice + kdv;

            Console.WriteLine("--------------------------");
            Console.WriteLine($"1. {item1}\t\t: {price1:0.00} TL");
            Console.WriteLine($"2. {item2}\t\t: {price2:0.00} TL");
            Console.WriteLine($"3. {item3}\t\t: {price3:0.00} TL");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Ara Toplam\t: {totalPrice:0.00} TL");
            Console.WriteLine($"KDV (%20)\t: {kdv:0.00} TL");
            Console.WriteLine($"GENEL TOPLAM\t: {lastPrice:0.00} TL");
            Console.WriteLine("--------------------------");

        }
    }
}
