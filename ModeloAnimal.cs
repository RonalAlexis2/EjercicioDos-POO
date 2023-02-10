using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    internal class ModeloAnimal
    {// se crean varibles privadas para realizar el Get y Set
        private string Nombre;
        private string Habitat;
        private string Color;
        private Boolean Domestico;
        private string Grupo;

        // se crean get y set
       public string getnombre()
        {
            return Nombre;
        }

        public void setnombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }

        public string gethabitat()
        {
            return Habitat;
        }

        public void sethabitat(string _Habitat)
        {
            this.Habitat = _Habitat;
        }
        public string getcolor()
        {
            return Color;
        }

        public void setcolor(string _Color)
        {
            this.Color = _Color;
        }
        public Boolean getdomestico()
        {
            return Domestico;
        }

        public void setdomestico(Boolean _Domestico)
        {
            this.Domestico = _Domestico;
        }
        public string getgrupo()
        {
            return Grupo;
        }

        public void setgrupo(string _Grupo)
        {
            this.Grupo = _Grupo;
        }
    }
}
