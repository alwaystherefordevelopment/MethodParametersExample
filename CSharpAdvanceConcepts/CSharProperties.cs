
class CSharpProperties
{
    int i;

    public int GetOrSetValue 
    { 
        get { return i; } 
        set { if (i == 0) { i = 90; }
            else { i = value; } } 
    }
    //public int GetMethod()
    //{
    //    return i;
    //}
    //public void SetMethod(int j)
    //{
    //    i = j;
    //}
}

class SampleC1
{
    static void Main()
    {
        var obj = new CSharpProperties();
        //obj.GetMethod();//get 
        //obj.SetMethod(10); //setter
        obj.GetOrSetValue = 100; //setter
        Console.WriteLine(obj.GetOrSetValue);//getter
    }
}