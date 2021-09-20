using System.Runtime.CompilerServices;

namespace ConsoleApp102
{
    interface ILogger
    {
        void Log(object info, [CallerMemberName] string caller = "");
    }
}