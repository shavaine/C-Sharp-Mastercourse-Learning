﻿using System;

namespace MethodOveriding
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        public abstract void SetClock();
    }
}
