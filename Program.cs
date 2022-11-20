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

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"{vetor[i]}");
        }
    }

    private static void AplicarHeap(int[] vetor, int tamanho, int i)
    {
        int raiz = i;
        int esquerda = 2 * i + 1; 
        int direita = 2 * i + 2;


        if (esquerda < tamanho && vetor[esquerda] > vetor[raiz])
        {
            raiz = esquerda;
        }

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