using System;
using OpenCloseGenerics.Types;

namespace OpenCloseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var head = new OneTypeNode<string>(" 3-A");
            //head = new OneTypeNode<string>(" 2-B", head);
            //head = new OneTypeNode<string>("1-V", head);

            Node head = new ManyTypedNode<char>('.');
            head = new ManyTypedNode<DateTime>(DateTime.Now, head);
            head = new ManyTypedNode<string>("Hello World! ", head);

            Console.WriteLine(head.ToString());
            Console.ReadLine();
        }
    }
}