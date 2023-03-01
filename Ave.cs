using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Ave : Animal
    { 
        //sobre escribimos atacar de la clase padre
        override public void atacar()
        {
            Console.WriteLine("el ave ataca");
        }         

        //creamos un nuevo metodo que reciba parametros
        public string cantar( string trinar)
        {
            trinar = "El ave esta trinando" + trinar;
            return trinar;
        }
    }
}
