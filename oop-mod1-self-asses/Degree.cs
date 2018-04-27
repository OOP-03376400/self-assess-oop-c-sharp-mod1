using System;

namespace oop_mod1_self_asses
{
    public class Degree
    {
        public string DegreeName { get; set; }

        private Course course;
       
        public Degree(string degreeName, Course compSci)
        {
            DegreeName = degreeName;
            course = compSci;
        }

    }
    
}

 
