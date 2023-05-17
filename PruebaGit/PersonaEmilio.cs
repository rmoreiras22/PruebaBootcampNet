using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    public class PersonaEmilio
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Documento { get; set; }
        public DateTime Nacimiento { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Documento: " + Documento);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Fecha de nacimiento: " + Nacimiento.ToString("dd/MM/yyyy"));
           
        }
    }
}
