using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo para “Calcular o estoque médio de uma peça”, sendo que ESTOQUEMÉDIO = (QUANTIDADE MÍNIMA + QUANTIDADE MÁXIMA) /2 
namespace Lista_2_Exp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int qmi, qma, estm ;  

            //Pede para o usuario informar a quantidade Min
            Console.WriteLine("Informe a quantidade minima");
            qmi = Convert.ToInt32(Console.ReadLine());

            //Pede para o usuario informar a quantidade Max
            Console.WriteLine("Informe a quantidade maxima");
            qma = Convert.ToInt32(Console.ReadLine());

            //formula do calculo
            estm = (qmi+qma) / 2;

            //mostrar o estoque médio
            Console.WriteLine("Estoque médio é: " + estm);

            //precionar a tecla para sair
            Console.ReadKey();

        }
    }
}

