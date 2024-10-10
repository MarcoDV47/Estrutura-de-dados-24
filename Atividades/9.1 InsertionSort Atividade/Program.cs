using _9._1_InsertionSort_Atividade;

int[] inteiros = [-15, 3, 6, 8, 47, -50, 2, 20, 5, 7, 9, 5];

Console.WriteLine("Antes: ");
InsertionSort.Print(inteiros);

InsertionSort.Sort(inteiros);
Console.WriteLine("");

Console.WriteLine("Depois: ");
InsertionSort.Print(inteiros);