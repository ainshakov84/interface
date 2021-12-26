using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфесй_домашнее_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 2;
            int r = 2;
            ArithProgression arith = new ArithProgression();
            arith.setStart(s);
            arith.setStep(r);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("________________________________");
            MathProgression math = new MathProgression();
            math.setStart(s);
            math.setStep(r);
            Console.WriteLine(math.getNext());
            Console.WriteLine(math.getNext());
            Console.WriteLine(math.getNext());
            math.reset();
            Console.WriteLine(math.getNext());
            Console.WriteLine(math.getNext());

            Console.ReadKey();
        }
    }
}
