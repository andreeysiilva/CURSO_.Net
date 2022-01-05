using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario = 1200.50;

            // O int é uma variavel que suporta valores ate 32 bits
            // CASTING TROCA DE UM VALOR POR OUTRO Ex. double PARA int
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long e uma variavel que suporta valores ate 64 bits
            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            // O short e uma variavel que suporta valores ate 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);



            Console.ReadLine();
        }
    }
}
