using BCVP.Model;
using Newtonsoft.Json;


namespace BCVP.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> Query()
        {
            await Task.CompletedTask;
            var data = "[{\"id\":1,\"Name\":\"laozhang\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();

        }
    }
}
