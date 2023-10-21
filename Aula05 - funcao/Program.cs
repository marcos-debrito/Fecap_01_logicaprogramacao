/*------------------------------------- Aula 05 - Algoritmos e Logica de programação------------------------------------- */
class Program
{
    public static void Main(string[] args)
    {
        /*
        MinhaPrimeiraFuncao();
        
        Console.WriteLine(Soma(5, 5));
        if (MaiorQueDez(5))
        {
            Console.WriteLine("O número é maior que dez");
        }
        else
        {
            Console.WriteLine("Não é maior que dez");
        }
        */
        /* EXERCICIOS AULA 5 FUNCOES */

        /* 1º Funcao que calcule e retorne a área de um retângulo */
        /*  
        double area = CalcularAreaRetangulo(30.5, 20.5);
        Console.WriteLine("A area do retângulo vale {0} u.m", area); 
        */

        /* 2º Funcao que verifica se é primo */
        /*
        Console.Write("Digite um número: ");
        double number = double.Parse(Console.ReadLine());
        VerificarNumeroPrimo(number); 
        */

        /* 3º Funcao que converte temperatura entre Celsius e Fahrenheit */
        /* ConversorTemperatura(68, "f"); */


        /* Gerando um número aleatório com métodos! */
        Random rnd = new Random();
        for (int i = 0; i < 50; i++)
            Console.WriteLine(rnd.Next(1,7)); 
        /* Irá gerar um número aleatório de 1 a 6, o 7 não está incluso */
    }

    public static void MinhaPrimeiraFuncao()
    {
        Console.WriteLine("Minha primeira funcao!");
    }

    public static int Soma(int a, int b, int c = 0)
    {
        int result = a + b + c;
        return result;
    }

    public static bool MaiorQueDez(int n)
    {
        if (n > 10)
            return true;

        return false;
    }

    public static double CalcularAreaRetangulo(double a, double b)
    {
        return a * b;
    }

    public static void VerificarNumeroPrimo(double numero)
    {
        bool ePrimo = true;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                ePrimo = false;
                break;
            }
        }

        if (ePrimo)
        {
            Console.WriteLine("O número é primo!");
        }
        else
        {
            Console.WriteLine("Não é primo!");
        }
    }

    public static void ConversorTemperatura(double t, string escala = "c")
    {

        double converted = 0;

        if (escala == "c")
        {
            converted = t * 1.8 + 32;
            escala = "f";
        }
        else if (escala == "f")
        {
            converted = (t - 32) / 1.8;
            escala = "c";
        }

        Console.WriteLine("A temperatura convertida será: {0} º{1}", converted, escala);
    }

}

/* Void -> executam algo, mas nao retornam */

/* Podemos especificar como por exemplo "int", caso retorne um inteiro! */