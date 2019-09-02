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

            Platillos a = new Platillos("Tacos de asada", "ASD1", "Unos tacos bien prrones asada", 20);
            Platillos b = new Platillos("Quesadilla", "ASD2", "Unas quesadillas con carne y QUESO", 10);

            platillos.Add(a);
            platillos.Add(b);

        }
    }
}
