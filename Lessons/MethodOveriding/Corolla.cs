﻿using System;

namespace MethodOveriding
{
    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with the Corolla clock");
        }
    }
}
