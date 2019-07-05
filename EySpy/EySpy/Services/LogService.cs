﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EySpy.Models;
using EySpy.Services;


namespace EySpy.Services
{
    public static class LogService
    {
        private const string _savedLogPath = @"C:\\Users\Gavin\source\repos\EySpy\SavedLog\ViewingLog.txt";
        
        public static bool CheckLogExists()
        {
            if (File.Exists(_savedLogPath))
            {
                return true;
            }

            return false;
        }


        public static string GetLogPath()
        {
            return _savedLogPath;
        }


        public static void WriteToLog(string logLocation, string value)
        {
            try
            {
                using (StreamWriter logInput = new StreamWriter(logLocation, append: true))
                {
                    logInput.WriteAsync(DateTime.Now +" : "+ value +"\n");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The logfile that should be located at {logLocation} could not be found.");
            }
        }

    }
}