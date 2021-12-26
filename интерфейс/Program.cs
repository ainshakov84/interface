using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интерфейс_ШИФР
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AChiper aChiper = new AChiper();
            Console.WriteLine(aChiper.Encod("PRIVET ALBINA"));
            Console.WriteLine(aChiper.Decode("QSJWFU BMCJOB"));
            BChiper bChiper = new BChiper();
            Console.WriteLine(bChiper.Encod("PRIVET ALSU"));
            Console.WriteLine(bChiper.Decode("KIREVG ZOHF"));
            Console.ReadKey();
        }
    }
}
