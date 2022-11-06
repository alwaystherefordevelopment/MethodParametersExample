

namespace CSharpAdvanceConcepts
{
    enum Color
    {
        Red = 1, Green, Yellow, Blue 
    }
    class EnumsInCSharp
    {
        static void Main()
        {
            Console.WriteLine("Please enter your favorite color name 1- Red, 2-Green, 3-Yellow, 4-Blue");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            Color userChoice = (Color)userInput;

            switch (userChoice)
            {
                case Color.Red:
                    Console.WriteLine("You color is Red");
                    break;
                case Color.Green:
                    Console.WriteLine("You have choosen Green.");
                    break;
                case Color.Yellow:
                    Console.WriteLine("You have chosen Yellow");
                    break;
                case Color.Blue:
                    Console.WriteLine("You have chosen Blue");
                    break;
                default:
                    Console.WriteLine("Your choice does not exist");
                    break;
            }
            

        }
    }
}
