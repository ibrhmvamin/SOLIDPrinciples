//using SOLIDPrinciples.LiskovPrinciple;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples.LiskovPrinciple
//{
//    using System;

//   public abstract class Vehicle
//    {
//        public string Model { get; set; }
//        public abstract void Start();
//        public abstract void Accelerate();
//    }

//   public class Car : Vehicle
//    {
//        public override void Start()
//        {
//            Console.WriteLine($"{Model} car started.");
//        }

//        public override void Accelerate()
//        {
//            Console.WriteLine($"{Model} car accelerating.");
//        }
//    }

//    public class Bicycle : Vehicle
//    {
//        public override void Start()
//        {
//            Console.WriteLine($"{Model} bicycle started.");
//        }

//        public override void Accelerate()
//        {
//            Console.WriteLine($"{Model} bicycle accelerating.");
//        }
//    }

//  public class Motorcycle : Vehicle
//    {
//        public override void Start()
//        {
//            Console.WriteLine($"{Model} motorcycle started.");
//        }

//        public override void Accelerate()
//        {
//            Console.WriteLine($"{Model} motorcycle accelerating.");
//        }
//    }

//    public class VehicleOperator
//    {
//        public void Operate(Vehicle vehicle)
//        {
//            vehicle.Start();
//            vehicle.Accelerate();
//        }
//    }

//   public class Program
//    {
//        static void Main()
//        {
//            var vehicles = new Vehicle[]
//            {
//            new Car { Model = "Sedan" },
//            new Bicycle { Model = "Mountain Bike" },
//            new Motorcycle { Model = "Sport Bike" }
//            };

//           VehicleOperator vehicleOperator = new VehicleOperator();
//            foreach (var vehicle in vehicles)
//            {
//                vehicleOperator.Operate(vehicle);
//                Console.WriteLine();
//            }
//        }
//    }


//}


