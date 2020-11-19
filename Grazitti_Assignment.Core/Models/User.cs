using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grazitti_Assignment.Core.Models
{
  public class User:IdentityUser
  {
    public string Firstname { get; set; }
    public string LastName { get; set; }
  }
}
