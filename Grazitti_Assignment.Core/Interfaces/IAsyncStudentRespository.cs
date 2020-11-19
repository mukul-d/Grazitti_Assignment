using Grazitti_Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grazitti_Assignment.Core.Interfaces
{
  public interface IAsyncStudentRespository
  {
    public Task<IEnumerable<Student>> GetStudentsAsync();
    public Task<Student> GetStudentAsync(int id);
    public Task AddStudentAsync(Student student);
    public Task DeleteStudentAsync(int id);
    public Task UpdateStudentAsync(Student student);
  }
}
