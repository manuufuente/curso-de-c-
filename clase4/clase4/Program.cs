using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4
{
    class Persona
    {

        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;

        }
    }
        
        
        
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList loquesea = new ArrayList();
            Persona a = new Persona("Jose");
            Persona b = new Persona("Maria");
            Persona c = new Persona("pedro");

            loquesea.Add(a);
            loquesea.Add(c);
            loquesea.Add(b);

            loquesea.Add(10);
            loquesea.Add(20);
            loquesea.Add("HOLA A TODOS");

            foreach (object item in loquesea)
            {
                if(item.GetType()== typeof(Persona))
                {
                    Persona per = (Persona)item;

                    Console.WriteLine(per.Nombre);

              
                }
                if (item.GetType() == typeof(Int32))
                {
                    Console.WriteLine((int)item);
                }
                if (item.GetType() == typeof(System.String))
                {
                    Console.WriteLine((string)item);
                }
                
            }Console.ReadKey();

        }
    }
}
