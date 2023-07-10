using System;

namespace TPFinal_Luna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que 
            // corta cuando se ingresa un cero. A partir de dichos datos informar:
            //    a. El mayor de los números pares.
            //    b. La cantidad de números impares.
            //    c. El menor de los números primos.

            int n, mayorNPar = 0, menorNPrimo = 0, conImpares = 0;
            bool banderaPar = false, banderaPrimo = false;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 != 0)
                    conImpares++;
                else if (banderaPar == false){
                    mayorNPar = n;
                    banderaPar = true;
                } 
                else if (n > mayorNPar)
                    mayorNPar = n;
                
                if (esPrimo(n) == true) {
                    if (banderaPrimo == false) {
                        menorNPrimo = n;
                        banderaPrimo = true;
                    } 
                    else if (n < menorNPrimo)
                        menorNPrimo = n;
                }

                Console.WriteLine("Ingrese otro número o un cero para terminar: ");
                n = int.Parse(Console.ReadLine());
            }

            if (banderaPar == false)
                Console.WriteLine("No se ingresaron números pares.");
            else
                Console.WriteLine("El mayor de los números pares es: " + mayorNPar);

            Console.WriteLine("La cantidad de números impares ingresados es: " + conImpares);

            if (banderaPrimo == false)
                Console.WriteLine("No se ingresaron números primos.");
            else
                Console.WriteLine("El menor de los números primos es: " + menorNPrimo);
            
        }

        // FUNCION AUXILIAR
        static bool esPrimo(int n)
        {
            int j = 1, con = 0;

            while (j <= n)
            {
                if (n % j == 0)
                    con++;
                j++;
            }
            
            if (con == 2)
                return true;
            else
                return false;
        }
    }
}
