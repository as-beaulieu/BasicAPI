using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Models
{
    public class ElementModel
    {
        //Properties
        public int AtomicNumber { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal AtomicWeight { get; set; }
        public int GroupNumber { get; set; }
        public string Family { get; set; }
        public string Metallic { get; set; }
        public string State { get; set; }
        public bool IsStable { get; set; }

    }
}
