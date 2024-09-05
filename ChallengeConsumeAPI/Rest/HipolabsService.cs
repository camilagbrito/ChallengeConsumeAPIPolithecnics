using ChallengeConsumeAPI.Interfaces;
using ChallengeConsumeAPI.Models;
using System.Text.Json;

namespace ChallengeConsumeAPI.Request
{
    public class HipolabsService: IHipolabsService
    {
       
        public async Task<List<Institute>> GetPolytechnics()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://universities.hipolabs.com/search?country=Portugal");
            
            var response = new List<Institute>();

            using (var httpClient = new HttpClient())
            {
                var responseHipolabsApi = await httpClient.SendAsync(request);
                var contentResp = await responseHipolabsApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<Institute>>(contentResp);

                var polythecnics = objResponse?.Where(x => x.Name.Contains("Polit")).ToList();

                return polythecnics;
            }
        }
    }
}
