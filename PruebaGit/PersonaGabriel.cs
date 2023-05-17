using System;

namespace PruebaGit
{
    public class PersonaGabriel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public string Telefono { get; set; }

        public PersonaGabriel()
        {
        }

        public PersonaGabriel(string nombre, string apellido, string documento, string direccion, DateTime nacimiento, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Direccion = direccion;
            Nacimiento = nacimiento;
            Email = email;
        }

        public void CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - Nacimiento.Year;

            // Verificar si ya ha cumplido años en el año actual
            if (ahora.Month < Nacimiento.Month || (ahora.Month == Nacimiento.Month && ahora.Day < Nacimiento.Day))
            {
                edad--;
            }

            Edad = edad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Documento: " + Documento);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Fecha de nacimiento: " + Nacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Email: " + Email);
<<<<<<< HEAD
            Console.WriteLine("Telefono: " + Direccion);

=======
            Console.WriteLine("Telefono: " + Telefono);
>>>>>>> develop
        }
    }
}
