using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Animal
    {
        //comportamientos de animales
        virtual public void comer()
        {
            Console.WriteLine("padre comiendo");
        }
        virtual public void reproducirse()
        {
            Console.WriteLine("padre reproduciendo");
        }
       virtual public void atacar()
        {
            Console.WriteLine("padre atacando");
        }       
    }
}
