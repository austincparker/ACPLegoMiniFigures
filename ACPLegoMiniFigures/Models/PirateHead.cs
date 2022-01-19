using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACPLegoMiniFigures.Models
{
    internal class PirateHead : LegoHeadBase
    {
        public PirateHead()
        {
            Theme = "Pirate";
        }

        public bool HasHat { get; set; }

    }
}
