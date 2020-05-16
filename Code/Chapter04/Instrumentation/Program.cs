﻿using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace Instrumentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",
            optional:true,
            reloadOnChange:true);
            IConfigurationRoot configuration = builder.Build();
            var ts = new TraceSwitch(
                displayName:"PacktSwitch",
                description: "This switch is set via a JSON config.");
            configuration.GetSection("PacktSwitch").Bind(ts);
            Trace.WriteLineIf(ts.TraceError, "Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
            
        }
    }
}
