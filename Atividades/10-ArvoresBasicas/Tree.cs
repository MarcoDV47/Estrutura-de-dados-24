namespace _10_ArvoresBasicas
{
    public class Tree<T>
    {
        public Node<T>? Root { get; set; }

        public void PrintTree(Node<T> node)
        {
            Console.WriteLine($"Level: {node.GetHeight()}");
            Console.WriteLine($"Data: {node.Data?.ToString()}");
            Console.WriteLine();

            if (node.Children!.Count > 0)
                foreach (var i in node.Children)
                    PrintTree(i);
        }
    }
}