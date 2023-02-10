using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class Vaca : Mamifero, Muerte
    {    //se sobrescribe el metodo de mamimero amamantar
        public override void amamanta()
        {
            Console.WriteLine("la vaca da leche");
        }
        //logica para calcular murte y pares
        public string Morir(int nacimiento, int faleccimiento, string causa)
        {
            int calculo = nacimiento - faleccimiento;
            calculo = calculo * 2;
            string N;
             if (calculo%2==0)
            {
                N = "par";
            }
            else
            {
                N = "impar";
            }

            Console.WriteLine("La fecha de su muerte " +faleccimiento, "el numero es " + N, "vivio"+ calculo, "años y murio por "+ causa);
            string m = Console.ReadLine();
            return m;
        }
        //reencarna devuelve el mismo recibido pero concatenado
        public string Reencarna(string revivio)
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
        }
    }
}
