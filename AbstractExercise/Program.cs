using System;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var bike = new Motorcycle();
            car.Drive();
            bike.Drive();

        }
    }
}
