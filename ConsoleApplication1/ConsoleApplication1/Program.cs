using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type a number to get tables from 2 till ur number!");
            int j = int.Parse(Console.ReadLine());
            Program prg = new Program();

            prg.meth(j);
        }

        public void meth(int i)
        {

            if (i != 1)
            {
                meth(i - 1);
                Console.WriteLine("----------------");
                for (int k = 1; k <= 10; k++)
                {

                    Console.WriteLine(i + "X" + k + "=" + k * i);
                }
            }


        }
    }
}
