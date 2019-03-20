using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Você está programando um sistema de festa infantil. O sistema deve emitir um orçamento de acordo com a quantidade de participantes. 
O usuário deve digitar a quantidade de participantes e o sistema deve emitir o valor total considerando até 
100 pessoas o valor é R$ 35,00 por participante acima de 100 pessoas o valor passa a ser R$ 45,00 por participante.*/

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis             
            double valor1, valor2 ;
            int parti ;

            //perguntar quantidade de participantes
            Console.WriteLine("Informe a quantidade de participantes");
            parti = Convert.ToInt32(Console.ReadLine());

            //Informa a quantidade participantes
            Console.WriteLine("Quantidade de participantes é: " + parti);

            //Se participantes maior que 100 entao vezes 45,00
            if (parti > 100)
            {
                valor1 = (parti * 45.00);
                Console.WriteLine("Valor total: R$ " + valor1 + ",00");

            }
            //Se nao participantes menor que 100 entao vezes 35,00
            else
            {
                valor2 = (parti * 35.00);
                Console.WriteLine("Valor total: R$ " + valor2 + ",00");
            }

            //precionar para sair do programa
            Console.ReadKey();


        }
    }
}
