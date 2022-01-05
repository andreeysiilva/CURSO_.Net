using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Textos.");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string texto = "Alura Cursos de Tecnologia " + 2022;
            string cursosProgramacao = 
@"- .NET
- Java
- JavaScript";

            Console.WriteLine(texto);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
