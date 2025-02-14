using Data_Layer.Context;

namespace API.DTOs.User
{
    public class UserDTO
    {
        public bool Status { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Token { get; set; }


    }
}