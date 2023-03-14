using Projetos08.App;
using System;

namespace Projetos08
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Olá usuário, vamos brincar? Você irá digitar três valores (inteiros):\n");
            //int.Parse(Console.ReadLine());
            
            int primeiroValor, segundoValor, terceiroValor;
            
            Console.WriteLine("Digite o primeiro valor:");
            primeiroValor = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor:");
            segundoValor = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor:");
            terceiroValor = int.Parse(Console.ReadLine());
            
            Calculo calculo = new Calculo(primeiroValor, segundoValor, terceiroValor);

                Console.WriteLine("\nO resultado é: " + calculo.calcularSoma() + ".");
         }
    }
}
