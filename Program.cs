internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça uma função recursiva que receba um número inteiro 𝑛 por parâmetro e
        retorne a soma dos números inteiros entre zero e 𝑛. A função deve funcionar
        adequadamente tanto para 𝑛 positivo quanto para negativo. Para esse exercício
        não se pode utilizar as estruturas de repetição (for, while e do while). */

        int n = 5, soma = 0;
        Console.WriteLine($"Soma entre 0 e {n}: {SomaEntre(n, soma)}");

    }

    static int SomaEntre(int n, int soma)
    {
        if (n > 0)
        {
            soma += n;
            return SomaEntre(n-1, soma);
        }
        else if (n < 0)
        {
            soma += n;
            return SomaEntre(n+1, soma);

        }
        return soma;
    }
}