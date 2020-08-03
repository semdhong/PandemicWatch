using Pegasus.Command.CommonUI.Services.Contracts;
using Pegasus.Command.Shared.Dto;
using System.Net.Http;
using System.Threading.Tasks;
using Pegasus.Command.Shared.Dto.Account;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Pegasus.Command.CommonUI.Services.Implementations
{
    public class UserProfileApi : IUserProfileApi
    {
        private readonly HttpClient _httpClient;

        public UserProfileApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResponseDto> Get()
        {
           HttpResponseMessage response = await _httpClient.GetAsync("api/UserProfile/Get");
           return JsonConvert.DeserializeObject<ApiResponseDto>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ApiResponseDto> Upsert(UserProfileDto userProfile)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/UserProfile/Upsert", userProfile);
            return JsonConvert.DeserializeObject<ApiResponseDto>(await response.Content.ReadAsStringAsync());
        }
    }
}
