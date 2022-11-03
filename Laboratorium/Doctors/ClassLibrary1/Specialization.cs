namespace Solution1.ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Specialization
    {
        public int Id { get; set; }
        public int Type { get; set; }

        public Specialization(int id,  int type)
        {
            Id = id;
            Type = type;
        }
        

        
    }
}
