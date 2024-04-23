using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

namespace ClassProject001;

public class CustomerAppointment
{
    public Customer c {get; set;}
    public Appointment a {get; set;}   

    public CustomerAppointment(Customer c, Appointment a)
    {
        this.c = c;
        this.a = a;
    }
}
