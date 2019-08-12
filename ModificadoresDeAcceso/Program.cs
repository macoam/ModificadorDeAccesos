using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();

            cliente.Nombre = "Chayanne";
            cliente.Telefono = "131369";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Teléfono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "123456789009876543";
                Console.WriteLine("Curp: " + cliente.Curp);
            }
            catch(Exception e)
            {
                Console.WriteLine("La CURP debe ser de 18 caractéres");
            }

           

            Console.ReadLine();
        }
    }
}
