﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILoggerManager
    {
        void LogInfos(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);

    }
}
