using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5app
{
    internal class Human
    {
        public string firstname = "Denis";
        public string lastname;

        //constructor
        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;   
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} and my lastname is {1}", firstname, lastname);
        } 
    }
}
