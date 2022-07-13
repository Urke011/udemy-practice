using System;

namespace Net5app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //console stay open
            // Console.Read();

            //datatype
            //declarin variale
            int num1;
            //assigning a value
            num1 = 7;
            //Console.Write(); -prints and the cursor stay in the SAME LINE

            //Console.WriteLine(); -prints and puts the cursor in the NEXT LINE

            //Console.Read() - takes a  single input of type string and it returns ths ASCII value of that input

            //Console.ReadLine(); - takes a string or int input and returns it as the output value

            //Console.ReadKey() - takes a single input of type string and it returns the Key Info

            //CONVERSION
            //implicit
            int num = 1232445256;
            long bigNum = num;

            //explicet
            double myDouble = 13.37;
            int myInt;
            //cast double into int 
            myInt = (int)myDouble;

            //type conversion

            string myString = myDouble.ToString();
            //Console.WriteLine(myString); "13.37"

            //Parsing string to int

            string myStringNum = "15";
            int numString = Int32.Parse(myStringNum);

            //test
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int


            int i = Int32.Parse(stringForInt);
            float f = float.Parse(stringForFloat);

            //System.Console.WriteLine("Int = {0}, Float = {1}", i, f);
            //WhileLoop();
            //ForLoop();

            Run();

        }
        public static void ForLoop()
        {
            // TODO
           
            for (int j = -3; j <= 3; j++)
            {
                Console.WriteLine(j);
            }
        }

        public static void WhileLoop()
        {
            int counter = 3;
            // TODO
            while (counter >= -3)
            {
                Console.WriteLine(counter);
                counter--;
            }
        }
        public static void Run()
        {
            int i = -10;

            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                    break;
                Console.WriteLine(i++);
            }
        }
    }
}
