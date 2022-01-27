using System;


namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com escopo");

            int idadeJoao = 16;
            int quantidadePessoa = 1;

            if (idadeJoao >= 18 || quantidadePessoa > 1)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");

            }

        }
    }
}