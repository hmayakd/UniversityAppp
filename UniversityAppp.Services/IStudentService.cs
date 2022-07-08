using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAppp.Models;

namespace UniversityAppp.Services
{
    public interface IStudentService
    {
        IEnumerable<Student>? GetAll();
        Student? Get(Guid id);
        void Create(Student? student);
        void Update(Student? student);
        void Delete(Guid id);
    }
}
