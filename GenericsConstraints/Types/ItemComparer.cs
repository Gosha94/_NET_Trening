using System;

namespace GenericsConstraints.Types
{
    static class ItemComparer<TItemForCompare> where TItemForCompare : IComparable<TItemForCompare>
    {

        public static bool CompareTwoItems(TItemForCompare firstItem, TItemForCompare secondItem)
        {

            if (firstItem.Equals(secondItem))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}