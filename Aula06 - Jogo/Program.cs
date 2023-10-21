/*------------------------------------- Aula 06 - Jogo de fichas!------------------------------------- */

/* 
Minha versão do jogo!
Regras:
- Jogo inicia com o jogador possuindo 100 fichas!
- Jogador deve apostar no mínimo 10 fichas, e não pode apostar mais do que possui;
- A soma de dois dados:
    |__ Caso a soma seja == 7, as fichas apostadas devem ser dobradas;
    |__ Caso a soma seja == 2 ou == 12, as fichas apostadas devem ser triplicadas;
    |__ Caso contrário, ele perde as fichas apostadas :( ;

- O jogo termina quando não houver mais fichas ou o usuário digitar o número 0;
*/
class Program
{
    public static void Main(string[] args)
    {
        
        bool continuar = true;
        string option;

        while (continuar)
        {
            int rodada = 0;
            rodada = InicioJogo(rodada);
            FimDeJogo(rodada);

            Console.Write("Continuar jogando? [S/N]: ");
            option = Console.ReadLine()!.ToLower();

            if (option == "n")
            {
                continuar = false;
            }
        }
    }

    public static int InicioJogo(int rodada)
    {
        Console.Clear();
        int SaldoInicial, SaldoAtual, FichasApostadas, dado1, dado2, soma, FichasGanhadas;

        SaldoInicial = 100;
        SaldoAtual = SaldoInicial;
        Console.WriteLine("Seu saldo inicial é de: {0}", SaldoInicial);

        while (SaldoAtual >= 10)
        {
            rodada++;
            Console.WriteLine("\n --------------- Rodada {0} --------------- \n", rodada);
            Console.WriteLine(" Digite [0] caso deseje terminar o jogo \n");
            Console.WriteLine("Saldo atual: {0}", SaldoAtual);

            Console.Write("Digite o número de fichar que deseja apostar:");
            FichasApostadas = int.Parse(Console.ReadLine()!);

            if (FichasApostadas == 0)
            {
                Console.WriteLine("Você finalizou com {0} fichas!", SaldoAtual);
                break;
            }

            while (FichasApostadas < 10 || FichasApostadas > SaldoAtual)
            {
                Console.Clear();
                Console.WriteLine("Seu saldo atual é de: {0}", SaldoAtual);
                Console.WriteLine("Deve ser um número maior que 10 e menor que seu saldo!");
                Console.Write("Por favor, insira um valor válido!: ");
                FichasApostadas = int.Parse(Console.ReadLine()!);
            }
            Console.ResetColor();

            dado1 = NumeroAleatorio();
            dado2 = NumeroAleatorio();

            soma = dado1 + dado2;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A soma dos dados: {0} + {1} = {2} \n", dado1, dado2, soma);
            Console.ResetColor();

            if (soma == 7)
            {
                FichasGanhadas = FichasApostadas * 2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ganhou o dobro!! {0}", FichasGanhadas);
                Console.ResetColor();
                SaldoAtual += FichasGanhadas;
            }
            else if (soma == 2 || soma == 12)
            {
                FichasGanhadas = FichasApostadas * 3;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ganhou o Tripo!!! {0}", FichasGanhadas);
                Console.ResetColor();
                SaldoAtual += FichasGanhadas;
            }
            else
            {
                SaldoAtual -= FichasApostadas;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não ganhou fichas :( ");
                Console.ResetColor();
            }
        }

        return rodada;
    }

    public static void FimDeJogo(int rounds)
    {
        Console.Clear();
        Console.WriteLine("Fim de jogo!");
        Console.WriteLine("Tivemos {0} rodadas!", rounds);
    }

    public static int NumeroAleatorio()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }
}

/* Versão do professor :O */









