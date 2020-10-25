using System;
namespace SpinningDiscs
{
    abstract class BasicDisk
    {
        public string DiskName { get; set; }
        public int SpinRate { get; set; }
        public int Capacity { get; set; }
        public string DiskContents { get; set; }

        public BasicDisk(string name, int rate, int capacity, string contents)
        {
            DiskName = name;
            SpinRate = rate;
            Capacity = capacity;
            DiskContents = contents; 
        }
        public int CheckCapacity()
        {
            return Capacity; 
        }

    }

}
