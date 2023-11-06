/* 1º Crie um array e imprima os 5 primeiros elementos */
/* 
int[] arrayInt = { 0, 1, 2, 3, 4 };

for (int i = 0; i < arrayInt.Length; i++)
{
    Console.WriteLine(arrayInt[i]);
} 

foreach (int i in arrayInt){
    Console.WriteLine(i);
}

Console.WriteLine($"O comprimento da lista é {arrayInt.Length}");
*/

/* 2º  Altere o segundo elemento do array*/
/* 
string[] arrayStr = {"um", "dois", "tres"};

arrayStr[1] = "alterado";

foreach (string i in arrayStr){
    Console.WriteLine(i);
} 
*/

/* 3º Faça um algoritmo que encontre o menor valor e o maior valor de um array */
/* -> Possivel exercicio de prova */
/* int[] numbers = {1, 101, 2, 10, 24, 30, -2, 30, 10, -20, 40, 99};
int Max = numbers[0];
int Min = numbers[0];

foreach(int i in numbers){
    if (i > Max){
        Max = i;
    }

    if (i < Min){
        Min = i;
    }
}
Console.WriteLine($"O maior número é {Max} e o menor {Min}"); */

/* 
string[,] matriz = new string[2, 3];
Console.WriteLine(matriz.GetLength(0));  4
Console.WriteLine(matriz.GetLength(1));  2
*/
/* 
for (int i = 0; i < matriz.GetLength(0); i++){

    for (int j = 0; j < matriz.GetLength(1); j++){
        Console.WriteLine($"Linha {i} Coluna {j}");
        
        Console.Write("Digite um valor: " );
        matriz[i,j] = Console.ReadLine()!;
    }   

}
Console.Clear();

for (int i = 0; i < matriz.GetLength(0); i++){
    for (int j = 0; j < matriz.GetLength(1); j++){
        Console.Write($"{matriz[i,j]} " );
    }   
    Console.Write("\n");
}
 */
/* Fibonacci -> 0, 1, 1, 2, 3, 5, 8, 13 */

int numeroAnterior = 0;
int numeroAtual = 1;
int valorImprimido;

/* Vamos imprimir os 20 primeiros numeros */
Console.Write("0, 1, ");
for (int i = 0; i <= 20; i++){
    valorImprimido = numeroAnterior + numeroAtual;
    Console.Write($"{valorImprimido}, ");

    numeroAnterior = numeroAtual;
    numeroAtual = valorImprimido;
}