using System.Collections.Concurrent;

namespace BackgroundAppDemo
{
    public class Sampledata
    {
        //Allow a list or something similar to list accessible from multiple threads
        public ConcurrentBag<string> Data { get; set; } = new();
    }
}
