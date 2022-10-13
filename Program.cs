using System;
using System.Threading;
namespace TP7_ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            float n,nf;
            string r;
            
            bienvenida();
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese 1 si quiere Convertir Dolares a Pesos Argentinos");
                Console.WriteLine("Ingrese 2 si quiere Convertir Euros a Pesos Argentinos");
                Console.WriteLine("O Ingrese 3 Si quiere Salir del programa");
                r = Console.ReadLine();

                switch(r)
                {
                    case "1":
                        Console.WriteLine("Ingrese la cantidad de Dolares que quiere convertir: ");
                        n = Convert.ToSingle(Console.ReadLine());
                        Console.Clear();
                        nf = dolarAPesosArgentinos(n);
                        Console.WriteLine("Su conversion de {0} Dolares a Pesos Argentinos es: {1}",n, nf);
                        Console.ReadKey();
                    break;

                    case "2":
                        Console.WriteLine("Ingrese la cantidad de Euros que quiere convertir: ");
                        n = Convert.ToSingle(Console.ReadLine());
                        Console.Clear();
                        nf = euroAPesosArgentinos(n);
                        Console.WriteLine("Su conversion de {0} Euros a Pesos Argentinos es: {1}",n, nf);
                        Console.ReadKey();
                    break;
                }
            } while(r != "3");
        }

        static void bienvenida()
        {
           Console.WriteLine("Bienvenido al converso de Dolar/Euro a Pesos Argentinos");
        }



        static float dolarAPesosArgentinos(float num)
        {
            float dolar, pesos;
            dolar = 151.29f;
            pesos = num * dolar;
            return pesos;
        }

        static float euroAPesosArgentinos(float num)
        {
            float euro, pesos;
            euro = 147.91f;
            pesos = num * euro;
            return pesos;
        }

        
    }
}
