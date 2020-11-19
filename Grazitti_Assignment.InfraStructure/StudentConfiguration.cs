using Grazitti_Assignment.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grazitti_Assignment.InfraStructure
{
  public class StudentConfiguration : IEntityTypeConfiguration<Student>
  {
    public void Configure(EntityTypeBuilder<Student> builder)
    {
      builder.HasData(
        new Student
        {
          Id = 1,
          FirstName = "Student1",
          LastName = "Last1",
          Class = 7,
          Section = "B"
        }, new Student
        {
          Id = 2,
          FirstName = "Student2",
          LastName = "Last3",
          Class = 5,
          Section = "A"
        }, new Student
        {
          Id = 3,
          FirstName = "Student3",
          LastName = "Last3",
          Class = 7,
          Section = "B"
        }, new Student
        {
          Id = 4,
          FirstName = "Student4",
          LastName = "Last4",
          Class = 7,
          Section = "D"
        }

        );
    }
  }
}
