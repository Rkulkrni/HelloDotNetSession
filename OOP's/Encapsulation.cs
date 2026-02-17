using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSession.OOP_s
{
    internal class Car
    {
        // ** Without encapsulation example
        //public int speed;

        //public void CarMethod()
        //{
        //    Console.WriteLine($"speed = {speed}");
        //}

        // ** With encapsiualtion example.

        private int Speed;

        public void SetCarSpeedLimit(int speed)
        {

            if (speed > 0 && speed < 200)
            {
                Console.WriteLine($"Speed is : {speed}");
            }
            else
            {
                Console.WriteLine("Invalid speed");
            }
        }

        public int GetCarSpeedLimit()
        {
            {
                return Speed;

            }
        }
    }
}
