using System.Diagnostics;

namespace API.Utils
{
    public static class Log
    {
        public static void Debugg(string msg)
        {
            Debug.WriteLine($"[Debugger] {msg}");
        }

    }
}
