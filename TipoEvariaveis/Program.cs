// See https://aka.ms/new-console-template for more information
namespace TiposEvariaveis
{
    class Program
    {
        static void Main(String[] args)
        {
            //Laços interativos => estruturad que repetem um bloco de código, determinado número de vezes

            //Laço for
            Console.WriteLine("For");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i é: " + i);
            }

            //While
            Console.WriteLine("\r\nWhile");

            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Do...While
            // Execução garantida pelo menos uma vez! (executando o bloco primeiro e depois faz o teste da condição)
            Console.WriteLine("\r\nDo...While");
            
            double j = 2;
            do
            {
                Console.WriteLine(j);
                j = j * 2;
            } while (j < 100);

            //Foreach
            //Percorre todos os elementos de um conjunto
            Console.WriteLine("\r\nForeach");

            int[] conjunto = { 1, 2, 3, 4};
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor: " + numero);
            }
        }
    }
}