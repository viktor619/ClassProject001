namespace ClassProject001;

public class Reservation_001
{
public class Reservation
{
    private static int autoIncrement;
    public int AccountId {get;}
    public DateTime dateTime {get; set;}

    public Reservation()
    {
        autoIncrement++;
        AccountId = autoIncrement;
    }

}




}
