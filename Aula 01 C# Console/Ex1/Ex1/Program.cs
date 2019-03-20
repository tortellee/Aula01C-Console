using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo para somar dois números informados pelo usuário e multiplicar o resultado pelo primeiro número.
namespace Lista_2_Exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            long n1,n2,total,total2;

            //Pede para o usuario informar o primeiro numero
            Console.WriteLine("Informe o primeiro numero");
            n1 = Convert.ToInt64(Console.ReadLine());

            //Pede para o usuario informar o segundo numero
            Console.WriteLine("Informe o segundo numero");
            n2 = Convert.ToInt64(Console.ReadLine());

            //resultado
            total = (n1 + n2);

            //mostrar resultado da soma
            Console.WriteLine(+total + " é a soma");

            total2 = (total * n1);

            //mostrar resultado do total x primeiro numero
            Console.WriteLine(+total2 + " é o total, multiplicado pelo primeiro numero ");

            //precionar a tecla para sair
            Console.ReadKey();

        }
    }
}
