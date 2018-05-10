using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomaBack.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public string Text { get; set; }
    }
}
