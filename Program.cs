List<Employee> employees = new List<Employee>()
{
    new Employee
    {
         Id = 1,
         Name = "first1"
    },
    new Employee
    {
        Id = 2,
        Name = "second"
    }
};

// we will have issue like this Collection was modified; enumeration operation may not execute.',

foreach (var employee in employees)
{
    employees.Remove(employee);
}

// without creating new object and assigning it, we can solve it like below

foreach (var employee in employees.ToList())
{
    employees.Remove(employee);
}

Console.WriteLine(employees.Count);
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}