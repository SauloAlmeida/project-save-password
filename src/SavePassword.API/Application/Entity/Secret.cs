using SavePassword.API.Application.Entity.Common;

namespace SavePassword.API.Application.Entity
{
    public class Secret : BaseEntity
    {
        public string Name { get; set; }
        public string? IconUrl { get; set; }
        public string? WebSite { get; set; }
        public IList<Account> Accounts { get; set; } = new List<Account>(); 
        public string? Note { get; set; }

        public void AddAccount(Account acc) => Accounts.Add(acc);

        public void RemoveAccount(Guid id)
        {
            var account = Accounts.FirstOrDefault(x => x.Id == id);

            if (account != null) account.Delete();
        }
    }
}
