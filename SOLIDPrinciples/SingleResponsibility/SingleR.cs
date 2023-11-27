//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples.SingleResponsibility
//{
//    using System;

//    public class FileManager
//    {
//        public void SaveToFile(string data, string filePath)
//        {
//            System.IO.File.WriteAllText(filePath, data);
//        }

//        public string ReadFromFile(string filePath)
//        {
//            return System.IO.File.ReadAllText(filePath);
//        }
//    }

//    public class Calculator
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }

//        public int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            FileManager fileManager = new FileManager();
//            string dataToSave = "Hello!";
//            string filePath = "example.txt";
//            fileManager.SaveToFile(dataToSave, filePath);

//            string loadedData = fileManager.ReadFromFile(filePath);
//            Console.WriteLine("Data loaded from file: " + loadedData);

//            Calculator calculator = new Calculator();
//            int sum = calculator.Add(5, 3);
//            int product = calculator.Multiply(4, 7);

//            Console.WriteLine("Sum: " + sum);
//            Console.WriteLine("Product: " + product);
//        }
//    }
//}
