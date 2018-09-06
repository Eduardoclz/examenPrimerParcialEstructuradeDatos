using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Ingredientes ingredientes { get; set; }
        public float Precio
        {
            get
            {
                return Precio;
                    
            }
    set
            {
                if (Precio < 50)
                {
                    Console.WriteLine("precio incorrecto");
                }
            
            }
        }


    }
}

