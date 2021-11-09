namespace OpenCloseGenerics.Types
{
    internal sealed class ManyTypedNode<T> : Node
    {
        
        public T data;
        
        public ManyTypedNode(T newData) : this(newData, null) { }
        
        public ManyTypedNode(T newData, Node newNext) : base(newNext)
        {
            this.data = newData;
        }

        public override string ToString()
            => data.ToString() + next?.ToString();

    }

    internal class Node
    {

        protected Node next;
        
        public Node(Node newNext)
        {
            this.next = newNext;
        }

    }

}