//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples.OpenClose
//{
//    public abstract class Shape
//    {
//        public abstract double Area();
//    }

//    public class Rectangle : Shape
//    {
//        public double Width { get; set; }
//        public double Height { get; set; }

//        public override double Area()
//        {
//            return Width * Height;
//        }
//    }

//    public class Circle : Shape
//    {
//        public double Radius { get; set; }

//        public override double Area()
//        {
//            return Math.PI * Radius * Radius;
//        }
//    }

//    // Butun hesablamalar AreaCalculator classinda bas verir ve eger fiqurlarin 
//    // sayi artsa bele rahatliqla elave edib hec bir deyisiklik etmeye ehtiyac yoxdu
//   public class AreaCalculator
//    {
//        public double TotalArea(Shape shape)
//        {
//            double totalArea = 0;
            
//                totalArea += shape.Area();
            
//            return totalArea;
//        }
//    }

//   class Program
//    {
//        static void Main()
//        {
//           Shape[] shapes = new Shape[]
//            {
//            new Rectangle { Width = 5, Height = 10 },
//            new Circle { Radius = 7 }
//            };

//            AreaCalculator calculator = new AreaCalculator();
//            for (int i = 0; i < shapes.Length; i++) 
//            {
//                double totalArea = calculator.TotalArea(shapes[i]);
//                Console.WriteLine("Total area of shapes: " + totalArea);
//            }
//        }
//    }
//}
