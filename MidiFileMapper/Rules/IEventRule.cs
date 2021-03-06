using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Midi;

namespace MarkHeath.MidiUtils
{
    public interface IEventRule
    {
        bool Apply(MidiEvent midiEvent, EventRuleArgs args);
    }

    public class EventRuleArgs : EventArgs
    {
        private string outFileName;

        public EventRuleArgs(string outFileName)
        {
            this.outFileName = outFileName;
        }

        public string OutFileName
        {
            get { return outFileName; }
        }
    }
}
