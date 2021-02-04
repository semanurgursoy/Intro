using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void Apply(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
            crediManager.Compute();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CrediPreliminaryInformation(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Compute();
            }
        }
    }
}
