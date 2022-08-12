using SavePassword.API.Application.Entity.Common;

namespace SavePassword.API.Application.Entity
{
    public class Account : BaseModel
    {
        public string? NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Note { get; set; }
    }
}
