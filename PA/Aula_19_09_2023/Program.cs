using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, soma, media;

            Console.Write("Informe a 1º Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("informe a 2 nota: ")
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("informe a 3 nota: ")
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("informe a 4 nota: ")
             nota4 = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;

            media = soma / 4;

            //0.00 a 4.99 - Reprovado
            //5.00 a 6.99 - Recuperacao
            //7.00 a 10 - Aprovado


            if (media < 5)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Poxa que pena!!!");

            }
            else if (media < 7)
            {
                Console.WriteLine("Recuperacao");
                Console.WriteLine("Coragem!!!");
                {

                else    
                }

                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabens!!!");

            }





        }
    }
}
