using System;
namespace MembersC
{
    public class Members
    {
        // anything inside the class scope is a member, ANYTHINg

        // a property is a member
        public string Name { get; set; }
        // constructors are members
        public Members()
        {
            Name = "";
            Console.WriteLine("Hello!");
        }

        // methods are members
        public void DoSomething()
        {

        }

        // the destructor is a member
        // INFO: destructors/finalisers are methods that run when an object is
        //  deleted or out of scope
        // NOTE: destructors are usually for resource handling after releasing
        ~Members()
        {
            Console.WriteLine("Farewell!");
        }
    }
}