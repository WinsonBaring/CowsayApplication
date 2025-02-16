using System;
using System.Diagnostics;

public static class Program2
{
    public static void ExecuteCowsay()
    {
        ProcessStartInfo cowsay = new()
        {
            FileName = "cowsay",
            Arguments = "-f dragon-and-cow",
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using Process process = new() { StartInfo = cowsay };

        process.Start();
        process.StandardInput.WriteLine("winson");
        process.StandardInput.Close();
        string cowsayResult = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        ProcessStartInfo lolcat = new()
        {
            FileName = "lolcat",
            Arguments = "--force",
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using Process lolcatProcess = new() { StartInfo = lolcat };

        lolcatProcess.Start();
        lolcatProcess.StandardInput.Write(cowsayResult);
        lolcatProcess.StandardInput.Close();
        string lolcatResult = lolcatProcess.StandardOutput.ReadToEnd();
        lolcatProcess.WaitForExit();

        Console.WriteLine(lolcatResult);

        File.WriteAllText("result2.txt", cowsayResult);
    }

}
