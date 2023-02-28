using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colibri ocolibri = new Colibri();
            Console.WriteLine(ocolibri.Morir(2022,2023,"hambre"));
            Console.WriteLine(ocolibri.Reencarna("wuju"));
            ocolibri.atacar();
            ocolibri.volar();

            Vaca ovaca = new Vaca();
            Console.WriteLine(ovaca.Morir(2015,2023,"devorada"));
            Console.WriteLine(ovaca.Reencarna("vaca vive"));
            ovaca.amamanta();
            ovaca.comer();

            Console.ReadKey();
        }        
    }
}
