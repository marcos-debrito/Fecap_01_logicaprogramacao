using System;

class Program {
  public static void Main (string[] args) {
    
    // Vamos fazer um algoritmo para calcular IMC 

    /* 
    Entradas necessárias: altura (h em metros) e peso (p em kg)         */

    double weight, height, IMC;
    
    Console.Write("Digite seu peso (kg): ");
    weight = double.Parse(Console.ReadLine());

    Console.Write("Digite sua altura (m): ");
    height = double.Parse(Console.ReadLine());

    IMC = weight / (height*height);
    
    /* 
    Math.Pow(height, 2);  outra forma de elevar o termo ao     
    quadrado
    */
    
    Console.WriteLine("Seu IMC é: {0} ", Math.Round(IMC, 2));

    int num;

    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0){
      Console.WriteLine("O número é par");
    } else {
      Console.WriteLine("O número é ímpar");
    }
    
  }
}