using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanceConcepts
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    class SampleAttribute : Attribute
    {
        public string Name { get; set; }
        public double Version { get; set; }
    }
    [Sample(Name = "Any Name", Version = 1.0)]
    class CustomAttributeCSharp
    {
        [Sample(Name ="Any Name", Version = 1.0)]
        public int MyProperty { get; set; }
        [Sample(Name ="Any Name", Version=1.0)]
        public int MyMethod()
        {
            return MyProperty;
        }

        [Sample(Name ="Any Name", Version = 1.0)]
        class Normal
        {

        }

        class NoAttribute
        {
            public void HelloMessage()
            {

            }
        }

        class TestAttrClass
        {
            static void Main()
            {
                var types = from e in Assembly.GetExecutingAssembly().GetTypes()
                            where e.GetCustomAttributes<SampleAttribute>().Count() > 0
                            select e;

                foreach(var type in types)
                {
                    Console.WriteLine(type);
                    foreach( var property in type.GetProperties())
                    {
                        Console.WriteLine(property.Name);
                    }

                    foreach(var method in type.GetMethods())
                    {
                        Console.WriteLine(method.Name);
                    }
                    
                }
            }
        }

    }
}
