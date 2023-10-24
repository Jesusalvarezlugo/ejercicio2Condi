using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Condi.servicios
{
    internal class numeroImplementacion : numeroInterfaz
    {
        public int PedirNumero()
        {
            int numero;

            Console.WriteLine("Introduce un número: ");
            numero = Int32.Parse(Console.ReadLine());

            return numero;
        }
    }
}
