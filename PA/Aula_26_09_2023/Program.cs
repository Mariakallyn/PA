using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, soma, media, percFreg;

            Console.Write("Informe a 1º Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("informe a 2 nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("informe a 3 nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("informe a 4 nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o % de Frequencia: ");
            percFreg = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;

            media = soma / 4;

            //0.00 a 4.99 e % Frequencia <= 20 - Reprovado
            //5.00 a 6.99 e % Frequencia <= 40  - Recuperacao
            //7.00 a 10 e % Frequencia  >  60 -Aprovado

            if (media < 5 && percFreg <= 40)
            {

                Console.WriteLine("Aluno Aprovado");
            } else if (media < 7 && percFreg <= 60)

            {
                Console.WriteLine("Aluno em Recuperação");
            } else if (media <= 10 && percFreg > 60) ;
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Sera analisado pela Secretaria academica")

            }




            }
    }
}
