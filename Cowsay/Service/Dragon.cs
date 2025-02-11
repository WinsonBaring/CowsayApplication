using System.Diagnostics;
using Animal.Interfaces;

namespace Animal.Services
{
    public class Dragon : AnimalInterface
    {
        public string AnimalType { get;  } = "Dragon";
        public string GenerateAnimalMessage(string message)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cowsay",
                Arguments = $"-f dragon \"{message}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            };

            using var process = new Process { StartInfo = processStartInfo };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
        }
    }
}