namespace BlazorApp1
{
    public interface IUserRepository
    {
        Task<UserEntity?> GetByUsernameAsync(string username);
    }

    public class UserRepository : IUserRepository
    {
        private readonly ICollection<UserEntity> _users;

        public UserRepository(ICollection<UserEntity> users)
        {
            _users = users;
        }

        public Task<UserEntity?> GetByUsernameAsync(string username)
        {
            var record = _users?.FirstOrDefault(x => x.Username!.Equals(username, StringComparison.InvariantCultureIgnoreCase));

            return Task.FromResult(record);
        }
    }

    public static class UserRecords
    {
        public static readonly UserEntity[] Records = new[]
        {
            new UserEntity { Username = "michael", Password = HashUtility.MD5Hash("michael") },
            new UserEntity { Username = "bryce", Password = HashUtility.MD5Hash("bryce") },
        };
    }

    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
