﻿namespace Sfa.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;

    using Eds.Das.Indexer.Core.Services;
    using Microsoft.ApplicationInsights.NLogTarget;
    using NLog;
    using NLog.Targets.ElasticSearch;

    public class NLogService : ILog
    {
        private readonly string _loggerType;
        private readonly Dictionary<string, object> _defaultProperties = new Dictionary<string, object>();
#pragma warning disable CS0169
#pragma warning disable S1144 // Unused private types or members should be removed
        private ElasticSearchTarget _dummy; // Reference so assembly is copied to Primary output.
        private ApplicationInsightsTarget _dummy2; // Reference so assembly is copied to Primary output.
#pragma warning restore S1144 // Unused private types or members should be removed
#pragma warning disable CS0169

        public NLogService(Type loggerType)
        {
            _loggerType = loggerType?.ToString() ?? "DefaultIndexLogger";
        }

        public void Trace(object message)
        {
            SendLog(message, LogLevel.Trace);
        }

        public void Debug(object message)
        {
            SendLog(message, LogLevel.Debug);
        }

        public void Debug(object message, Exception exception)
        {
            SendLog(message, LogLevel.Debug, _defaultProperties, exception);
        }

        public void Debug(string message, Dictionary<string, object> properties)
        {
            SendLog(message, LogLevel.Debug, properties);
        }

        public void Info(object message)
        {
            SendLog(message, LogLevel.Info);
        }

        public void Info(string message, Dictionary<string, object> properties)
        {
            SendLog(message, LogLevel.Info, properties);
        }

        public void Info(object message, Exception exception)
        {
            SendLog(message, LogLevel.Info, _defaultProperties, exception);
        }

        public void Warn(object message)
        {
            SendLog(message, LogLevel.Warn);
        }

        public void Warn(object message, Exception exception)
        {
            SendLog(message, LogLevel.Warn, _defaultProperties, exception);
        }

        public void Error(object message)
        {
            SendLog(message, LogLevel.Error);
        }

        public void Error(object message, Exception exception)
        {
            SendLog(message, LogLevel.Error, _defaultProperties, exception);
        }

        public void Fatal(object message)
        {
            SendLog(message, LogLevel.Fatal);
        }

        public void Fatal(object message, Exception exception)
        {
            SendLog(message, LogLevel.Fatal, _defaultProperties, exception);
        }

        private void SendLog(object message, LogLevel level, Dictionary<string, object> properties = null, Exception exception = null)
        {
            var propertiesLocal = new Dictionary<string, object>();
            if (properties != null)
            {
                propertiesLocal = properties;
            }

            propertiesLocal.Add("Application", "Sfa.Das.Web");
            propertiesLocal.Add("LoggerType", _loggerType);

            var logEvent = new LogEventInfo(level, _loggerType, message.ToString()) { Exception = exception };

            foreach (var property in propertiesLocal)
            {
                logEvent.Properties[property.Key] = property.Value;
            }

            ILogger log = LogManager.GetCurrentClassLogger();
            log.Log(logEvent);
        }
    }
}
