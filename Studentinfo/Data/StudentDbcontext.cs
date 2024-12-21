using Microsoft.EntityFrameworkCore;
using Studentinfo.Models.Domain;

namespace Studentinfo.Data
{
    public class StudentDbcontext:DbContext
    {
        public StudentDbcontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
