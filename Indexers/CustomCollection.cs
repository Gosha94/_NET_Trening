using System;

namespace Indexers
{
    class CustomCollection
    {
        public int this[int keyInt, string keyString]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}