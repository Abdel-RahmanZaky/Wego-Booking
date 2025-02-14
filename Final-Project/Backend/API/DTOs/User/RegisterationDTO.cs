using System.ComponentModel.DataAnnotations;

namespace API.DTOs.User
{
    public class RegisterationDTO
    {

        public string UserName { get; set; }
        //public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
