using RecyclingStation.BusinessLayer.Contracts.Core;
using System;

namespace RecyclingStation.BusinessLayer.Core
{
    using System.Linq;
    using System.Reflection;
    using RecyclingStation.BusinessLayer.Contracts.IO;


    public class Engine : IEngine
    {

        private const string TerminatingCommand = "TimeToRecycle";
        private IWriter writer;
        private IReader reader;
        private IRecyclingStation recyclingStation;

        public Engine(IWriter writer, IReader reader, IRecyclingStation recyclingStation)
        {
            this.Writer = writer;
            this.Reader = reader;
            this.RecyclingStation = recyclingStation;
        }

        public IWriter Writer
        {
            get => writer; set => writer = value;
        }

        public IReader Reader
        {
            get => reader; set => reader = value;
        }

        public IRecyclingStation RecyclingStation
        {
            get => recyclingStation;
            set => recyclingStation = value;
        }

        public void Run()
        {
            try
            {
                string inputLine;
                while ((inputLine = this.Reader.ReadLine()) != TerminatingCommand)
                {
                    string[] commandArgs = this.SplitStringByChar(inputLine, ' ');
                    string methodName = commandArgs[0];
                    string[] methodNonParsedParams = default(string[]);

                    if (commandArgs.Length == 2)
                    {
                        methodNonParsedParams = this.SplitStringByChar(commandArgs[1], '|');
                    }

                    MethodInfo[] recyclingStationMethodInfos = this.RecyclingStation.GetType().GetMethods();
                    MethodInfo methodToInvoke = recyclingStationMethodInfos.FirstOrDefault(m => m.Name == methodName);

                    ParameterInfo[] methodParams = methodToInvoke.GetParameters();
                    object[] parsedParams = new object[methodParams.Length];

                    for (int currentMethodParameterIndex = 0; currentMethodParameterIndex < methodParams.Length; currentMethodParameterIndex++)
                    {
                        Type currentParamType = methodParams[currentMethodParameterIndex].ParameterType;
                        string toConvert = methodNonParsedParams[currentMethodParameterIndex];
                        parsedParams[currentMethodParameterIndex] = Convert.ChangeType(toConvert, currentParamType);
                    }

                    object result = methodToInvoke.Invoke(this.RecyclingStation, parsedParams);
                    this.Writer.GatherOutput(result.ToString());
                }
                this.Writer.WriteGatheredOutput();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        private string[] SplitStringByChar(string toSplit, params char[] splitBy)
        {
            return toSplit.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);
        }
    }

}

