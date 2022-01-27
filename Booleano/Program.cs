using System;


namespace Booleano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com bool");

            int idadeJoao = 16;
            int quantidadePessoa = 1;
            bool acompanhado;

            if (quantidadePessoa >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar!");

            }

        }
    }
}
