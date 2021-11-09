namespace OpenCloseGenerics.Types
{
    internal sealed class OneTypeNode<T>
    {
        public T data;
        
        public OneTypeNode<T> next;
        
        public OneTypeNode(T data) : this(data, null) { }
        
        public OneTypeNode(T newData, OneTypeNode<T> newNext)
        {
            this.data = newData;
            this.next = newNext;
        }

        public override string ToString()
            => data.ToString() + next?.ToString();

    }
}