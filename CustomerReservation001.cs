using ClassProject001;

namespace ClassProject003;

public class CustomerReservation001
{
    public Customer001 c {get; set;}
    public Reservation_001 b {get; set;}

    public CustomerReservation001(Customer001 c, Reservation_001 b)
    {
        this.c = c;
        this.b = b;
    }

}
