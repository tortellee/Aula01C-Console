using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo capaz de calcular a média de 5 notas de um aluno. 
//O sistema, além das notas deve pedir o nome do aluno e depois de calcular a média, informar o nome e a média do aluno.
namespace Lista_2_Exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double n1, n2, n3, n4, n5, media;
            string aluno;

            //Pede para o usuario informar o nome do aluno
            Console.WriteLine("Informe o nome do aluno");
            aluno = (Console.ReadLine());

            //Pede para o usuario informar as notas
            Console.WriteLine("Informe a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quinta nota");
            n5 = Convert.ToDouble(Console.ReadLine());

            //formula do calculo
            media = (n1 + n2 + n3 + n4 + n5) /5;

            //mostrar nome do aluno e média
            Console.WriteLine(aluno + " teve a média " +media);

            //precionar a tecla para sair
            Console.ReadKey();

        }
    }
}

