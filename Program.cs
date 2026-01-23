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
            // double tax;
            // tax = totalPrice * 0.20;

            // double lastPrice = totalPrice + tax;

            // Console.WriteLine("--------------------------");
            // Console.WriteLine($"1. {item1}\t\t: {price1:0.00} TL");
            // Console.WriteLine($"2. {item2}\t\t: {price2:0.00} TL");
            // Console.WriteLine($"3. {item3}\t\t: {price3:0.00} TL");
            // Console.WriteLine("---------------------------");
            // Console.WriteLine($"Subtotal\t: {totalPrice:0.00} TL");
            // Console.WriteLine($"Tax (20%)\t: {tax:0.00} TL");
            // Console.WriteLine($"GRAND TOTAL\t: {lastPrice:0.00} TL");
            // Console.WriteLine("--------------------------");
            #endregion

            #region day2 DISCOUNTED MARKET AND IF-ELSE LOGIC

            // Console.WriteLine("---WELCOME TO MY MARKET---");
            // Console.WriteLine("--------------------------");

            // Console.Write("1. item name: ");
            // string item1 = Console.ReadLine();
            // Console.Write("1. item price: ");
            // double price1 = double.Parse(Console.ReadLine());
            // Console.Write("1. item count: ");
            // int count1 = int.Parse(Console.ReadLine()); 

            // Console.Write("2. item name: ");
            // string item2 = Console.ReadLine();
            // Console.Write("2. item price: ");
            // double price2 = double.Parse(Console.ReadLine());
            // Console.Write("2. item count: ");
            // int count2 = int.Parse(Console.ReadLine()); 

            // Console.Write("3. item name: ");
            // string item3 = Console.ReadLine();
            // Console.Write("3. item price: ");
            // double price3 = double.Parse(Console.ReadLine());
            // Console.Write("3. item count: ");
            // int count3 = int.Parse(Console.ReadLine()); 

            // double totalPrice = 0;
            // totalPrice = (price1*count1) + (price2*count2) + (price3*count3);
            // double discountedPrice=0;
            // double tax=0;
            // double lastPrice=0;
            // if (totalPrice >= 500)
            // {
            //     discountedPrice = totalPrice*0.90;
            //     tax = discountedPrice * 0.20;
            //     lastPrice = discountedPrice + tax;
            // }
            // else
            // {
            //     Console.WriteLine("Reach 500 TL and get a 10% discount on your next purchase!");
            //         tax = totalPrice * 0.20;
            //         lastPrice = totalPrice + tax;
            // }

            // Console.Write("Press 1 for cash, 2 for credit card: ");
            // int odeme = int.Parse(Console.ReadLine());
            // if (odeme == 1) 
            // {
            //     Console.WriteLine("Cash payment selected. Extra 5 TL discount is applied.");
            //     lastPrice = lastPrice - 5;
            // }
            // else if (odeme == 2)
            // {
            //     Console.WriteLine("Payment by credit card was selected.");
            // }
            // else 
            // {
            //     Console.WriteLine("You made an invalid selection; the payment was processed as a credit card.");
            // }


            // Console.WriteLine("--------------------------");
            // Console.WriteLine($"1. {item1}: {price1:0.00} TL");
            // Console.WriteLine($"2. {item2}: {price2:0.00} TL");
            // Console.WriteLine($"3. {item3}: {price3:0.00} TL");
            // Console.WriteLine("---------------------------");
            // if(discountedPrice == 0)
            // {
            //     Console.WriteLine($"Subtotal\t: {totalPrice:0.00} TL");
            // }
            // else
            // {
            //     Console.WriteLine($"Subtotal\t: {discountedPrice:0.00} TL");
            // }
            // Console.WriteLine($"Tax (20%)\t: {tax:0.00} TL");
            // Console.WriteLine($"GRAND TOTAL\t: {lastPrice:0.00} TL");
            // Console.WriteLine("--------------------------");

            #endregion

            #region day3 Unlimited Market and Stock Control


            Console.WriteLine("---WELCOME TO MY MARKET---");
            Console.WriteLine("--------------------------");

            int i=1;
            string itemName = "";
            double totalPrice = 0;
            while(itemName != "exit" && itemName != "Exit")
            {
                Console.Write($"{i}. item name (type exit to quit): ");
                itemName = Console.ReadLine() ?? "";
                if (itemName != "exit" && itemName != "Exit")
                {
                    Console.Write($"{itemName} price: ");
                    double price = double.Parse(Console.ReadLine() ?? "0");
        
                    Console.Write($"{itemName} count: ");
                    int count = int.Parse(Console.ReadLine() ?? "0");

                    totalPrice += (price * count); 
                    i++;
                }
            }
            

            double discountedPrice=0;
            double tax=0;
            double lastPrice=0;
            if (totalPrice >= 500)
            {
                discountedPrice = totalPrice*0.90;
                tax = discountedPrice * 0.20;
                lastPrice = discountedPrice + tax;
            }
            else
            {
                Console.WriteLine("Reach 500 TL and get a 10% discount on your next purchase!");
                    tax = totalPrice * 0.20;
                    lastPrice = totalPrice + tax;
            }

            Console.Write("Press 1 for cash, 2 for credit card: ");
            int paymentMethod = int.Parse(Console.ReadLine() ?? "2");
            if (paymentMethod == 1) 
            {
                Console.WriteLine("Cash payment selected. Extra 5 TL discount is applied.");
                lastPrice = lastPrice - 5;
            }
            else if (paymentMethod == 2)
            {
                Console.WriteLine("Payment by credit card was selected.");
            }
            else 
            {
                Console.WriteLine("You made an invalid selection; the payment was processed as a credit card.");
            }


            Console.WriteLine("---------------------------");
            if(discountedPrice == 0)
            {
                Console.WriteLine($"Subtotal\t: {totalPrice:0.00} TL");
            }
            else
            {
                Console.WriteLine($"Subtotal\t: {discountedPrice:0.00} TL");
            }
            Console.WriteLine($"Tax (20%)\t: {tax:0.00} TL");
            Console.WriteLine($"GRAND TOTAL\t: {lastPrice:0.00} TL");
            Console.WriteLine("--------------------------");

            #endregion
        }
    }
}
