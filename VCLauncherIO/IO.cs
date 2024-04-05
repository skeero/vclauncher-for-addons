using System.IO;

public class IO
{
    /// <summary>
    /// Write to the file, even if not exists.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
    public static void WriteFile(string path, string content)
    {
        try
        {
            File.WriteAllText(path, content);
        }
        catch { }
    }

    /// <summary>
    /// Read the file if exists.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string ReadFile(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch { return null; }
    }
}