using Microsoft.AspNetCore.Identity;

namespace DiplomaBack.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
    }
}