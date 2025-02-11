using System;
using System.Diagnostics;
using System.Globalization;
using Animal.Interfaces;

namespace Animal.Services
{
    public class Cow : AnimalInterface
    {
        public string AnimalType { get; } = "Cow";
        public string GenerateAnimalMessage(string message)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cowsay",
                Arguments = $"-f dragon \"{message}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = new Process { StartInfo = processStartInfo };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
        }
    }

}
