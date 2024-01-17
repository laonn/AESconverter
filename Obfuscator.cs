using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AESconverter
{
    internal class Obfuscator
    { 
        public static string luajit = "Luajit\\luajit";
        public static string luajitPath = Application.StartupPath + luajit;

        public static string currentPath = string.Empty;

        public static string Obfuscate(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = luajitPath;
            process.StartInfo.Arguments = path;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();
            process.WaitForExit();

            return process.StandardOutput.ReadToEnd();
        }

        public static void GetByteCode(string destination)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Application.StartupPath + "Luajit"
            };

            Process process = new Process()
            {
                StartInfo = startInfo
            };

            process.Start();

            process.StandardInput.WriteLine("luajit -b {0} {1}\\IMHERE", currentPath, destination);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }
    }
}
