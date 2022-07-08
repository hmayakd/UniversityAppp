using UniversityAppp.Models;

namespace UniversityAppp.Services
{
    internal class StudentService : IStudentService
    {
        static List<Student> _students = new List<Student>();

        public void Create(Student? student)
        {
            if (student != null)
                _students.Add(student);
        }

        public void Delete(Guid id)
        {
            _students.RemoveAll(x => x.Id == id);
        }

        public Student? Get(Guid id)
            => _students.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Student>? GetAll()
            => _students;

        public void Update(Student? student)
        {
            Student? currentStudent = _students.FirstOrDefault(s => s.Id == student?.Id);
            int index = -1;
            if (currentStudent != null)
                index = _students.IndexOf(currentStudent);
            if (student != null)
                _students[index] = student;
        }
    }
}