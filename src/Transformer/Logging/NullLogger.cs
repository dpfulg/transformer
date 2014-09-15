﻿using System;
using PowerDeploy.Transformer.Logging;

namespace PowerDeploy.Common.Logging
{
    /// <summary>
    /// Default logger is to System.Diagnostics.Debug.Print
    /// 
    /// Made public so its testable
    /// </summary>
    /// <remarks>https://github.com/ServiceStackV3/ServiceStackV3 BSD Licence.</remarks>
    public class NullLogger : ILog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugLogger"/> class.
        /// </summary>
        public NullLogger(string type)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugLogger"/> class.
        /// </summary>
        public NullLogger(Type type)
        {
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        private static void Log(object message, Exception exception)
        {
        }

        /// <summary>
        /// Logs the format.
        /// </summary>
        private static void LogFormat(object message, params object[] args)
        {
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        private static void Log(object message)
        {
        }

        public void Debug(object message, Exception exception)
        {
        }

        public void Debug(object message)
        {
        }

        public void DebugFormat(string format, params object[] args)
        {
        }

        public void Print(object message)
        {
        }

        public void PrintFormat(string format, params object[] args)
        {
        }

        public void Error(object message, Exception exception)
        {
        }

        public void Error(object message)
        {
        }

        public void ErrorFormat(string format, params object[] args)
        {
        }

        public void Fatal(object message, Exception exception)
        {
        }

        public void Fatal(object message)
        {
        }

        public void FatalFormat(string format, params object[] args)
        {
        }

        public void Info(object message, Exception exception)
        {
        }

        public void Info(object message)
        {
        }

        public void InfoFormat(string format, params object[] args)
        {
        }

        public void Warn(object message, Exception exception)
        {
        }

        public void Warn(object message)
        {
        }

        public void WarnFormat(string format, params object[] args)
        {
        }
    }
}