using RecyclingStation.BusinessLayer.Contracts.IO;
using System;
using System.Text;

namespace RecyclingStation.BusinessLayer.IO
{
    public class Writer : IWriter
    {
        private StringBuilder outputGahterer;

        public Writer(StringBuilder outputGahterer)
        {
            this.OutputGahterer = outputGahterer;
        }

        public Writer() : this(new StringBuilder())
        {
            
        }

        public StringBuilder OutputGahterer
        {
            get
            {
                return this.outputGahterer;
            }

            set
            {
                this.outputGahterer = value;
            }
        }

        public void GatherOutput(string outputGather)
        {
            this.OutputGahterer.AppendLine(outputGather);
        }

        public void WriteGatheredOutput()
        {
            Console.WriteLine(this.OutputGahterer.ToString().Trim());
        }
    }
}
