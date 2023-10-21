/*------------------------------------- Aula 04 - Algoritmos e Logica de programação------------------------------------- */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Testando operador ternário! */

            /*       
            int time = 20;
            string result = (time < 12) ? "Bom dia!" : "Boa tarde";
            Console.WriteLine(result); 
            */
            /*
             Vamos ver sobre o while, enquanto sua condição for verdadeira
             ele cnotinuará repetindo o código
            */
            /* 
             int i = 0;
             while (i < 10)
             {
                 Console.WriteLine(i);
                 i++;                    // Aqui e a variavel de controle!
             }
            */
            /* 
            double n1, n2, media;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            while (n1 > 10 || n1 < 0 || n2 > 10 || n2 < 0)
            {
            Console.WriteLine("A nota deve estar entre 0 e 10");
 
            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            }

           media = ( n1 + n2 ) / 2;
           Console.WriteLine(media); 
           */


            /* 

            double nPrimo;
            bool ePrimo = true;
            Console.Write("Digite o número: ");
            nPrimo = double.Parse(Console.ReadLine());

            for (double i = 2; i < Math.Sqrt(nPrimo); i++)
            {
               if (nPrimo % 2 == 0)
                {
                    Console.WriteLine(i);
                    ePrimo = false;
                }
            }
            string str = ePrimo ? "O numero e primo" : "Nao e primo";
            Console.WriteLine(str); 
 
           */

            /* string str = "loop"; */

            /*            
            while (str != "s" && str != "n")
            {
                Console.Write("Por favor, digite 's' ou 'n': ");
                str = Console.ReadLine().ToLower();
            }
            Console.WriteLine("FIM DO CODIGO");
             */

            /* Outra maneira de montar a estrutura! */
            /*          
              do
            {
                Console.Write("Por favor, digite 's' ou 'n': ");
                str = Console.ReadLine().ToLower();
            } while (str != "s" && str != "n");
            */

            /* ------------------- EXERCICIOS DA AULA -------------------*/

            /*      
            double choice, i = 0, result;

            Console.Write("Digite um número: ");
            choice = int.Parse(Console.ReadLine());

            while (i < 10)
            {
                i++;
                result = choice * i;
                Console.WriteLine("{0} x {1}  =  {2}", choice, i, result);
            } 
            */

            int sum = 0;

            for (int i = 1; i <= 20; i++){
               sum += i * 2;
            }

            Console.WriteLine("A soma será: {0}", sum);

        }
    }
}
