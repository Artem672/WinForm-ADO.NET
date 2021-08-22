using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Style { get; set; }
        public DateTime Release { get; set; }
        public bool Mode { get; set; }
        public int Sales { get; set; }
    }
}
