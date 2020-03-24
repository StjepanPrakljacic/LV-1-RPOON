using System;
using System.Collections.Generic;
using System.Text;

namespace LV_1_RPPOON
{
    class Time_Note : Note
    {
        DateTime time = DateTime.Now;


        public Time_Note() : base() { this.time = DateTime.Now; }

        public Time_Note(string author, string text, int priority) : base(author, text, priority)
        {
        }

        public Time_Note(string author, string text, int priority, DateTime time)
            : base(author, text, priority)
        {
            this.time = time;
        }

        public DateTime Time
        {

            get { return this.time; }
            set { this.time = value; }


        }
        public override string ToString()
        {
            return base.ToString() + this.time;
        }
    }
}
