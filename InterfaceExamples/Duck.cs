using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    class Duck : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Quack, I'm a flying duck");
        }
    }

    class Airplane : ITakeOff
    {
        public void Fly()
        {
            Console.WriteLine("we're flying on a plane");
        }

        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }

    class Helicopter : ITakeOff
    {
        public void Fly()
        {
            Console.WriteLine("hovering in a helicopter");
        }

        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }


    interface IFlyable
    {
        void Fly();
    }

    interface ITakeOff : IFlyable
    {
        void TakeOff(string destination);
    }


}
