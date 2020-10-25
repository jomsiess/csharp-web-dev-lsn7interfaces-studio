using System;
namespace SpinningDiscs
{
    public class CD: BasicDisk, IOpticalDisc 
    {
        // TODO: Implement your custom interface.
        public void SpinDisk()
        {
            Console.WriteLine("Disk is now spinning.");
        }
        public void PlayDisk()
        {
            Console.WriteLine("Disk is now playing!");
        }
        public void StopDisk()
        {
            Console.WriteLine("Disk is now sopped!");
        }

        public CD(string name, int rate, int capacity, string contents) : base(name, rate, capacity, contents) {}
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

    }
}
