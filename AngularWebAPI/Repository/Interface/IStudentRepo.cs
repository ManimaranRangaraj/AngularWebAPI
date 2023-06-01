using AngularWebAPI.Models;

namespace AngularWebAPI.Repository.Interface
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetStudent();
        Student AddStudent(Student objStudent);
        Student UpdateStudent(Student objStudent);
        bool DeleteStudent(int ID);
    }
}
