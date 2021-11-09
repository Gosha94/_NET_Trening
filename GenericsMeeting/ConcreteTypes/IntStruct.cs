using GenericsMeeting.Contracts;

namespace GenericsMeeting.ConcreteTypes
{
    struct IntStruct : IGenericContract<int>
    {
        public int GetT()
        {
            throw new System.NotImplementedException();
        }
    }
}
