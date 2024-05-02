namespace ClassProject001;

public class Customer001
{
     private static int autoIncrement;
    public int Id {get;}
    public int PhoneNumber{get; set;}
    public string Username {get; set;}
    public string Password {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    

    public Customer001()
    {
        autoIncrement++;
        Id = autoIncrement;
    }
}
