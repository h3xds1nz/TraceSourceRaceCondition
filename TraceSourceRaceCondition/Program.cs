//Created on 7th Jul 2024
//by h3xds1nz

using System.Diagnostics;
using System.Threading;
using System;

namespace TraceSourceRaceCondition;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var backgroundThread = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread.Start();

        var backgroundThread2 = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread2.Start();

        var backgroundThread3 = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread3.Start();

        var backgroundThread4 = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread4.Start();

        var backgroundThread5 = new Thread(RefreshTraceSourcesInEndlessLoop)
        {
            IsBackground = true
        };

        backgroundThread5.Start();

        var app = new App();
        app.InitializeComponent();
        app.Run();
    }

    private static void RefreshTraceSourcesInEndlessLoop() //It will take you like 2-3 attempts, if you want it instantly, set BP to Listeners in TraceSource.cs
    {
        //Easy Fix: Thread.Sleep(1000);
        while (true)
        {
            Trace.Refresh();
        }
    }
}
