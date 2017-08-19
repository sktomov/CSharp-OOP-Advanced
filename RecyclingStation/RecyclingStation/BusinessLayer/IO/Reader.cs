using RecyclingStation.BusinessLayer.Contracts.IO;
using System;

namespace RecyclingStation.BusinessLayer.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
