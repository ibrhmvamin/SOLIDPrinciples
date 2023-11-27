//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLIDPrinciples.InterfaceSegregation
//{
//    public class InterfaceSegregate
//    {
//        public interface IPrinter
//        {
//            void Print();
//        }

//        public interface IScanner
//        {
//            void Scan();
//        }

//        public interface IFax
//        {
//            void Fax();
//        }

//        /// <summary>
//        /// Interfaceleri bolub printlerin adina gore ayirmisam.Bu printer multi
//        /// funksional oldugu ucun her 3 interfaceden implement olunub
//        /// </summary>
//        public class MultiFunctionalPrinter : IPrinter, IScanner, IFax
//        {
//            public void Print()
//            {
//                Console.WriteLine("Printing...");
//            }

//            public void Scan()
//            {
//                Console.WriteLine("Scanning...");
//            }

//            public void Fax()
//            {
//                Console.WriteLine("Faxing...");
//            }
//        }

//       public class BasicPrinter : IPrinter
//        {
//            public void Print()
//            {
//                Console.WriteLine("Printing...");
//            }
//        }

//        public class BasicScanner : IScanner
//        {
//            public void Scan()
//            {
//                Console.WriteLine("Scanning...");
//            }
//        }

//       public class BasicFaxMachine : IFax
//        {
//            public void Fax()
//            {
//                Console.WriteLine("Faxing...");
//            }
//        }

//       class Program
//        {
//            static void Main()
//            {
//                MultiFunctionalPrinter multifunctionalPrinter = new MultiFunctionalPrinter();
//                multifunctionalPrinter.Print();
//                multifunctionalPrinter.Scan();
//                multifunctionalPrinter.Fax();

//                BasicPrinter basicPrinter = new BasicPrinter();
//                basicPrinter.Print();

//                BasicScanner basicScanner = new BasicScanner();
//                basicScanner.Scan();

//                BasicFaxMachine basicFaxMachine = new BasicFaxMachine();
//                basicFaxMachine.Fax();
//            }
//        }
//    }
//}
