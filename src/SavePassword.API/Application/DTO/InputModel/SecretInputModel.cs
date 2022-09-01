
using SavePassword.API.Application.Entity;

namespace SavePassword.API.Application.DTO.InputModel
{
    public class SecretInputModel
    {
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string WebSite { get; set; }
        public IList<AccountInputModel> Accounts { get; set; }
        public string Note { get; set; }

        public Secret ToEntity() => new()
        {
            Name = Name,
            IconUrl = IconUrl,
            WebSite = WebSite,
            Accounts = Accounts?.Select(s => s.ToEntity()).ToList(),
            Note = Note
        };
    }
}
