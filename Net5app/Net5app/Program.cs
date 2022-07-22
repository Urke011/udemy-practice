using System;

namespace Net5app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.lenght = 3;
            box.height = 2;
            box.width = 2;

            box.DisplayInfo();

            //create obj
            Human uros = new Human("Uros", "Rajkovic");
            //access public variable from outside
           // uros.firstname = "Uros";
            //uros.lastname = "Rajkovic";
            //call method of class
            uros.IntroduceMyself();    
              Human denis = new Human("Denis", "Panjutha");
           // denis.lastname = "Panjutha";
            denis.IntroduceMyself();
            Console.ReadKey();
        }
        
    }
}
