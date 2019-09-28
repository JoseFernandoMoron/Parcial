using System.Data.Entity;

namespace apiEval
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiEval.Models.Clown> Clowns { get; set; }
    }
}