using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Platillos
    {
        public string NombreP;
        public string IdentificadorP;
        public string Descripcion;
        public int Precio;
        public List<Ingredientes> ingredientes;

        public Platillos(string nombreP, string identificadorP, string descripcion, int precio)
        {
            NombreP = nombreP;
            IdentificadorP = identificadorP;
            Descripcion = descripcion;
            Precio = precio;
            ingredientes = new List<Ingredientes>();
        }
    }
}
