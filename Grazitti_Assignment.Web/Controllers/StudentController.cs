
using Grazitti_Assignment.Core.Interfaces;
using Grazitti_Assignment.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grazitti_Assignment.Web.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class StudentController : ControllerBase
  {
    private readonly IAsyncStudentService _StudentService;
    public StudentController(IAsyncStudentService StudentService) => _StudentService = StudentService;

    [HttpGet]
    public async Task<IEnumerable<Student>> Get()
    {
      return await _StudentService.GetStudentsAsync();

    }

    [HttpGet("{id}")]
    public async Task<Student> Get(int id)
    {
      return await _StudentService.GetStudentAsync(id);
    }

    [HttpDelete]
    public async Task Delete(int id)
    {
      await _StudentService.DeleteStudentAsync(id);
    }

    [HttpPost]
    public async Task Add(Student student)
    {
      await _StudentService.AddStudentAsync(student);
    }

    [HttpPatch]
    public async Task Update(Student student)
    {
      await _StudentService.UpdateStudentAsync(student);
    }
  }

}
