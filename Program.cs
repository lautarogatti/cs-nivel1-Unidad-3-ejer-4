using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;
            Console.WriteLine("Bienvenido al identificador de numero menor");
            Console.WriteLine("Por favor ingrese el primer numero a comparar");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo numero a comparar");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer numero a comparar");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el cuarto numero a comparar");
            n4 = int.Parse(Console.ReadLine());

            menor = n1;
            if(n2 < menor){
                menor = n2;
            }
            if(n3 < menor){
                menor = n3;
            }
            if(n4 < menor){
                menor = n4;
            }
            Console.WriteLine("De los numeros ingresados: " + n1 + ", " + n2 + ", " + n3 + ", " + n4 + ", el menor es: " + menor);
        }
    }
}
