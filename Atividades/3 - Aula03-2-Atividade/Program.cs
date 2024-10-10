using System.IO.Compression;

int[] numerosPares = new int[100];
int[] numerosImpares = new int[100];

for (int i = 0; i < numerosPares.Length * 2; i++)
{
    if (i % 2 == 0 && i != 0)
    {
        numerosPares[i / 2] = i;
    }
    else numerosImpares[i / 2] = i;
}

Console.WriteLine("Números Pares:");

foreach (int number in numerosPares)
{
    Console.WriteLine(number);
}

Console.WriteLine("");
Console.WriteLine("Números Ímpares:");

foreach (int number in numerosImpares)
{
    Console.WriteLine(number);
}