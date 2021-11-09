using System;
using System.Collections.Generic;

namespace GenericsConstraints.Types
{
    class TypeParameterConstraint
    {
        private static List<TBase> ConvertIList<T, TBase>(IList<T> list)
            where T : TBase
        {
            List<TBase> baseList = new List<TBase>(list.Count);
            for (int index = 0; index < list.Count; index++)
            {
                baseList.Add(list[index]);
            }
            return baseList;
        }

        private static void CallingConvertIList()
        {

            // Создаем и инициализируем тип List<string> (который реализует интерфейс IList<T>)
            IList<string> ls = new List<string>();
            ls.Add("A String");

            // Преобразуем IList<string> в IList<object>
            IList<object> lo = ConvertIList<string, object>(ls);

            // Преобразуем IList<string> в IList<IComparable>
            IList<IComparable> lc = ConvertIList<string, IComparable>(ls);

            // Преобразуем IList<string> в IList<IComparable<string>>
            IList<IComparable<string>> lcs = ConvertIList<string, IComparable<string>>(ls);

            // Преобразуем IList<string> в IList<String>
            IList<string> ls2 = ConvertIList<string, String>(ls);

            // Преобразуем IList<string> в IList<Exception>
            IList<Exception> le = ConvertIList<string, Exception>(ls); // Ошибка, string и Exception несовместимы между собой

        }

    }
}