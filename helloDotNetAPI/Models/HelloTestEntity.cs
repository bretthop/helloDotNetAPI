using System.Data.Entity;

namespace helloDotNetAPI.Models
{
    public class HelloTestTwoContext : DbContext
    {
        public DbSet<HelloTestEntity> HelloTestEntities { get; set; }
    }

    public class HelloTestEntity
    {
        public int Id { get; set; }
        public string TestProperty { get; set; }
    }
}