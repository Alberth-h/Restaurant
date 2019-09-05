using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Platillos> platillos = new List<Platillos>();

            Platillos a1 = new Platillos("Tacos de asada", "ASD1", "Unos tacos bien prrones asada", 40);
            Platillos b1 = new Platillos("Quesadilla", "ASD2", "Unas quesadillas con carne y QUESO", 30);

            platillos.Add(a1);
            platillos.Add(b1);

            //Tacos de asada
            Ingredientes a2 = new Ingredientes("Carne", "CC1");
            Ingredientes b2 = new Ingredientes("Verdura", "CC2");
            Ingredientes c2 = new Ingredientes("Guacamole", "CC3");
            Ingredientes d2 = new Ingredientes("Salsa", "CC4");

            //Quesadillas
            //Ingredientes a2 = new Ingredientes("Carne", "CC1");
            Ingredientes b3 = new Ingredientes("Queso", "CC5");
            //Ingredientes d2 = new Ingredientes("Salsa", "CC4");

            a1.ingredientes.Add(a2);
            a1.ingredientes.Add(b2);
            a1.ingredientes.Add(c2);
            a1.ingredientes.Add(d2);

            b1.ingredientes.Add(a2);
            b1.ingredientes.Add(b3);
            b1.ingredientes.Add(d2);

            foreach (Platillos platillo in platillos)
            {
                Console.WriteLine("Platillo: " + platillo.NombreP);
                Console.WriteLine("ID: " + platillo.IdentificadorP);
                Console.WriteLine("Precio: " + platillo.Precio);
                Console.WriteLine("Descripcion: " + platillo.Descripcion);
                Console.WriteLine("Ingredientes: ");

                foreach (Ingredientes ingredientes in platillo.ingredientes)
                {
                    Console.WriteLine("Ingrediente: " + ingredientes.Nombre);
                    Console.WriteLine("ID: " + ingredientes.Identificador);
                }
            }

            Console.ReadLine();

        }
    }
}
