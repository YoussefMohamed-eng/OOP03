namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ///a)  What is the difference between Method Overloading and Method Overriding?
            // overloading is when you have multiple methods in the same class with the same name but different parameters (different type or number of parameters).
            // Overriding is when a derived class provides a specific implementation of a method that is already defined in its base class.
            // Overriding requires inheritance and the use of the 'virtual' and 'override' keywords.
            /// b)  What is the difference between Static Binding and Dynamic Binding?
            // Static binding (also known as early binding) occurs at compile time, where the method to be invoked is determined based on the reference type.
            // Dynamic binding (also known as late binding) occurs at runtime, where the method to be invoked is determined based on the actual object type.
            #endregion

            #region Question 02
            /// a)  What is the purpose of the sealed keyword when applied to a class?
            // The sealed keyword is used to prevent a class from being inherited. When a class is marked as sealed, it cannot serve as a base class for any other class.
            // This is useful when you want to restrict the inheritance hierarchy and ensure that the class's implementation remains unchanged.
            /// b)  What is the difference between a sealed class and a sealed method?
            // A sealed class cannot be inherited, meaning no other class can derive from it. A sealed method, on the other hand, is a method that cannot be overridden in any derived class.
            // It can only be used in the class where it is defined or in classes that inherit from it, but those classes cannot provide their own implementation of that method.
            /// c)  Can a sealed method be overridden? Why?
            // No, a sealed method cannot be overridden. The purpose of sealing a method is to prevent any further overriding in derived classes. When a method is marked as sealed,
            // it indicates that the implementation provided in the base class is final and should not be changed by any subclass.
            // This ensures that the behavior of the method remains consistent and cannot be altered by subclasses.
            #endregion
        }
    }
}
