namespace marketAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region day1 BASIC MARKET AUTOMATION
            // Console.WriteLine("---WELCOME TO MY MARKET---");
            // Console.WriteLine("--------------------------");

            // Console.Write("1. item name: ");
            // string item1 = Console.ReadLine();
            // Console.Write("1. item price: ");
            // double price1 = double.Parse(Console.ReadLine());

            // Console.Write("2. item name: ");
            // string item2 = Console.ReadLine();
            // Console.Write("2. item price: ");
            // double price2 = double.Parse(Console.ReadLine());

            // Console.Write("3. item name: ");
            // string item3 = Console.ReadLine();
            // Console.Write("3. item price: ");
            // double price3 = double.Parse(Console.ReadLine());

            // double totalPrice = 0;
            // totalPrice = price1 + price2 + price3;
            // double kdv;
            // kdv = totalPrice * 0.20;

            // double lastPrice = totalPrice + kdv;

            // Console.WriteLine("--------------------------");
            // Console.WriteLine($"1. {item1}\t\t: {price1:0.00} TL");
            // Console.WriteLine($"2. {item2}\t\t: {price2:0.00} TL");
            // Console.WriteLine($"3. {item3}\t\t: {price3:0.00} TL");
            // Console.WriteLine("---------------------------");
            // Console.WriteLine($"Ara Toplam\t: {totalPrice:0.00} TL");
            // Console.WriteLine($"KDV (%20)\t: {kdv:0.00} TL");
            // Console.WriteLine($"GENEL TOPLAM\t: {lastPrice:0.00} TL");
            // Console.WriteLine("--------------------------");
            #endregion

            #region day2 DISCOUNTED MARKET AND IF-ELSE LOGIC

            Console.WriteLine("---WELCOME TO MY MARKET---");
            Console.WriteLine("--------------------------");

            Console.Write("1. item name: ");
            string item1 = Console.ReadLine();
            Console.Write("1. item price: ");
            double price1 = double.Parse(Console.ReadLine());
            Console.Write("1. item count: ");
            int count1 = int.Parse(Console.ReadLine()); 

            Console.Write("2. item name: ");
            string item2 = Console.ReadLine();
            Console.Write("2. item price: ");
            double price2 = double.Parse(Console.ReadLine());
            Console.Write("2. item count: ");
            int count2 = int.Parse(Console.ReadLine()); 

            Console.Write("3. item name: ");
            string item3 = Console.ReadLine();
            Console.Write("3. item price: ");
            double price3 = double.Parse(Console.ReadLine());
            Console.Write("3. item count: ");
            int count3 = int.Parse(Console.ReadLine()); 

            double totalPrice = 0;
            totalPrice = (price1*count1) + (price2*count2) + (price3*count3);
            double discountedPrice=0;
            double kdv=0;
            double lastPrice=0;
            if (totalPrice >= 500)
            {
                discountedPrice = totalPrice*0.90;
                kdv = discountedPrice * 0.20;
                lastPrice = discountedPrice + kdv;
            }
            else
            {
                Console.WriteLine("Reach 500 TL and get a 10% discount on your next purchase!");
                    kdv = totalPrice * 0.20;
                    lastPrice = totalPrice + kdv;
            }

            Console.Write("Press 1 for cash, 2 for credit card: ");
            int odeme = int.Parse(Console.ReadLine());
            if (odeme == 1) 
            {
                Console.WriteLine("Cash payment selected. Extra 5 TL discount is applied.");
                lastPrice = lastPrice - 5;
            }
            else if (odeme == 2)
            {
                Console.WriteLine("Payment by credit card was selected.");
            }
            else 
            {
                Console.WriteLine("You made an invalid selection; the payment was processed as a credit card.");
            }


            Console.WriteLine("--------------------------");
            Console.WriteLine($"1. {item1}: {price1:0.00} TL");
            Console.WriteLine($"2. {item2}: {price2:0.00} TL");
            Console.WriteLine($"3. {item3}: {price3:0.00} TL");
            Console.WriteLine("---------------------------");
            if(discountedPrice == 0)
            {
                Console.WriteLine($"Subtotal\t: {totalPrice:0.00} TL");
            }
            else
            {
                Console.WriteLine($"Subtotal\t: {discountedPrice:0.00} TL");
            }
            Console.WriteLine($"VAT (20%)\t: {kdv:0.00} TL");
            Console.WriteLine($"GRAND TOTAL\t: {lastPrice:0.00} TL");
            Console.WriteLine("--------------------------");



            #endregion



        }
    }
}
