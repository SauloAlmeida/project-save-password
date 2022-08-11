namespace SavePassword.API.Application.Model.Common
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
        public bool Deleted { get; private set; } = false;

        public void Delete() => Deleted = true;
    }
}
