namespace hacker_rank_tree_height_of_a_binary_tree
{
    public class Node
    {
        public Node Left { get; private set; }

        public Node Right { get; private set; }

        public int Data { get; private set; }

        public Node(int data)
        {
            Data = data;
        }

        public void SetLeftNode(Node node)
        {
            Left = node;
        }

        public void SetRightNode(Node node)
        {
            Right = node;
        }
    }
}
