using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5app
{
    internal class Box
    {
        //member variable
        public int lenght;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("lenght is {0} and height is {1} and width {2} and volume  {3}", lenght, height, width, volume = lenght * height * width);
        }

    }
}
