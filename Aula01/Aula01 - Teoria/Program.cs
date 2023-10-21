using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Console.Write ("Testando c#");
    Console.Write (" Me chamo Marcos");
    //Console.WriteLine(" Eu sou alvarista");
    
    Console.WriteLine();
    Console.WriteLine(3); 

    int x = 4; //cria a variavel x do tipo inteiro e recebe 10
    Console.WriteLine(x);

    x = 5;
    Console.WriteLine(x);

    //O programa diferencia letras maiúsculas de minúsculas...
    
    /*  
    float numero; 
    float Numero;
    float NUMERO; 
    numero = 350;
    Console.WriteLine(numero); 
    */
    
    double a,b,c;
    
    a = 1;
    b = 2;
    c = 3;
    
    Console.WriteLine(a + b + c);

    float n = 1.75f;
    Console.WriteLine(n);
    //No float precisamos colocar esse f no final para ele reconhecer

    string name = "Marcos";
    Console.WriteLine(name);
    //usaremos o camelCase (commonCase) -> para variáveis

    double n2 = 9.74D; //Esse D não é obrigatório para numeros reais
    Console.WriteLine(n2);

    const int CONSTANT = 2; //Por convenção, usamos as constantes em maiúsculo
    Console.WriteLine(CONSTANT + " ESSA É A CONSTANTE");


    //OPERADORES ARITMÉTICOS
    Console.WriteLine();
    Console.WriteLine("OPERADORES ARITMÉTICOS");

    Console.WriteLine(2 + 3);
    Console.WriteLine(3 - 2);
    Console.WriteLine(3 * 2);
    Console.WriteLine(8 / 2);
    Console.WriteLine(8 % 2);
    
    //ALTERANDO VALOR DE VARIÁVEIS
    x++;        // x = 6
    x--;        // x = 5
    x = x + 3;  // x = 8
    x = x - 3;  // x = 5
    x = x * 2;  // x = 10
    x = x / 2;  // x = 5
    x += 7;     // x = 12
    Console.WriteLine(x);

    //DICAS DE CONSOLE
    Console.WriteLine("Podemos colocar os valores {0} e {1} aqui", 23, 30);
    Console.WriteLine("Podemos pular para \na linha de baixo desta forma");
    
    }
  }
