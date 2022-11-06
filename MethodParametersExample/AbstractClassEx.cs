
namespace MethodParametersExample
{
    //1 - If you want to create abstract method then the class must be abstract class
    //2 - Abstract method will not have a body or a definition
    //3- You can declare non-abstract method(non-static, static, virtual)
    //4- If you want to provide the body of absttract methods, you will have to inherit abstract class.
    //5- When you inherit abastract class with other class that time you will have to provide the body/implementation of all the abstract
    //methods
    //6 - When you provide the implementation of abstact method then you will have to use the override keyword.
    //7- You cannot create the instance of an abstract class.
    abstract class AbstractClassEx
    {
        public abstract void FirstMethod();
        void SecondMethod()
        {

        }
        public static void ThirdMethod()
        {

        }

        public virtual void FourthMethod()
        {

        }

        public abstract int FifthMethod(int firstValue, int secondValue);
    }

    class SampleClass : AbstractClassEx
    {
        public override int FifthMethod(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        public override void FirstMethod()
        {
            Console.WriteLine("Hello from the first method");
        }
        static void Main()
        {
            var obj = new SampleClass();
            obj.FirstMethod();
            ThirdMethod();
            obj.FourthMethod();
            Console.WriteLine(obj.FifthMethod(10, 20));
            
        }
        
    }
}
