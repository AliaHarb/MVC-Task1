namespace MVC_Task1.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed",address="Cairo", ImageURL = "4.jpg" });
            students.Add(new Student() { Id = 2, Name = "Ali", address = "Cairo", ImageURL = "2.jpg" });
            students.Add(new Student() { Id = 3, Name = "Alia", address = "Cairo", ImageURL = "1.jpg" });
            students.Add(new Student() { Id = 4, Name = "yara", address = "Cairo", ImageURL = "3.jpg" });
        }
        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students.FirstOrDefault(st => st.Id == id);
        }
    }
}
