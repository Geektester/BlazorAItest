using System.ComponentModel.DataAnnotations;

namespace test1.Models // ✅ Note this namespace
{
    public class User
    {
      
        public string Username { get; set; }

     
        public string Email { get; set; }

       
        public string Password { get; set; }
    }
}
