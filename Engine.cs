using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_Entity
{
    class Engine
    {
        public int EngineID { get; set; }
        public string Type_Engine { get; set; }

        public ICollection<Avto> Avtos { get; set; }
    }
}
