using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    [Serializable]
    public class Event
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int Priority { get; set; }

        public override string ToString()
        {
            return String.Format(Name);
        }
    }
}
