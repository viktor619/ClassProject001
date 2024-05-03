namespace ClassProject001;

public class Employee001
{
    public List<Employee> employeesList {get; set;}

    public Employee001()
    {
        employeesList = new List<Employee>();
    }

    public Employee Authenticate(string username, string password)
    {
        var e = employeesList.Where(e => (e.username == username) && (e.password == password));

        if (e.Count() > 0)
        {
            return e.First();
        }
        else
        {
            return null;
        }
    }

}
