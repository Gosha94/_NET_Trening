using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace GenericsConstraints.Types
{
    internal sealed class SecondaryInterfaceConstraint<T>
        where T : IComparable<T>, IEquatable<T>
    {
        public void Use() { }
    }

    internal sealed class InterfaceImplementor : IComparable<InterfaceImplementor>, IEquatable<InterfaceImplementor>
    {
        public int CompareTo(InterfaceImplementor other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(InterfaceImplementor other)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class User
    {

        public void Main()
        {
            var user = new SecondaryInterfaceConstraint<InterfaceImplementor>(); // Допустимо, т.к. класс InterfaceImplementor реализует интерфейсы IComparable, IEquatable
            var ok = new SecondaryInterfaceConstraint<string>(); // Допустимо, т.к. string реализует интерфейсы IComparable, IEquatable
            var wrong = new SecondaryInterfaceConstraint<Stream>(); // Ошибка, т.к. Stream не реализует интерфейсы IComparable, IEquatable
        }

    }

}