using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[20];
            Console.WriteLine("Ingresa 20 Numeros");
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("ingresa el numero "+(i+1)+": ");
                datos[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            string ans = "";
            Numeros numeros = new Numeros(datos);
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{datos[i]}      {numeros.Solucion()[i]}\n");
            }
        }
    }
}
