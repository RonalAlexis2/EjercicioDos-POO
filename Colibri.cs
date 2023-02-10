using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Colibri : Ave, Muerte
    {
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
        public string Morir(int nacimiento, int faleccimiento, string causa)
        {
            int calculo;
            calculo = nacimiento - faleccimiento;
            Console.WriteLine("La fecha de su muerte es: " + faleccimiento, "vivio "+ calculo, "años y la causa de la muerte es"+ causa);
            string m=Console.ReadLine();
            return m;
        }  
        //se retorna el mismo string que recibimos
        public string Reencarna(string revivio)
        {
            return revivio;
        }
        //creamos variable para guardar informacion del constructor        
        ModeloAnimal guardarinfo;
        //constructor que no recibe parametros, pero llena info de ModeloAnimal
        public Colibri()
        { 
            ModeloAnimal ocolibri=new ModeloAnimal();

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
