namespace _10._1_ArvoreEmpresa
{
    public class Tree<T>
    {
        public TreeNode<T>? Root { get; set; }
        public void PrintTree(TreeNode<T> node)
        {
            Console.WriteLine($"Level: {node.GetHeight()}");
            Console.WriteLine($"Node: {node}");
            Console.WriteLine();

            if (node.Children!.Count > 0)
                foreach (var i in node.Children)
                    PrintTree(i);
        }
    }
}