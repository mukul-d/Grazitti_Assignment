using Grazitti_Assignment.Core.Interfaces;
using Grazitti_Assignment.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grazitti_Assignment.InfraStructure.Repositories
{
  public class StudentRepository : IAsyncStudentRespository
  {
    private GrazittiDbContext _dbContext;

    public StudentRepository(GrazittiDbContext dbContext) => _dbContext = dbContext;
    public async Task AddStudentAsync(Student student)
    {
      await _dbContext.Students.AddAsync(student);
      await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(int id)
    {
      var student = await GetStudentAsync(id);
      if (student != null)
      {
        _dbContext.Remove(student);
       await  _dbContext.SaveChangesAsync();
      }
    }

    public async Task<Student> GetStudentAsync(int id)
    {
     return await _dbContext.FindAsync<Student>(id);
    }

    public async Task<IEnumerable<Student>> GetStudentsAsync()
    {
      return await _dbContext.Students.ToListAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {

      var dbStudent = await GetStudentAsync(student.Id);

      dbStudent.FirstName = student.FirstName;
      dbStudent.LastName = student.LastName;
      dbStudent.Class = student.Class;
      dbStudent.Section = student.Section;

       _dbContext.Update(dbStudent);

      await _dbContext.SaveChangesAsync();
    }
  }
}
