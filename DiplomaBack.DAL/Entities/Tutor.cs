using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomaBack.DAL.Entities
{
    public class Tutor
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public User Identity { get; set; }
        public int CountPluses { get; set; }    
        public int CountMinuses { get; set; }
    }
}
