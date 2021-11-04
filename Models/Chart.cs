using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Models
{
    public class Chart
    {
        public List<string> xValues; //["Italy", "France", "Spain", "USA", "Argentina"];
        public List<int> yValues; // [55, 49, 44, 24, 15];
        public List<string> barColors; // ["red", "green", "blue", "orange", "brown"];
    }
}
