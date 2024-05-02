using ClassProject001;

namespace ClassProject003;

public class CustomerReservation001
{
    public Customer c {get; set;}
    public Reservation r1 {get; set;}

    public CustomerReservation001(Customer c, Reservation r1 )
    {
        this.c = c;
        this.r1 = r1;
    }

}
