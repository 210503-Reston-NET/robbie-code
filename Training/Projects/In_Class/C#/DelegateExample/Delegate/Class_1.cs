using System;
// URL: https://github.com/210503-Reston-NET/robbie-code/tree/main/Training/Projects/In_Class/C%23/DelegateExample
namespace Delegate
{
    /// <summary>
        /// Must have;
        ///     Access Modifier
        ///     Identifier
        ///     Output Modifier
        ///     Any parameters
        /// 
        ///     These modifiers must be equivelent to any functions that it points to (Type Safe Function Reference)
        /// </summary>
    public delegate void DelegateVariable(string message);
    
    public class Class_1
    {


        public static void Main()
        {
            // Declaring 2 seperate Delegates
            DelegateVariable handler = new DelegateVariable(DelegateMethod);
            DelegateVariable handler2 = createDelegate();

            // This shows two seperate calls to each method individual
            // These methods invoke the Delegates
            handler("This is a local mesaage");
            handler2("This is another message");
            System.Console.WriteLine("\n");

            // Creating a delegate that holds both delegate
            // This process of assigning two delegates to a single property is called Multicasting
            DelegateVariable MultipleDels = handler + handler2;

            // You can call the "GetInvocationList() to get an array of Delegates
            // Calling "GetLength" On the array will return the total count of Delegates contained
            int InvocCount = MultipleDels.GetInvocationList().GetLength(0);
            Console.WriteLine("InvocCount: " + InvocCount);
            System.Console.WriteLine("\n");

            // When invoking the list of methods, one invoke calls each invoke method in the Multicast
            MultipleDels("This is a message from both delegates");
            System.Console.WriteLine("\n");

            // You can remove delegates from the Multicast by a simple decrement
            MultipleDels -= handler;

            // You can see how when you decrement it removes the first Delegate in the InvokeList
            MultipleDels("Notice how there is only one remaining message");
            System.Console.WriteLine("\n");

            // This shows that it only has 1 left after the decrement
            InvocCount = MultipleDels.GetInvocationList().GetLength(0);
            Console.WriteLine("InvocCount: " + InvocCount);
        }
        public static DelegateVariable createDelegate(){
            Class_2 MyClass = new Class_2();

            DelegateVariable handler2 = new DelegateVariable(MyClass.ExternalMethod);
            return handler2;
        }
        public static void DelegateMethod(string message){
            Console.WriteLine(message + " :From class 1");
        }
    }
}