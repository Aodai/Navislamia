﻿using Autofac;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

using Serilog;
using Serilog.Events;

using Spectre.Console;

namespace Notification
{
    public class NotificationModule : INotificationService
    {
        public NotificationModule()
        {
            Log.Logger = new LoggerConfiguration()
                            //.MinimumLevel.ControlledBy(LogLevel)
                            .WriteTo.File(".\\Logs\\Navislamia-Log-.txt", rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {Message:lj}{NewLine}{Exception}")
                            .CreateLogger();
        }

        public void WriteMarkup(string message, LogEventLevel level = LogEventLevel.Verbose)
        {
            AnsiConsole.Write(new Markup($"{message}\n"));
            Log.Write(level, message);
        }

        public void WriteString(string message, LogEventLevel level = LogEventLevel.Verbose)
        {
            AnsiConsole.Write($"{message}\n");
            Log.Write(level, message);
        }

        public void WriteSuccess(string message, LogEventLevel level = LogEventLevel.Verbose)
        {
            throw new NotImplementedException();
        }

        public void WriteException(Exception exception, LogEventLevel level = LogEventLevel.Error)
        {
            AnsiConsole.WriteException(exception);
            Log.Write(level, exception, "An exception has occured!");
        }
    }
}
