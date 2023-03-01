using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Vaca : Mamifero, Muerte
    {
        //creamos variable para guardar informacion del constructor        
        ModeloAnimal guardarinfoVaca;

        //se sobrescribe el metodo de mamimero amamantar
        public override void amamanta()
        {
            Console.WriteLine("la vaca da leche");
        }
        //logica para calcular murte y pares
        public string morir(int nacimiento, int fallecimiento, string causa)
        {
            int calculo = (fallecimiento - nacimiento )*2;
            string basenumero;
            
            if (calculo%2 == 0)
            {
              basenumero  = "par";
            }
            else
            {
              basenumero = "impar";
            }     
            
            return "La fecha de su muerte " + fallecimiento.ToString(), "el numero es " + basenumero.ToString(), "vivio" + calculo.ToString(), "años y murio por " + causa;
        }
        //reencarna devuelve el mismo recibido pero concatenado
        public string reencarna(string revivio)
        {
            return revivio + "Tu puedes hacerlo!";
        }
        //constructor que no recibe parametros
        public Vaca()
        {
            ModeloAnimal ovaca = new ModeloAnimal();
            ovaca.setnombre("Vaca");
            ovaca.sethabitat("terrestre");
            ovaca.setcolor("blanca y negra");
            ovaca.setdomestico(false);
            ovaca.setgrupo("vertebrado");

            guardarinfoVaca = ovaca;
        }
    }
}
