using System;
using GenericsMeeting.Contracts;

namespace GenericsMeeting.ConcreteTypes
{
    class IntClass : IGenericContract<int>
    {
        public int GetT()
        {
            throw new NotImplementedException();
        }
    }
}