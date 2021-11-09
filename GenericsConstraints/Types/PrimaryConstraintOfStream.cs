using System.IO;

namespace GenericsConstraints.Types
{
    internal sealed class PrimaryConstraintOfStream<T> 
        where T : Stream
    {
        public void M(T stream)
        {
            stream.Close(); // Допустимо, т.к. метод Close определен в типе Stream и доступен в нем и всех его наследниках
        }

    }
}