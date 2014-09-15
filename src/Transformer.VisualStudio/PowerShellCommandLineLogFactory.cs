﻿using System;
using PowerDeploy.Transformer.Logging;

namespace Transformer.VisualStudio
{
    /// <summary>
    /// Uses a cmdlet to log to
    /// 
    /// Made public so its testable
    /// </summary>
    /// <remarks>https://github.com/ServiceStackV3/ServiceStackV3 BSD Licence.</remarks>
    public class PowerShellCommandLineLogFactory : ILogFactory
    {
        public ILog GetLogger(Type type)
        {
            return new PowerShellConsoleLogger();
        }

        public ILog GetLogger(string typeName)
        {
            return new PowerShellConsoleLogger();
        }
    }
}