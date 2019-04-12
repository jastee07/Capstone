using SAA.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.PSSE
{
    public static class APIWrapper
    {
        private static Process commandProcess;

        public static ShellViewModel ShellViewModel;

        public static void Initialize()
        {
            commandProcess = new Process();
            commandProcess.StartInfo.UseShellExecute = false;
            commandProcess.StartInfo.RedirectStandardOutput = true;
            commandProcess.StartInfo.CreateNoWindow = true;
            commandProcess.StartInfo.FileName = "cmd.exe";
        }

        public static void RunCommand(string command)
        {
            Initialize();
            commandProcess.StartInfo.Arguments = "/C " + command;
            commandProcess.OutputDataReceived += (sender, args) => { ShellViewModel.AddOutput(args.Data); };
            commandProcess.Start();
            commandProcess.BeginOutputReadLine();
            //commandProcess.WaitForExit();
        }
    }
}
