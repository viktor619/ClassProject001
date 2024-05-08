using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

namespace ClassProject001;

public class CustomerReservation
{
    public Customer c {get; set;}
    public CustomerReservation r {get; set;}   

    public CustomerReservation(Customer c, CustomerReservation r)
    {
        this.c = c;
        this.r = r;
    }









    //1. create main repository and publish to gitbuh
    //2. right click and create development and publish
    //3. team members clone 
    //4. end up with main in the branches 
    //5. right click on development and create a branch on remote 
    //6. right click on development, fech(only grabs a comparison) changes, then pull(updates changes)
    //7. make sure development branch is up to date 
    //8. right click on branch development and create another branch, publish 
    //9. then only work on that last branch from 8 
    //10. pull request in remote branch to development 

    //after editing class go to source control add description then commit and push 
    //go to github, pull request, new pull request,  base is development with the branch, create pull request, merge pull request 
    //then go to branches, right click on development, fech and pull, right click on development and create new branch, swith to it and publish 
}
