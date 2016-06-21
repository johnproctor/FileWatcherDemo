using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileSystemWatcherDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher(ConfigurationManager.AppSettings["PathToWatch"]);

            watcher.Created += new FileSystemEventHandler(watcher_FileCreated);

            watcher.EnableRaisingEvents = true;

            Console.ReadKey();

        }

        static void watcher_FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("New file has been created!");
        }
    }
}
