using System;

namespace DSP_Examples
{
    class Program
    {
        static void Main()
        {
            int sampleRate = 100; //Baseband Samples/Second
            int numberSamples = 1000; //Samples
            double bbFrequency = 10; //Baseband cycles/Second
            double rfFrequency = 1e9;
            double[] iValues = new double[numberSamples];
            double[] qValues = new double[numberSamples];
            initializeCW(numberSamples, sampleRate, bbFrequency, iValues, qValues);
            int k = 0;
            foreach(double j in iValues)
            {
                Console.WriteLine(j);
            }
        }

        //ToDo: Filters, Windowing 
        static void initializeCW(int numberSamples, int sampleRate, double bbFrequency, double[] iValues, double[] qValues)
        {
            for (int i = 0; i < numberSamples; i++)
            {
               iValues[i] = Math.Cos(2 * Math.PI * bbFrequency * i / sampleRate);
               qValues[i] = Math.Sin(2 * Math.PI * bbFrequency * i / sampleRate);
            }
        }
    }
}
