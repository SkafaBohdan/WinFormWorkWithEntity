using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_Entity
{
    class Type_Body
    {
        public int Type_BodyID { get; set; }
        public string NameBody { get; set; }

        public ICollection<Avto> Avtos { get; set; }
    }
}
