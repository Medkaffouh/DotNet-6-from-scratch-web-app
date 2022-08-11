using Microsoft.AspNetCore.Mvc;
using HelloWorldProject2.Model;

namespace HelloWorldProject2{
    [Route("/api/students")]
    public class StudentRestService:Controller{
        private MyDbContext dbService;

        public StudentRestService(MyDbContext dbContext){
            dbService=dbContext;
        }

        [HttpGet]
        public IEnumerable<Student> list(){
            return dbService.students;
        }

        [HttpGet("{Id}")]
        public Student GetOne(long Id){
            return dbService.students.FirstOrDefault(s=>s.Id==Id);
        }

        [HttpPost]
        public Student Save([FromBody]Student student){
            dbService.students.Add(student);
            dbService.SaveChanges();
            return student;
        }

        [HttpDelete("{Id}")]
        public void Delete(long Id){
            Student student = dbService.students.FirstOrDefault(s=>s.Id==Id);
            dbService.students.Remove(student);
            dbService.SaveChanges();
        }

        [HttpPut("{Id}")]
        public Student Update(long Id,[FromBody]Student student){
            student.Id=Id;
            dbService.students.Update(student);
            dbService.SaveChanges();
            return student;
        }
    }
}