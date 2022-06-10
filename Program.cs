using System.Threading;
using System.Diagnostics;
using System;
using MProcess;

namespace SeassonSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int pid = ProcessAccess.GetPidWithName("GTA5");
            ProcessAccess.SuspendProcess(pid);

            Console.WriteLine($"PID : {pid}");
            Thread.Sleep(10000);

            ProcessAccess.ResumeProcess(pid);
        }
    }
}
