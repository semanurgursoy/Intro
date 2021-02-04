using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NeedCrediManager needCrediManager = new NeedCrediManager();
            //needCrediManager.Compute();

            //VehicleCrediManager vehicleCrediManager = new VehicleCrediManager();
            //vehicleCrediManager.Compute();

            //HouseCrediManager houseCrediManager = new HouseCrediManager();
            //houseCrediManager.Compute();

            Console.WriteLine("\n\n");

            ICrediManager needCrediManager2 = new NeedCrediManager();          
            ICrediManager vehicleCrediManager2 = new VehicleCrediManager();           
            ICrediManager houseCrediManager2 = new HouseCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(needCrediManager2,loggers);

            List<ICrediManager> credits = new List<ICrediManager>() { needCrediManager2,vehicleCrediManager2 };
            //applicationManager.CrediPreliminaryInformation(credits);
        }
    }
}
