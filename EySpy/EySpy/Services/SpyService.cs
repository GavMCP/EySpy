﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EySpy.Models;
using EySpy.Services;


namespace EySpy
{
    public static class SpyService
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private const int NCHARS = 256;
        private static StringBuilder buff = new StringBuilder(NCHARS);
        private static string SavedWindowTitle;
         


        static SpyService()
        {
            SetActiveWindowTitle();
        }


        public static void SetActiveWindowTitle()
        {
            IntPtr handle = GetForegroundWindow();
            SavedWindowTitle = GetWindowText(handle, buff, NCHARS) > 0 ? buff.ToString() : null;
        }


        public static void CheckActiveWindow()
        {
            IntPtr handle = GetForegroundWindow();
            string currentWindowTitle = GetWindowText(handle, buff, NCHARS) > 0 ? buff.ToString() : null;


            if (currentWindowTitle != SavedWindowTitle)
            {
                SavedWindowTitle = currentWindowTitle;
                LogService.WriteToLog(LogService.GetLogPath(), currentWindowTitle);

                Console.WriteLine(currentWindowTitle);
            }
            Thread.Sleep(1000);
        }

        public static void CheckActiveWindow(double minutes)
        {
            double checkTimer = minutes * 60000;

        }

    }
}