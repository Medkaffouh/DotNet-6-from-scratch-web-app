using Microsoft.EntityFrameworkCore;
using HelloWorldProject2.Model;

namespace HelloWorldProject2{

    public class MyDbContext:DbContext{
        public DbSet<Student> students{get;set;}
        public MyDbContext(DbContextOptions options):base(options){

        }
    }
}