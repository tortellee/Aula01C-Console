using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Você está programando um sistema para uma empresa de recursos humanos. De acordo com o tempo de experiência do candidato você deve informar ao recrutador o nível do candidato. Considere:
Menor que 2 anos → Júnior
Entre 2 e 5 anos → Pleno
Acima de 5 anos → Sênior
*/
namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis             
            int anos;
            string nome;

            //perguntar o nome
            Console.WriteLine("Informe nome do participante");
            nome = (Console.ReadLine());

            //perguntar a experiencia
            Console.WriteLine("Informe quantos ano(s) de experiência");
            anos = Convert.ToInt32(Console.ReadLine());

            //retorna na tela nome e os anos de experiência
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Experiência em ano(s) é: " + anos);

            //Se, participantes menor que 2 anos JUNIOR
            if (anos < 2)
            {
                Console.WriteLine("Nome: " + nome + " nível Júnior ");
            }
            //Se nao, participantes entre 2 e 5 PLENO
            else if (anos < 6)
            {
                Console.WriteLine("Nome: " + nome + " nível Pleno ");
            }
            //Outro, acima de 5 SÊNIOR
            else
            {
                Console.WriteLine("Nome: " + nome + " nível Sênior ");
            }
            //precionar para sair do programa
            Console.ReadKey();
        }
    }
}
