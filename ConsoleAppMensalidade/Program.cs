using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.WriteLine("Informe o valor da anuidade: ");
            double anu = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do material: ");
            double mat = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da matricula: ");
            double matri = double.Parse(Console.ReadLine());

            
            while (cont <= 12) 
            {
                double res = anu / 12 + matri + mat;
                matri = 0;
                mat = 0;
                Console.WriteLine("Mensalidade: " + cont + " valor: " + res .ToString("C"));
                cont++;
            }
            Console.ReadKey();
        }
    }
}
