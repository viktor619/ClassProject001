namespace ClassProject001;

public class Employee
{
    private static int increaseID = 0;
    public int EmployeeId{get; set;}
    public string FName{get; set;}
    public string LName{get; set;}
    
    public string address{get; set;}
    public string phoneNumber{get; set;}
    public string username{get; set;}
    public string password{get; set;}


    
    public Employee()
    {
        increaseID++;
        EmployeeId = increaseID;
    }

 
}
