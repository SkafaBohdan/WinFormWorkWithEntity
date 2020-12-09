using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_Entity
{
    class Avto
    {
    //    [NotMapped]
        public int Id { get; set; }
    //    [Required]
        public string Model { get; set; }
    //    [Required]
        public string Marka { get; set; }
        public string Color { get; set; }
        public int Count_Doors { get; set; }
        public int EngineID { get; set; }
        public Engine Engines { get; set; }
        public int Type_BodyID { get; set; }
        public Type_Body TypesBodies { get; set; }

    }
}
