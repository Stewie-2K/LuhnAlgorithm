using System;

namespace luhn
{
    class Program
    {
        static void Main(string[] args)
        {
            string ccnum;
            int ins = 0;
            int total = 0;

            Console.WriteLine("Enter your credit card number.");
            ccnum = Console.ReadLine();

            for (int x = 0; x < 16; x++)
            {
                ins = Convert.ToInt32(Convert.ToString(ccnum[x]));
                if ((x % 2) == 0)
                {
                    ins *= 2;
                    if (ins > 9)
                    {
                        ins -= 9;
                    }
                }
                total += ins;
            }
            Console.WriteLine(total);
            if ((total % 10)==0)
            {
                Console.WriteLine("This credit card is valid.");
            }else
            {
                Console.WriteLine("This credit card is invalid.");
            }

        }
    }
}
