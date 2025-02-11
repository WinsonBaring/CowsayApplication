using System;
using System.Diagnostics;
using System.Globalization;
using Cowsay.Interfaces;

namespace Cowsay.Services
{
    public class Cow : ICowsayService
    {
        public string GenerateCowsayMessage(string message)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cowsay";
            process.StartInfo.Arguments = $"\"{message}\""; 
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
            }
        }
    }
    public class Dragon : ICowsayService
    {
        public string GenerateCowsayMessage(string message)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cowsay";
                process.StartInfo.Arguments = $"\"{message}\" -f dragon-and-cow"; 
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();

                var result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return result;
            }
        }
    }
}
