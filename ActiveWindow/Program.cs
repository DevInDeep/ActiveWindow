using System;
using ActiveWindow.BLL.ActiveWindow;

namespace ActiveWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            var activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromMilliseconds(500));
            activeWindowWatcher.ActiveWindowChanged += (o, e) => Console.WriteLine($"Active Window: {e.ActiveWindow}");
            activeWindowWatcher.Start();
            
            Console.ReadLine();
        }
    }
}
