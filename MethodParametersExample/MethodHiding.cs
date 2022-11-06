
namespace MethodParametersExample
{
    public class MethodHiding
    {
        public void PrintMessage()
        {

        }
    }

    public class AnotherClass: MethodHiding
    {
        public new void PrintMessage()
        {

        }
    }
}
