using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dominios = new Dictionary<string, string>();

            dominios.Add ("ar","Argentina");
            dominios.Add("al", "Alemania");
            dominios.Add("cl", "Colombia");
            dominios.Add("rs", "Rusia");

            Console.WriteLine(dominios["ar"]);// Me imprime argentina.

            //dominios.count : para saber cuantos elementos tiene el dominio.

            List<string> keys = new List<string>(dominios.Keys);
            foreach (string key in keys)   //me parece que el foreach recorre todo el vector. Preguntar a Seba.
            {
                Console.WriteLine("{0}", key);
            }

            List<string> values = new List<string>(dominios.Values);
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
            foreach (KeyValuePair<string, string> kvp in dominios)
            {
                Console.WriteLine("Key: {0} - value: {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();


        }
    }
}
