using BubbleSort;

int[] inteiros = [0, 12, 7, 1, 2, 8];

BubbleSort.BubbleSort.Print(inteiros);
Console.WriteLine();
BubbleSort.BubbleSort.Sort<int>(inteiros);
BubbleSort.BubbleSort.Print(inteiros);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Teste Char");
Console.WriteLine("");

char[] chars = ['x', 'z', 'b', 'c', 'a'];

BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);

