using Task_Manager.Models.Interfaces;

namespace Task_Manager.Models
{
    public class UserModel : IUserInterface
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
