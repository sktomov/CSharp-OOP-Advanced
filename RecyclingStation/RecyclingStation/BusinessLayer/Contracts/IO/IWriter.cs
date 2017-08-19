namespace RecyclingStation.BusinessLayer.Contracts.IO
{
    public  interface IWriter
    {
        void GatherOutput(string outputGather);

        void WriteGatheredOutput();
    }
}
