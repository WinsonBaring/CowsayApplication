using System;
using System.Diagnostics;
using Cowsay.Interfaces;

namespace Cowsay.Services
{
    public class CowsayService : ICowsayService
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
}
