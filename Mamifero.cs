using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Mamifero : Animal
    {     
        virtual public void amamanta()
        {
            Console.WriteLine("dar leche");
        }
    }
}
