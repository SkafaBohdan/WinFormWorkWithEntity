using System.Data.Entity;

namespace Laba_Entity
{
    class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection") { }

        public DbSet<Avto> Avtos { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Type_Body> Type_Bodies { get; set; }
  
    }
}
