using ejercicio2Condi.servicios;

namespace ejercicio2Condi.controladores
{
    class Program
    {
        internal static void Main(string[] args)
        {
            int numero;
            numeroInterfaz mi  = new numeroImplementacion();

            numero = mi.PedirNumero();
            int raiz = (int)Math.Sqrt(numero);

            if (numero == raiz*raiz)
            {
                Console.WriteLine("La raiz del numero {0} es correcta",numero);
            }

            else
            {
                Console.WriteLine("La raiz del numero {0} no es correcta",numero);
            }
        }
    }
}
