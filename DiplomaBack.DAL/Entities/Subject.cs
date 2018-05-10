﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomaBack.DAL.Entities
{
  public class Subject
  {
    public int Id { get; set; }
    public int FileId { get; set; }
    public File File { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
  }
}
