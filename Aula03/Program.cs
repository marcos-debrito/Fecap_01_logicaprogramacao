using System;

class Program
{
    public static void Main(string[] args)
    {
        /* Exercicio 1  */
        /*
          Console.WriteLine("-----EXERCICIO 1-----");
             double age, cats;

          age = 25;
          cats = 5;

          if (age < 30 && cats >= 4){
            Console.WriteLine("João atende aos requisitos");
          } else {
            Console.WriteLine("Não atende aos requisitos");
          } 
        */

        /* Exercicio 2  */
        /* 
          Console.WriteLine("-----EXERCICIO 2-----");
          Console.Write("Esta chovendo? (S/N):  ");
          string rainning = Console.ReadLine();


          if (rainning == "S" || rainning == "s") {
             Console.WriteLine("Maria levará guarda chuva");
          } else if (rainning == "N" || rainning == "n") {
             Console.WriteLine("Maria levará um boné");
          } else {
            Console.WriteLine("Digite (S/N)");
          }
       */
        /* Exercicio 3 */

        /* CASO TENHA APENAS UMA INSTRUÇÃO NAO PRECISAMOS DAS CHAVES */


        /* Exercicio 3  */
        /*
          Console.WriteLine("-----EXERCICIO 3-----");

          int macas, bananas, peras, caixas;

          macas = 5;
          bananas = 3;
          peras = 4;
          caixas = 10;


         int totalFruits = caixas * (macas + bananas + peras);
         Console.WriteLine("A quantidade total é: {0}", totalFruits);
       */

        /* Exercicio 4 */
        /* 
          Console.WriteLine("-----EXERCICIO 4-----");
          double  Pedro, Joana, Maria, sum;
          Pedro = 3;
          Joana = 5;
          Maria = 8;

          sum = Pedro + Joana + Maria;

          double media = Math.Round(sum / 3);

          media = Math.Round(media, 2);

          Console.WriteLine("A média será {0}", media);
       */
        /* Exercicio 5  */
        /*   
            Console.WriteLine("-----EXERCICIO 5-----");

            int carros, motos, totalRodas;

            carros = 20;
            motos = 15;

            totalRodas = carros*4 + motos*2;

            Console.WriteLine("A quantidade de rodas é: {0}", totalRodas);

         */
        /* Exercicio 6  */
        /*    
           Console.WriteLine("-----EXERCICIO 6-----");
           int livros, prateleiras, totalLivros;
           livros = 20;
           prateleiras = 8;

           totalLivros = livros * prateleiras;

           Console.WriteLine("A quantidade total é: {0}", totalLivros); 
         */

        /* Exercicio 7  */
        /*     
          Console.WriteLine("-----EXERCICIO 7-----");

          for(int i = 0; i <= 500; i++){
            Console.WriteLine(i);
          }
        */


        /* Exercicio 8  */
        Console.WriteLine("-----EXERCICIO 8-----");


        /* Crie um programa que peça um numero inteiro ao usuário
        e teste se ele é um número primo */

        double number, divisors = 0;

        Console.Write("Digite um número: ");
        number = double.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisors += 1;
            }
        }

        if (divisors > 2)
        {
            Console.WriteLine("O número {0} não é primo", number);
        }
        else
        {
            Console.WriteLine("O número é primo!");
        }



    }
}