using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    public class Lesson
    {
        internal string name;
        internal string group;
        internal string type;
        internal string x_day;
        internal string y_time;
        internal string lector;
        internal string audience;
        public Lesson() { }
        public Lesson(string name, string type, string x_day, string y_time, string lector, string audience)
        {
            this.name = name;
            this.type = type;
            this.x_day = x_day;
            this.y_time = y_time;
            this.lector = lector;
            this.audience = audience;
        }
        public Lesson(string name, string x_day, string y_time)
        {
            this.name = name;
            this.x_day = x_day;
            this.y_time = y_time;
        }
    }
}
