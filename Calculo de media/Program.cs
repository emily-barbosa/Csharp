

using System;

namespace Calculo_de_media
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
        Console.WriteLine("Calculo de media");
            Console.WriteLine("Digite a primeira nota");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            n3=int.Parse(Console.ReadLine());
            //processo de soma de número quebrado 1 fase//
            float resultado = (float)(n1 + n2 + n3) / 3; //não esquecer de colocar o parenteses para manter a regra matemática// /segunda fase da conta//
            Console.WriteLine($"O resultado é:{resultado}");
        }
    }
}
