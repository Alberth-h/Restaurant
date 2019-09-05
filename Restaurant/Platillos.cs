using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Platillos
    {
        public string NombreP {get; set;}
        public string IdentificadorP {get; set;}
        public string Descripcion {get; set;}
        private int _precio;
        public int Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                if((value > 0) && (value < 50))
                {
                    _precio = value;
                }
                else
                {
                    throw new Exception ("Precio excedible");
                }
            }              
        }           
       
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
