using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    internal class Program
    {
        public delegate void someDelegate();

        private static void someAction(Action action)
        {
            string methodName = action.Method.Name;
            Console.WriteLine("Начало работы над {0}",methodName);
            action();
            Console.WriteLine("Окончание работы над {0}",methodName);
        }

        private static List<Action> GetAction()
        {
            Console.WriteLine("In GetAction");
            return new List<Action>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }
        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description, 
            int age)
        {
            Console.WriteLine(name, description,  age);
        }
        
        
        public static void Main(string[] args)
        {
            Customer customer = new Customer();
            Store store = new Store();
            Console.Write($"{customer.Id},{store.Id}");
            someDelegate obj = () => GetAction().ForEach(someAction);
            obj.Invoke();
            Console.ReadKey();
        }
    }
}
