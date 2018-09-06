using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFinal { get; set; }
        public Menu menu { get; set; }
        public Platillos Platillos { get; set; }

    }
}
