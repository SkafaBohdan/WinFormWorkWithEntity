using System;
using System.Collections.Generic;


namespace Laba_Entity
{
    class Engine
    {
        public int EngineID { get; set; }
        public string Type_Engine { get; set; }

        public ICollection<Avto> Avtos { get; set; }
    }
}
