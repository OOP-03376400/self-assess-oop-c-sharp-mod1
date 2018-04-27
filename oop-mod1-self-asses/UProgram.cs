using System;

namespace oop_mod1_self_asses
{
    public class UProgram
    {
        public string UProgramName { get; set; }

        public Degree BS;

        public UProgram(string uprogramName, Degree bs)
        {
            UProgramName = uprogramName;
            BS = bs;
        }

    }

}
