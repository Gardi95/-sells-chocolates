using System;

namespace sells_chocolates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char er;
            for(;true;)
            {
                int a = 2;

                double b, c, d = 0;


                Console.WriteLine("Please Enter the Amubnt of chocoletes: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (b >= 20)
                {
                    c = a * b;
                    d = c * 0.4;
                    Console.WriteLine("praise befor deskawnd: " + c);
                    Console.WriteLine("praise after deskawnd: " + d);

                }
                else if (b >= 10 && b <= 19)
                {
                    c = a * b;
                    d = c * 0.3;
                    Console.WriteLine("praise befor deskawnd: " + c);
                    Console.WriteLine("praise after deskawnd: " + d);

                }
                else if (b >= 5 && b <= 10)
                {
                    c = a * b;
                    d = c * 0.2;
                    Console.WriteLine("praise befor deskawnd: " + c);
                    Console.WriteLine("praise after deskawnd: " + d);
                }
                else if (b <= 5)
                {
                    c = a * b;
                    d = c;
                    Console.WriteLine("praise befor deskawnd: " + c);
                    Console.WriteLine("praise after deskawnd: " + d);
                }

                Console.WriteLine("please enter q to quit");
                er = char.Parse(Console.ReadLine());
                if(er == 'q')
                {
                    break;
                }
            }
            
        }
    }
}
