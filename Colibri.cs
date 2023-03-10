using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Colibri : Ave, Muerte
    {
        //creamos variable para guardar informacion del constructor        
           ModeloAnimal guardarinfo;

        //se sobre escribe metodo comer
        public override void comer()
        {
            Console.WriteLine("el colibri come");
        }
        //se crea comportmiento diferente
        public void volar()
        {
            Console.WriteLine("el colibri vuela");
        }

        //se reciben los parametros de muerte y se calcula cuanto vivio
        public string morir(int nacimiento, int fallecimiento, string causa)
        {
            int calculo = fallecimiento -nacimiento;           
            return "La fecha de su muerte es: " + fallecimiento.ToString(), "vivió " + calculo.ToString(), "años y la causa de la muerte es" + causa;
        }  
        //se retorna el mismo string que recibimos
        public string reencarna(string revivio)
        {
            return revivio;
        }      
        //constructor que no recibe parametros, pero llena info de ModeloAnimal
        public Colibri()
        { 
            ModeloAnimal ocolibri = new ModeloAnimal();

            ocolibri.setnombre("colibrí exotico");
            ocolibri.sethabitat("Aire");
            ocolibri.setcolor("verde");           
            ocolibri.setdomestico(false);
            ocolibri.setgrupo("vertebrado");

            guardarinfo = ocolibri;
        }
        //Sobrecargamos el constructor con la informacion llena del primer constructor guradado en una variable
        public Colibri(ModeloAnimal infocoli)
        {
            guardarinfo = infocoli;
        }
    }
}
