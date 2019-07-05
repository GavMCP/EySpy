﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EySpy.Models
{
    public class Log
    {
        public string PathToLog { get; set; }
        public bool LogPathExist { get; set; }
        public StringBuilder LogWriter { get; set; }
    }
}