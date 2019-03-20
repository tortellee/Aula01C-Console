using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Desenvolva um Algoritmo que lê o nome, as 4 notas bimestrais e o número faltas de um aluno. 
 * Em seguida o Algoritmo calcula e escreve a média obtida e se o aluno foi aprovado, 
 * reprovado ou está de recuperação considerando que se o aluno teve mais de 10 faltas ele está reprovado, 
 * se as faltas foram inferiores à 10 mas a nota menor do que 5 ele está de recuperação, e se as faltas foram menor do que 10 e a nota maior ou igual a 5, ele está aprovado.
*/
namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, media ;
            int faltas ;
            string aluno ;

            //perguntar o nome
            Console.WriteLine("Informe nome do aluno");
            aluno = (Console.ReadLine());

            //perguntar as notas
            Console.WriteLine("Informe a primeira nota do(a) " + aluno);
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota do(a) " + aluno);
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota do(a) " + aluno);
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota do(a) " + aluno);
            n4 = Convert.ToDouble(Console.ReadLine());

            //pergunta quantas faltas
            Console.WriteLine("Informe a quantidade de faltas do(a) " + aluno);
            faltas = Convert.ToInt16(Console.ReadLine());

            //Descobrir a media
            media = (n1 + n2 + n3 + n4) / 4;

            //retorna na tela o nome do aluno,media e faltas
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nome: " + aluno);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Faltas: " + faltas);

            //condiçao
            if(faltas > 10)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("REPROVADO POR FALTAS");
            }
            else if(media < 5)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("APROVADO");
            }

            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
