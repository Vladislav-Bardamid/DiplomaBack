﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomaBack.DAL.Entities
{
  public class Tutor
    {
      public int Id { get; set; }
      public int UserId { get; set; }
      public User User { get; set; }
      public int CountPluses { get; set; }
      public int CountMinuses { get; set; }

  }
}
