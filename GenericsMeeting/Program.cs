﻿using GenericsMeeting.Contracts;
using System.Collections.Generic;
using GenericsMeeting.ConcreteTypes;

namespace GenericsMeeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new IntClass();
            var struct1 = new IntStruct();
            var wrong = new WrongClass();
            
            // Обобщенные интерфейсы позволяют избегать лишних операций упаковки значимых типов (структур) в область кучи
            var list = new List<IGenericContract<int>>() 
            {
                class1,
                struct1,
                //wrong // Error
            };            

        }
    }
}
