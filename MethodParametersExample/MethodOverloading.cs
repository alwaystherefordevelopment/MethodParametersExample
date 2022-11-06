namespace MethodParametersExample
{
    class MethodOverloading
    {
        void PrintMessage()
        {

        }

        void PrintMessage(int empId)
        {

        }
        //void PrintMessage(int empCode)
        //{

        //}

        void PrintMessage(int empId, string name)
        {

        }
        
        void PrintMessage(string name, int empId)
        {

        }
        void PrintMessage(string firstName, string lastName)
        {

        }

        static void Main()
        {
            var obj = new MethodOverloading();
            obj.PrintMessage("David", "Test");
        }
    }
}
