using System;
class Program
{
    public static void Main(string[] args)
    {
        float media = 0, soma = 0;

    inicio:
        Console.Write("Digite a quantidade de notas: ");
        if (int.TryParse(Console.ReadLine(), out int qtdNotas))
        {
            for (int i = 1; i < qtdNotas; i++)
            {
            pedenota:
                Console.Write($"Digite a {i}° nota: ");
                if (float.TryParse(Console.ReadLine(), out float nota))
                {
                    soma += nota;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                    goto pedenota;
                }
            }
            media = soma / qtdNotas;
            if (media >= 60)
            {
                Console.WriteLine($"Aprovado, sua nota e {media:F2}");
            }

            else if (media >= 40)
            {
                Console.WriteLine($"Recuperação, sua nota e {media:F2}");
            }

            else
            {
                Console.WriteLine($"Reprovado, sua nota e {media:F2}");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido");
            goto inicio;
        }

    }
}
