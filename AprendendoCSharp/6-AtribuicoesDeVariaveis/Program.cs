using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Atribuições de Variaveis");

            int idade = 27;
            int idadeAndrey = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeAndrey);


            Console.ReadLine();
        }
    }
}
