using System;
using System.Diagnostics;
using System.Linq;

public class Runner
{
    /// <summary>
    /// Run the process in the current directory where this APP runs with additional parameters.
    /// </summary>
    /// <param name="addon"></param>
    /// <param name="module"></param>
    public static void Run(string addon, string module = "vietcong.exe")
    {
        Process proc = new Process()
        {
            StartInfo = new ProcessStartInfo(addon)
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        proc.Start();
        proc.StandardInput.WriteLine("cd " + Environment.CurrentDirectory.First() + ":");
        proc.StandardInput.WriteLine("cd \"" + Environment.CurrentDirectory + "\"");
        proc.StandardInput.WriteLine("start \"\" \"" + module + "\" " + addon);
        proc.StandardInput.WriteLine("exit");
    }
}
