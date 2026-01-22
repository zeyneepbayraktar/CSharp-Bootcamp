namespace marketAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region day1 TEMEL MARKET OTOMASYONU
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

            #region day2 İNDİRİMLİ MARKET VE IF-ELSE MANTIĞI

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
                Console.WriteLine("Bir sonraki alisverisinizde %10 indirim kazanmak icin 500 TL barajini gecin!");
                    kdv = totalPrice * 0.20;
                    lastPrice = totalPrice + kdv;
            }

            Console.Write("Odemeyi nasil yapacaksiniz('Nakit icin 1, kredi karti icin 2'yi tuslayiniz'): ");
            int odeme = int.Parse(Console.ReadLine());
            if (odeme == 1) 
            {
                Console.WriteLine("Nakit odeme secildi. 5 TL ekstra indirim uygulaniyor.");
                lastPrice = lastPrice - 5;
            }
            else if (odeme == 2)
            {
                Console.WriteLine("Kredi karti ile ödeme secildi.");
            }
            else 
            {
                Console.WriteLine("Gecersiz secim yaptiniz, odeme kredi karti olarak isleme alindi.");
            }


            Console.WriteLine("--------------------------");
            Console.WriteLine($"1. {item1}: {price1:0.00} TL");
            Console.WriteLine($"2. {item2}: {price2:0.00} TL");
            Console.WriteLine($"3. {item3}: {price3:0.00} TL");
            Console.WriteLine("---------------------------");
            if(discountedPrice == 0)
            {
                Console.WriteLine($"Ara Toplam\t: {totalPrice:0.00} TL");
            }
            else
            {
                Console.WriteLine($"Ara Toplam\t: {discountedPrice:0.00} TL");
            }
            Console.WriteLine($"KDV (%20)\t: {kdv:0.00} TL");
            Console.WriteLine($"GENEL TOPLAM\t: {lastPrice:0.00} TL");
            Console.WriteLine("--------------------------");



            #endregion



        }
    }
}
