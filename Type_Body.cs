using System;
using System.Collections.Generic;


namespace Laba_Entity
{
    class Type_Body
    {
        public int Type_BodyID { get; set; }
        public string NameBody { get; set; }

        public ICollection<Avto> Avtos { get; set; }
    }
}
