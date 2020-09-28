using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using WarBrief.Models;

namespace WarBrief.Utils
{
    class FileObserver
    {
        private FileSystemWatcher watcher;

        private readonly Queue<string> fileQueue;

        public FileObserver()
        {
            fileQueue = new Queue<string>();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Run(object targetDirectory)
        {
            using (watcher = new FileSystemWatcher())
            {
                watcher.Path = targetDirectory as string;

                watcher.NotifyFilter = NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.Filter = "*.log";

                //watcher.Created += OnCreated;
                watcher.Changed += OnChanged;
                //watcher.Renamed += OnRenamed;
                //watcher.Deleted += OnDeleted;

                watcher.EnableRaisingEvents = true;

                while (true)
                {
                    try
                    {
                        Thread.Sleep(10);
                    }
                    catch (System.Threading.ThreadInterruptedException e)
                    {
                        Console.Error.WriteLine($"FileObserver: {e}");
                        break;
                    }
                }

                watcher.EnableRaisingEvents = false;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"FileObserver.OnChanged: {e.Name}");

            if (fileQueue.Contains(e.FullPath))
            {
                return;
            }

            if (e.Name.StartsWith("player"))
            {
                OnPlayerChange(e.FullPath);
            }
        }

        private void OnPlayerChange(string path)
        {
            fileQueue.Enqueue(path);

            string data = GetJsonString(path);
            Player player = JsonSerializer.Deserialize<Player>(data);
            Console.WriteLine($"FileObserver.Player: {player.Health}");

            fileQueue.Dequeue();
        }

        private void OnChangeOpponent(string path)
        {
            
        }

        private void OnChangeRibbon(string path)
        {

        }

        private string GetJsonString(string path)
        {
            byte[] buffer = new byte[1024];
            int i = 0;
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                for (i = 0; i < buffer.Length; i++)
                {
                    int bite = stream.ReadByte();
                    if (bite == -1)
                    {
                        break;
                    }
                    buffer[i] = (byte)bite;
                }
            }

            return Encoding.Default.GetString(buffer, 0, i);
        }
    }
}
