namespace WebApplication1.Models
{

    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
            

        }

        public System.Data.Entity.DbSet<WebEval.Models.Student> Students { get; set; }
    }
}