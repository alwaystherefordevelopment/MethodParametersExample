
namespace CSharpAdvanceConcepts
{
    class AttributesCSharp
    {
        [Obsolete("Use AddNumbers method in the place of AddTwoNumber method")]
        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int AddNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

    }

    class TestAttributes
    {
        static void Main()
        {
            Console.WriteLine(AttributesCSharp.AddTwoNumbers(20,10));

            Console.WriteLine(AttributesCSharp.AddNumbers(new List<int>() { 1, 2,3,4,5,6}));
        }
    }
}
