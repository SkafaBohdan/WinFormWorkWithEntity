using System.ComponentModel.DataAnnotations;


namespace Laba_Entity
{
    class Avto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Marka { get; set; }
        public string Color { get; set; }
        public int Count_Doors { get; set; }
        public int EngineID { get; set; }
        public Engine Engines { get; set; }
        public int Type_BodyID { get; set; }
        public Type_Body TypesBodies { get; set; }

    }
}
