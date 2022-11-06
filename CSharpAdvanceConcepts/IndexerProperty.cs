
namespace CSharpAdvanceConcepts
{
    class IndexerProperty
    {

    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    class Company
    {
        List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "David" });
            employees.Add(new Employee() { Id = 2, Name = "Sam" });
            employees.Add(new Employee() { Id = 3, Name = "Nord" });
        }
        
        public string this[int id]
        {
            get
            {
                return employees.FirstOrDefault(a => a.Id == id).Name;
            }
            set
            {
                employees.FirstOrDefault(e => e.Id == id).Name = value;
            }
        }

        static void Main()
        {
            var obj = new Company();
            Console.WriteLine(obj[1]);
            obj[1] = "David Test";
            Console.WriteLine(obj[1]);
        }

    }
}
