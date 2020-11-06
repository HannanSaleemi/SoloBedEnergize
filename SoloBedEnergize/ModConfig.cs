using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloBedEnergize
{
    class ModConfig
    {
        public int energyRate { get; set; }
        public int healthRate { get; set; }
        
        public ModConfig()
        {
            this.energyRate = 2;
            this.healthRate = 2;
        }
    }
}
