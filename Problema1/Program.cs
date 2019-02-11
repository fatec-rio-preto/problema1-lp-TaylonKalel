using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            float n3 = float.Parse(Console.ReadLine());

            float result = n1 * 0.1f + n2 * 0.3f + n3 * 0.6f;

            Console.WriteLine("A média é: " + result);
        }
    }
}
