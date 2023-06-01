using AngularWebAPI.Models;
using AngularWebAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AngularWebAPI.Repository.Implementation
{
    public class StudentRepo: IStudentRepo
    {
        public AngularEmployeeDBContext _angularEmployeeDBContext { get; set; }
        public StudentRepo(AngularEmployeeDBContext angularEmployeeDBContext)
        {
            _angularEmployeeDBContext = angularEmployeeDBContext ?? throw new ArgumentNullException(nameof(angularEmployeeDBContext));
        }
        public IEnumerable<Student> GetStudent()
        {
            return _angularEmployeeDBContext.Students.ToList();
        }
        public Student AddStudent(Student objStudent)
        {
            _angularEmployeeDBContext.Students.Add(objStudent);
            _angularEmployeeDBContext.SaveChangesAsync();
            return objStudent;
        }
        public Student UpdateStudent(Student objStudent)
        {
            _angularEmployeeDBContext.Entry(objStudent).State = EntityState.Modified;
            _angularEmployeeDBContext.SaveChangesAsync();
            return objStudent;
        }
        public bool DeleteStudent(int ID)
        {
            bool result = false;
            var department = _angularEmployeeDBContext.Students.Find(ID);
            if (department != null)
            {
                _angularEmployeeDBContext.Entry(department).State = EntityState.Deleted;
                _angularEmployeeDBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
