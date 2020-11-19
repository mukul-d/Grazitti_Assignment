using Grazitti_Assignment.Core.Interfaces;
using Grazitti_Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grazitti_Assignment.Core.Services
{
  public class StudentService : IAsyncStudentService
  {
    private IAsyncStudentRespository _repository;

    public StudentService(IAsyncStudentRespository respository) => _repository = respository;
    public async Task AddStudentAsync(Student student)
    {
      await _repository.AddStudentAsync(student);
    }

    public async Task DeleteStudentAsync(int id)
    {
      await _repository.DeleteStudentAsync(id);
    }

    public async Task<Student> GetStudentAsync(int id)
    {
     return  await _repository.GetStudentAsync(id);
    }

    public async Task<IEnumerable<Student>> GetStudentsAsync()
    {
      return await _repository.GetStudentsAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
      await _repository.UpdateStudentAsync(student);
    }
  }
}
