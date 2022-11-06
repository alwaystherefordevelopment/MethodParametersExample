class MethodParameters
{
    //Pass by value
    int PassByValue(int a, int b)
    {
        a = a + 10;
        b = a + 20;
        return a + b;
    }

    //Pass by ref
    int PassByRef(ref int a, ref int b)
    {
        a = a + 20;
        b = a + 30;
        return a + b;
    }

    //Pass by out
    int PassByOut(int a, int b, out int c)
    {
        a = a + 20;
        b = a + 30;
        c = a + b + 100;
        return a + b;
    }

    //Pass by default
    int PassByDefault(int a, int b, int c = 10)
    {
        return a + b + c;
    }

    int AddNumbers(params int[] numbers)
    {
        int result = 0;
        foreach( var number in numbers)
        {
            result += number;
        }
        return result;
    }
    //int AddNumbers(int a, int b, int c)
    //{
    //    return a + b + c;
    //}

    //int AddNumbers(int[] numbers)
    //{
    //    int result = 0;
    //    foreach(var number in numbers)
    //    {
    //        result += number;
    //    }
    //    return result;
    //}
    static void Main()
    {


        int a = 20, b = 10, c = 15, d = 6;

        var obj = new MethodParameters();
        int[] numbers = new int[] { 1, 2, 3, 4, 6, 7 };
        Console.WriteLine(obj.AddNumbers(a, b, c, d));
        Console.WriteLine(obj.AddNumbers(numbers));



        //1-Pass by value
        //int a = 20, b = 10;
        //var obj = new MethodParameters();
        //Console.WriteLine(obj.PassByValue(a, b));
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //2-Pass by ref
        //int a = 20, b = 10;
        //var obj = new MethodParameters();
        //Console.WriteLine(obj.PassByRef(ref a, ref b));
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //3- Pass by out 
        //int a = 20, b = 10, c= 0;
        //var obj = new MethodParameters();
        //Console.WriteLine(obj.PassByOut(a, b, out c));
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //4- Pass by Default
        //int a = 20, b = 10, c = 25;
        //var obj = new MethodParameters();
        //Console.WriteLine(obj.PassByDefault(a, b, c));
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //5- Params


    }
}
