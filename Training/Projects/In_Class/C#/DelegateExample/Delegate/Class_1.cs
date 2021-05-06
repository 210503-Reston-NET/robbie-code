using System;

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
            DelegateVariable handler = new DelegateVariable(DelegateMethod);
            
            DelegateVariable handler2 = createDelegate();

            handler("This is a local mesaage");
            handler2("This is another message");

            DelegateVariable MultipleDels = handler + handler2;

            MultipleDels("This is a message");

            MultipleDels -= handler;

            int InvocCount = MultipleDels.GetInvocationList().GetLength(0);
            Console.WriteLine("InvocCount: " + InvocCount);
        }
        public static DelegateVariable createDelegate(){
            Class_2 MyClass = new Class_2();

            DelegateVariable handler2 = new DelegateVariable(MyClass.ExternalMethod);
            return handler2;
        }
        public static void DelegateMethod(string message){
            Console.WriteLine(message);
        }
    }
}