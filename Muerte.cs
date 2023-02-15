using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal interface Muerte
    { 
        //Se crea crean compaortamientos que reciban y devuelvan parametros
     string Morir(int nacimiento, int fallecimiento, string causa);
     string Reencarna( string revivio);
    }
}
