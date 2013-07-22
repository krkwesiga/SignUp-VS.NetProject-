using System.Data.Entity;

namespace SignUp.Models
{
    public class SignUpEntities : DbContext
    {
      public DbSet<SignUp> SignUps { get; set; }
    }
}