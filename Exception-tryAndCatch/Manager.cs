using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception_tryAndCatch
{
    internal class Manager
    {
        private Manager() { }

        private readonly static Manager _instance = new Manager();
        public static Manager INSTANCE
        {
            get
            {
                return _instance;
            }
        }

        public void Ex01()
        {
            Console.WriteLine("Please enter 2 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result;

            try
            {
                result = a / b;
                Console.WriteLine("The result is:{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("{0}. The number is 0", ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Ex02()
        {
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());
            int result;

            try
            {
                result = 770 / num;
                Console.WriteLine("The result is:{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                while (num == 0)
                {                  
                    Console.WriteLine("Please enter another number:");
                    num = int.Parse(Console.ReadLine());
                }

                result = 770 / num;
                Console.WriteLine("The result is:{0}", result);
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Ex03()
        {
            string[] str;

            try
            {
                str = File.ReadAllLines(@"C:\Users\97252\source\repos\Exception-tryAndCatch\Exception-tryAndCatch\Ex02.txt");
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Read10Strings()
        {
            string[] str = new string[10];
            int sumStr = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a string:");
                str[i] = Console.ReadLine();
                sumStr += str[i].Length;

                if (sumStr > 100)
                {
                    throw new ArgumentException("You Entered strings with a total of more than 100 chrarcters");
                }
            }
        }
    }
}
