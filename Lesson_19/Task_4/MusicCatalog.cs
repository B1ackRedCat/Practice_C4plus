using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class MusicCatalog
    {
        Hashtable disks = new Hashtable();

        public void AddDisk(string diskName)
        {
            disks[diskName] = new ArrayList();
        }

        public void RemoveDisk(string diskName)
        {
            disks.Remove(diskName);
        }

        public void AddSong(string diskName, string songName)
        {
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs == null)
            {
                songs = new ArrayList();
                disks[diskName] = songs;
            }
            songs.Add(songName);
        }

        public void RemoveSong(string diskName, string songName)
        {
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs != null)
            {
                songs.Remove(songName);
            }
        }

        public void PrintCatalog()
        {
            Console.WriteLine("Music Catalog:");
            foreach (string diskName in disks.Keys)
            {
                Console.WriteLine($"- {diskName}:");
                ArrayList songs = (ArrayList)disks[diskName];
                foreach (string songName in songs)
                {
                    Console.WriteLine($"  - {songName}");
                }
            }
        }

        public void PrintDisk(string diskName)
        {
            Console.WriteLine($"Disk {diskName}:");
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs != null)
            {
                foreach (string songName in songs)
                {
                    Console.WriteLine($"- {songName}");
                }
            }
        }
    }
}
