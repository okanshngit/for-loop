using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ekrana bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int oddSum=0;
            int evenSum=0;


            //İstenilen sayıya kadar olan tek sayıları yazdıran loop.
            for (int i = 0; i <= sayi; i++)
            {
                if(i%2 !=0)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıları yazdıran döngü

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 !=0)
                    oddSum += i;
                
                if(i%2 ==0)
                    evenSum += i;

            }

            Console.WriteLine("Tek sayıların toplamı: "+ oddSum);
            Console.WriteLine("Çift sayıların toplamı: "+evenSum);

            for (int i = 1; i <= 10; i++)
            {
                if(i ==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if(i ==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
