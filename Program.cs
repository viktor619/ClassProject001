using System.Runtime.CompilerServices;
using ClassProject003;

namespace ClassProject001;

class Program
{
    
    private static Customers001 customers;
    private static List<Reservation_001> reservation;
    private static List<CustomerReservation001> customerReservations;    //everyone helped with this
    private static Customer001 authenticatedCustomer001;
    public static Employee001 employee001;
    public static Employee001 authenticatedEmployee;

    static void Main(string[] args)
    {
        Console.WriteLine("Initializing...");    //gerardo's code 
        Initialize();
        Menu();
    }

    static void Initialize()
    {
        var c1 = new Customer001
        {
            FirstName = "Terrence",
            LastName = "Ow",                    //viktor's code 
            Username = "Terbear",
            Password = "6996"
        };

        var c2 = new Customer001
        {
            FirstName = "Gerardo",
            LastName = "Perez",
            Username = "Gerbear",
            Password = "0831"
        };

        var e1 = new Employee
        {
            FName = "Spongebob",
            LName = "Squarepants",
            username = "bobpants",
            password = "gary"
        };

        var e2 = new Employee
        {
            FName = "Patrick",
            LName = "Star",
            username = "rocky",
            password = "starz"
        };

        var r1 = new Reservation_001();
        var r2 = new Reservation_001();
        var r3 = new Reservation_001();

        var cb1 = new CustomerReservation001(c1, r1);
        var cb2 = new CustomerReservation001(c2, r2);
        var cb3 = new CustomerReservation001(c2, r3);
                                                                                //the first var until the last reservation was shayaan 
        customers = new Customers001();
        customers.customerList.Add(c1);
        customers.customerList.Add(c2);

        customerReservations = new List<CustomerReservation001>();
        customerReservations.Add(cb1);
        customerReservations.Add(cb2);
        customerReservations.Add(cb3);

        reservation = new List<Reservation_001>();
        reservation.Add(r1);
        reservation.Add(r2);
        reservation.Add(r3);

    }

    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Options: Login: 1, Logout: 2, Sign Up: 3, Reservation: 4, Quit: q");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    LogOutMenu();
                    break;
                case "3":                                    //brayan's method of code 
                    SignUpMenu();
                    break;
                case "4":
                    ReservationMenu();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

        }


    }

    static void LoginMenu()
    {
        if(authenticatedCustomer001 == null)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
                                                                                             //gerardo's code 
            authenticatedCustomer001 = customers.Authenticate(username, password);
            if (authenticatedCustomer001 != null)
            {
                Console.WriteLine($"Welcome {authenticatedCustomer001.FirstName}");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
            
            
        }




    }

    static void LogOutMenu()
    {
        authenticatedCustomer001 = null;                  //brayan's code 
        Console.WriteLine("Logged out!");          
    }

    static void SignUpMenu()
    {
        Console.Write("First Name: ");
        string firstname = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastname = Console.ReadLine();
        Console.Write("Username: ");                            //shayaan's code 
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var newCustomer = new Customer001
        {
            FirstName = firstname,
            LastName = lastname,
            Username = username,
            Password = password
        };
        customers.customerList.Add(newCustomer);
        Console.WriteLine("Profile created!");
        
    }

    static void ReservationMenu()
    {
        if (authenticatedCustomer001 == null)
        {                                                           //viktor's code this whole method 
            Console.WriteLine("Please log in first!");
            return;
        }

        var ReservationList = customerReservations.Where(o => o.c.Username == authenticatedCustomer001.Username);

        if(ReservationList.Count() == 0)
        {
            Console.WriteLine("0 appointments found.");
        }
        else
        {
            foreach(var reservation001 in ReservationList)
            {
                Console.WriteLine("Create a reservation");
            }
        }
        
    }

}

//looked over and added everything together, made sure it was all running properly 






//main to dev