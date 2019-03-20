using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desenvolva um Algoritmo que lê o nome e as 4 notas bimestrais de um aluno. 
//Em seguida o Algoritmo calcula e escreve a média obtida e se o aluno foi aprovado ou reprovado. Considere a média 5 para aprovação.
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, media;
            string aluno;

            //perguntar nome do aluno
            Console.WriteLine("Informe o nome do aluno");
            aluno = (Console.ReadLine());

            //informar as 4 notas
            Console.WriteLine("Informe a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());

            //formula do calculo
            media = (n1 + n2 + n3 + n4) / 4;

            //Informaçao da media do aluno
            Console.WriteLine("A média do(a) aluno(a) " + aluno + " foi: " + media);

            //condiçao para aprovação
            if (media >= 5)
            {
                Console.WriteLine(aluno + " Aprovado(a) !!!");
            }
            else
            {
                Console.WriteLine(aluno + " Reprovado(a) !!!");
            }

            //precionar para sair do programa
            Console.ReadKey();


        }
    }
}
