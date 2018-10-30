using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arraysdeinteros = new int[] { 1,2,3,4,5,6};
            foreach (int numero in arraysdeinteros)
            {
                Console.WriteLine(numero);
            }
            IEnumerator ienum = arraysdeinteros.GetEnumerator();

            int suma = 0;
            while (ienum.MoveNext())
            {
                int m = (int)ienum.Current; 
                suma += m;

            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
