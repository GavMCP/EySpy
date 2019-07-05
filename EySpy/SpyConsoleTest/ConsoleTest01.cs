using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpyConsoleTest
{
    static class ConsoleTest01
    {
        static void Main(string[] args)
        {
            bool logExist = EySpy.Services.LogService.CheckLogExists(); 
            if(!logExist)
            {
                throw new EySpy.Exceptions.LogNotFoundException("Log not found.");
            }

            EySpy.ActivateSpy.StartSpy();
            


        }
    }
}
