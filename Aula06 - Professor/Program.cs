/*------------------------------------- Aula 06 - Array e Matrizes------------------------------------- */

class Program
{
    public static void Main(string[] args)
    {
        // tipo[] nomeDoArray = new tipo[tamanho];
        // tipo[] nomeDoArray = { elementos };

        /*         
        int[] integerNumbers = {1, 2, 3, 4};

        integerNumbers[0] = 50;
        
        Console.WriteLine(integerNumbers[0]);
        Console.WriteLine("A largura do array é {0}", integerNumbers.Length); 
        */
        /* 
        int[] array = new int[6];

        Random rnd = new Random()!;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(10);
        }

        Array.Sort(array);
        foreach (int i in array)
        {
            Console.Write("{0} ", i);
        } 
        */
        /* 
        string[] carros = { "lexus", "corolla", "civic", "lancer", "fusca" };

        for (int i = 0; i < carros.Length; i++)
        {
            Console.WriteLine(carros[i]);
        }

        Console.WriteLine("\n");

        foreach (string carro in carros)
        {
            Console.WriteLine(carro);
        } 
        */

        /* 
        int[,] myNumbers = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } ,
                            };

        // Console.WriteLine(myNumbers[0,2]);

        foreach(int numero in myNumbers){
            Console.WriteLine(numero);
        } */

        string[] arrayStrings = {"primeira", "segunda", "terceira"};
        arrayStrings[1] = "Alterado";

        foreach(string word in arrayStrings){
            Console.Write("{0}  ", word);
        }
    }
}









