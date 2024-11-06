using System.ComponentModel.DataAnnotations;
using _9._3_QuickSort;

Console.WriteLine("Testando o Quick Sort");

int[] values = [0, 15, 24, 13, 6, 12, 9];

QuickSort.QuickSort.Print<int>(values);

Console.WriteLine("");
Console.WriteLine("Iniciando ordenação");

QuickSort.QuickSort.Swap(values, 0, values.Length - 1);

Console.WriteLine("Finalizando ordenação");

QuickSort.QuickSort.Print<int>(values);