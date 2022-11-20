internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = { 10, 2, 3, 4, 6, 5, 7 };
        // Heap sort
        int tamanho = vetor.Length;

        for (int i = tamanho / 2 - 1; i > 0; i--)
        {
            AplicarHeap(vetor, tamanho, i);
        }

        Console.WriteLine("Quase ordenado: ");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"{vetor[i]}");
        }


        Console.WriteLine("Ordenado:");
        for (int j = tamanho - 1; j > 0; j--)
        {
            int aux = vetor[0];
            vetor[0] = vetor[j];
            vetor[j] = aux;

            AplicarHeap(vetor, j, 0);
        }

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"{vetor[i]}");
        }

    }

    private static void AplicarHeap(int[] vetor, int tamanho, int i)
    {
        int raiz = i; // [1] = 2
        int esquerda = 2 * i + 1; // 2 * 1 + 1 = 3 
        int direita = 2 * i + 2; // 2 * 0 + 2 = 4


        if (esquerda < tamanho && vetor[esquerda] > vetor[raiz])
        {
            raiz = esquerda;
        }
        // 2[3] > vetor[0] == 10
        if (direita < tamanho && vetor[direita] > vetor[raiz])
        {
            raiz = direita;
        }

        if (raiz != i)
        {
            int aux = vetor[i];
            vetor[i] = vetor[raiz];
            vetor[raiz] = aux;
            AplicarHeap(vetor, tamanho, raiz);
        }
    }
}