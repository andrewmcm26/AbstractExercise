﻿using System;
namespace AbstractExercise
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Wheels = 2;
            Doors = 0;
        }
        public override void Drive()
        {
            Console.WriteLine($"A motorcycle drives with {Wheels} wheels and has {Doors} doors.");
        }
    }
}
