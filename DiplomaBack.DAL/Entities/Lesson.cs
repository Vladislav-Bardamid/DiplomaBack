using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomaBack.DAL.Entities
{
    public class Lesson
    {
      public int Id { get; set; }
      public int TutorId { get; set; }
      public Tutor Tutor { get; set; }
      public int UserId { get; set; }
      public User User { get; set; }
      public int SubjectId { get; set; }
      public Subject Subject { get; set; }
      public DateTime TimeOfStart { get; set; }
      public DateTime TimeOfEnd { get; set; }

  }
}
