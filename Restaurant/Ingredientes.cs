using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Ingredientes
    {
        public string Nombre;
        public string Identificador;

        public Ingredientes(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }
    }
}
