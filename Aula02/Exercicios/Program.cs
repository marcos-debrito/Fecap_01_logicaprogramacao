using System;

class Program {
  public static void Main (string[] args) {
    /*
    1° Teste se um número é positivo ou negativo e informe o resultado no console        */

   /*  
    double number;
  
    Console.Write("Digite um número: ");
    number = double.Parse(Console.ReadLine());
  
    if (number > 0) {
       Console.WriteLine("O número é positivo!");
    } else if (number < 0) {
      Console.WriteLine("O número é negativo!");
    } else {
       Console.WriteLine("O número é nulo!");
    }
  */

    /* *********************************************************************  */
   
   /*  2° Teste se um número é par ou ímpar */

  /*
    Console.Write("Digite um número: ");
    double choice = int.Parse(Console.ReadLine());

    if (choice % 2 == 0){
      Console.WriteLine("É um número par");
    } else {
      Console.WriteLine("É um número ímpar");
    } 
  */

    /* *********************************************************************  */

  /* 
    3° A partir de 3 notas, calcule a média e informe se a pessoa
    foi aprovada (media >= 6) ou reprovada (media <6)
  */

  /*  
    double a, b, c, media, round;
    a = 7.2;
    b = 8.7;
    c = 5.9;

    media = (a + b + c)/3;

    if (media > 6){
      round = Math.Round(media, 2);
      Console.WriteLine("Aprovado, com média {0}", round);
    } else {
      round = Math.Round(media, 2);
      Console.WriteLine("Reprovado, com a média {0}", round);
    }
  */

    /* *********************************************************************  */


  /* 
    4° Escreva um programa que entre com três números e
    determine se eles formam um triângulo válido ou não.
    Um triângulo é válido se a soma de quaisquer dois lados
    for maior que o terceiro lado.
  */
    
   
    double a, b, c;

    a = 3;
    b = 8;
    c = 3;

    if ((a + b > c) && (a + c > b) && (c + b > a)){
      Console.WriteLine("Pode se formar um triângulo!");
    } else {
      Console.WriteLine("Algum dos lados não é suficiente :(");
    } 
 

   /* *********************************************************************  */

  
  }
}