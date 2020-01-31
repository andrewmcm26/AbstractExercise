using System;
namespace AbstractExercise
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public abstract void Drive();
    }
}
