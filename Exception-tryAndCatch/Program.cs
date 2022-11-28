using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_tryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager.INSTANCE.Ex01();
            //Manager.INSTANCE.Ex02();
            //Manager.INSTANCE.Ex03();

            try
            {
                Manager.INSTANCE.Read10Strings();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
           

            Console.ReadLine();
        }
    }
}
