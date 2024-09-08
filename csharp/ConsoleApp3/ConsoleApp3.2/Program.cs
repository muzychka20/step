using System;
using System.Collections.Generic;

namespace ConsoleApp3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MusicalInstrument> musicalInstruments = new List<MusicalInstrument>();
            musicalInstruments.Add(new MusicalInstrument());
            musicalInstruments.Add(new Guitar());
            musicalInstruments.Add(new Piano());

            foreach (var instrument in musicalInstruments)
            {
                instrument.Play();
            }
        }
    }
}
