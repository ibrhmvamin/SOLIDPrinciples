using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversion
{
   

    // high level classimiz
    public class BusinessLogic
    {
        private readonly IDataAccess dataAccess;

       public BusinessLogic(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            Console.WriteLine("Processing data using DataAccess.");
            dataAccess.SaveData("Some data");
        }
    }

    // abstraksiya
    public interface IDataAccess
    {
        void SaveData(string data);
    }

    // IDataAccess interface inden implemenmt olunan low level classlarimiz
    public class SqlDataAccess : IDataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data to SQL database: {data}");
        }
    }

    public class FileDataAccess : IDataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data to file: {data}");
        }
    }

    public class Program
    {
        static void Main()
        {
            IDataAccess sqlDataAccess = new SqlDataAccess();
            BusinessLogic businessLogicSql = new BusinessLogic(sqlDataAccess);
            businessLogicSql.ProcessData();

            IDataAccess fileDataAccess = new FileDataAccess();
            BusinessLogic businessLogicFile = new BusinessLogic(fileDataAccess);
            businessLogicFile.ProcessData();
        }
    }

}
