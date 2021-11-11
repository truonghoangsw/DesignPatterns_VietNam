using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatterns
{
    public enum CarType
    {
        Sedan,
        Crossover
    };
    public class Car
    {
        public CarType Type;
        public int WheelSize;
    }

    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType carType);
    }
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int wheelSize);
    }
    
    public interface IBuildCar
    {
        Car Build();
    }

    public interface BuilderCar
    {
        private class Imp: ISpecifyWheelSize, IBuildCar, ISpecifyCarType
        {
            private Car car = new Car();
            public ISpecifyWheelSize OfType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (car.Type)
                {
                    case CarType.Crossover when size < 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                        throw new ArgumentException($"Wrong size of wheel for {car.Type}.");
                }
                car.WheelSize = size;
                return this;
            }

            public Car Build()
            {
                return car;
            }
        }
       
    }
  
}
