using UniversityAppp.Models;

namespace UniversityAppp.Services
{
    internal class TeacherService: ITeacherService
    {
        static List<Teacher> teachers = new List<Teacher>();
        public void Create(Teacher? teacher)
        {
            if (teacher != null)
                teachers.Add(teacher);
        }

        public void Delete(Guid id)
        {
            teachers.RemoveAll(t => t.Id == id);
        }

        public Teacher? Get(Guid id)
        {
            return teachers.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Teacher>? GetAll()
        {
            return teachers;
        }

        public void Update(Teacher? teacher)
        {
            Teacher? currentTeacher = new Teacher();
            if (teacher != null)
                currentTeacher = teachers.FirstOrDefault(t => t.Id == teacher.Id);
            int currTeacIndex = -1;
            if (currentTeacher != null)
                currTeacIndex = teachers.IndexOf(currentTeacher);
            if (teacher != null)
                teachers[currTeacIndex] = teacher;
        }
    }
}
