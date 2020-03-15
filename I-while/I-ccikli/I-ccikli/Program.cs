using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_ccikli
{
  
    class Program
    {
        static void datain(out double a, out double b, out double toch)
        {
            
            try
            {
                Console.WriteLine("Введите данные:");
                string[] аргументы = Console.ReadLine().Replace('.', ',').Split(' ');
                a = Convert.ToDouble(аргументы[0]);
                b = double.Parse(аргументы[1]);
                toch = double.Parse(аргументы[2]);
            }
            catch
            {
                Console.WriteLine("Введены неверные данные!");
                datain(out a, out b, out toch);
            }
        }
        static void reshenie(double a, double b, double toch)
        {
            var length = b - a;
            var err = length;
            double x=0;
            
            while (err > toch && getF(x)!=0)
            {
                x = (a + b) / 2;
                if (getF(x) * getF(a) < 0) b = x;
                else if(getF(x) * getF(b) < 0) a = x;
                err = (b - a) / length;
            }
            
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            double a, b, toch;
            datain(out a, out b, out toch);
            reshenie(a, b, toch);
            Console.ReadLine();
        }
        static double getF(double x)
        {
                return x - 1 / (3 + Math.Sin(3.6 * x));
        }
    }
}
